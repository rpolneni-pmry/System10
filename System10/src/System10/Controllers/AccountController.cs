using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System10.Models;
using System.Security.Principal;
using Microsoft.AspNetCore.Http.Features;
using Novell.Directory.Ldap;
using System10.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace System10.Controllers
{
    public class AccountController : Controller
    {
        private readonly System10Context _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ISmsSender _smsSender;
        private readonly ILogger _logger;

        public AccountController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender,
            ISmsSender smsSender,
            ILoggerFactory loggerFactory, System10Context context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _smsSender = smsSender;
            _logger = loggerFactory.CreateLogger<AccountController>();
            _context = context;
        }
        //public AccountController(System10Context context)
        //{

        //    _context = context;
    
        //}
        private void SetSessionUserName(string name)
        {
            HttpContext.Session.SetString("lUserName", name);
        }
        public IActionResult Index()
        {
            var logusr = User.Identity.Name;

            var loggedInUser = HttpContext.User.Identity as WindowsIdentity;
            
           
            if (loggedInUser?.User?.AccountDomainSid?.Value == "S-1-5-21-2610387755-854405893-26240035430")
            {
                // DboCredentialAlternate userCred = _context.DboCredentialAlternate.SingleOrDefault(m => m.Vchr64UserName == GetLoggedInUser(loggedInUser));
               
                var winLoginNameTrim = loggedInUser.Name.Split('\\');
                var winLoginName = winLoginNameTrim.Last();
                TempData["UserName"] = winLoginName;
                SetSessionUserName(winLoginName);
                //checking in CredentialAlternate table 
                 DboCredentialAlternate userCred = _context.DboCredentialAlternate.SingleOrDefault(m => m.Vchr64UserName == winLoginName);
               
                if (userCred != null)
                {
                    //Checking in credential table 
                    var userObject = _context.DboCredential.SingleOrDefault(m => m.BintId == userCred.BintPrimaryCredentialId && m.BEnabled == true);

                    if (userObject != null)
                    {

                        return RedirectToAction(nameof(CredentialsController.ManageCredentials), "Credentials", new { debug = "" });
                    }

                }

                new BusinessLayer(_context).CreateWindowsUserCredential(winLoginName);

                return RedirectToAction(nameof(CredentialsController.ManageCredentials), "Credentials", new { debug = "" });


            }
            else
            {
                //getting IP address and checking against CredentialOrganizationInfo table
                var remoteIpAddress = HttpContext.Features.Get<IHttpConnectionFeature>()?.RemoteIpAddress.ToString();

                var creOrg = _context.DboCredentialOrganizationInfo.SingleOrDefault(m => m.Vchr40Ip == remoteIpAddress && m.BAllowIpsignon == true);
                if (creOrg != null)
                {
                    //Checking in Credential table 
                    var userObject = _context.DboCredential.SingleOrDefault(m => m.BintId == creOrg.BintCredentialId && m.BEnabled == true);
                    if (userObject != null)
                    {
                        TempData["UserName"] = userObject.Vchr32Name;
                        HttpContext.Session.SetString("lUserName", userObject.Vchr32Name);
                        return RedirectToAction(nameof(CredentialsController.ManageCredentials), "Credentials", new { debug = "" });
                    }
                    else
                    {
                        return RedirectToAction(nameof(HomeController.Error), "Home", new { debug = "" });
                    }
                }
                else
                {
                    return RedirectToAction(nameof(AccountController.Login), "Account", new { debug = "" });
                }

            }
            
        }

        private static WindowsIdentity GetLoggedInUser(WindowsIdentity loggedInUser)
        {
            return loggedInUser;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        //Active directory users login
        public IActionResult Login(Models.LoginViewModel userr, string ReturnUrl)
        {
            //Authenticating using Active Directory
            using (var cn = new LdapConnection())
            {
                // connect
                //   cn.Connect("<<hostname>>", 389);
                // bind with an username and password
                // this how you can verify the password of an user

                cn.SecureSocketLayer = true;
                cn.Connect("hqmsdcw01.pomeroy.msft", 636);
                //    string Username = WindowsIdentity.GetCurrent().Name.ToString();

                //var CurLoggedUser = User.Identity.IsAuthenticated;

                //   string domain = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainNamel;



                try
                {
                    cn.Bind(userr.Email, userr.Password);
                    //checking in Credential Alternate Table
                    DboCredentialAlternate userCred = _context.DboCredentialAlternate.SingleOrDefault(m => m.Vchr64UserName == userr.Email);
                    if (userCred != null)
                    {
                        TempData["UserName"] = userr.Email;
                        HttpContext.Session.SetString("lUserName", userr.Email);
                        //checking in Credential table
                        var userObject = _context.DboCredential.SingleOrDefault(m => m.BintId == userCred.BintPrimaryCredentialId && m.BEnabled == true);

                        if (userObject != null)
                        {
                            return RedirectToAction(nameof(CredentialsController.ManageCredentials), "Credentials", new { actiontype = "ad" });
                        }
                    }
                        new BusinessLayer(_context).CreateActiveDirectoryUserCredential(userr);

                    return RedirectToAction(nameof(CredentialsController.ManageCredentials), "Credentials", new { actiontype = "ad" });


                }
                catch (Exception e)
                {
                    var isUseExists= new BusinessLayer(_context).ValidateUser(Utility.GetUserNameFromEmail(userr.Email), userr.Password);
                    if(isUseExists > 0)
                    {
                        HttpContext.Session.SetString("lUserName", userr.Email);
                        return RedirectToAction(nameof(HomeController.Index), "Home", new { debug = "" });
                    }
                    ViewData["ErrorMessage"] = "Please provide valid user name and password";
                }
            }


            return View();
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(Models.RegisterviewModel model)
        {
            var url = string.Format("{0}://{1}/{2}{3}", Request.Scheme, Request.Host, "Credentials/ManageCredentials/?email=", model.Email);
            var user = _context.DboCredentialOrganizationInfo.SingleOrDefault(m => m.Vchr128EMailDomain == Utility.GetUserNameFromEmail(model.Email, true) && m.BAllowEmailAssociation == true && m.BAllowSelfRegistration == true);

            if (user != null)
            {
                new AuthMessageSender().SendEmail(model.Email, "subject", "body message <a href=" + url + ">click here</a>");
            }
            else
            {
                ViewData["ErrorMessage"] = "You are not a valid user";
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            HttpContext.Session.SetString("lUserName", string.Empty);
            await _signInManager.SignOutAsync();
            _logger.LogInformation(4, "User logged out.");
            return RedirectToAction(nameof(HomeController.Index), "Home");
           // return RedirectToAction(nameof(AccountController.Index), "Account", new { debug = "" });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult ExternalLogin(string provider, string returnUrl = null)
        {
            // Request a redirect to the external login provider.
            var redirectUrl = Url.Action("ExternalLoginCallback", "Account", new { ReturnUrl = returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return Challenge(properties, provider);
        }
        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }
        //
        // GET: /Account/ExternalLoginCallback
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null, string remoteError = null)
        {
            if (remoteError != null)
            {
                ModelState.AddModelError(string.Empty, $"Error from external provider: {remoteError}");
                return View(nameof(Login));
            }
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return RedirectToAction(nameof(Login));
            }

            // Sign in the user with this external login provider if the user already has a login.
            //var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false);
            //if (result.Succeeded)
            //{
            //    _logger.LogInformation(5, "User logged in with {Name} provider.", info.LoginProvider);
            //    return RedirectToLocal(returnUrl);
            //}
            //if (result.RequiresTwoFactor)
            //{
            //    return RedirectToAction(nameof(SendCode), new { ReturnUrl = returnUrl });
            //}
            //if (result.IsLockedOut)
            //{
            //    return View("Lockout");
            //}
            else
            {
                // If the user does not have an account, then ask the user to create an account.
                ViewData["ReturnUrl"] = returnUrl;
                ViewData["LoginProvider"] = info.LoginProvider;
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);
                var dbAltObj = _context.DboCredentialAlternate.SingleOrDefault(m => m.Vchr64UserName == email.Trim());
                if(dbAltObj != null)
                {
                    var dbCrObj = _context.DboCredential.SingleOrDefault(m => m.BintId == dbAltObj.BintPrimaryCredentialId && m.BEnabled==true);
                    if(dbCrObj != null)
                    {
                        SetSessionUserName(dbCrObj.Vchr32Name);
                        return RedirectToAction(nameof(HomeController.Index), "Home", new { debug = "" });

                    }
                }
                
                return View("ExternalLoginConfirmation", new ExternalLoginConfirmationViewModel { Email = email });
            }
        }

        //
        // POST: /Account/ExternalLoginConfirmation
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ExternalLoginConfirmation(ExternalLoginConfirmationViewModel model, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                // Get the information about the user from the external login provider
                var info = await _signInManager.GetExternalLoginInfoAsync();
                if (info == null)
                {
                    return View("ExternalLoginFailure");
                }
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                var result = await _userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    result = await _userManager.AddLoginAsync(user, info);
                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        _logger.LogInformation(6, "User created an account using {Name} provider.", info.LoginProvider);
                        return RedirectToLocal(returnUrl);
                    }
                }
                //AddErrors(result);
            }

            ViewData["ReturnUrl"] = returnUrl;
            return View(model);
        }

        // GET: /Account/ConfirmEmail
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Error");
            }
            var result = await _userManager.ConfirmEmailAsync(user, code);
            return View(result.Succeeded ? "ConfirmEmail" : "Error");
        }


    }
}