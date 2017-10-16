using System;
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
    public class AccountController : BaseController
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <ex
        //private void SetSessionUserName(string name)
        //{
        //    HttpContext.Session.SetString("lUserName", name);
        //}
        public IActionResult AccessDenied()
        {

            return View();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //step 1 user hits the site
        public IActionResult Index()
        {
            //step 11 check whether user using self registration link.
            if (HttpContext.Request.Query["token"].ToString() != string.Empty)
            {
                string token = HttpContext.Request.Query["token"].ToString();
                //step 13
                return RedirectToAction("VerifyEmail", "Account", new { token = token });
                //return  this.VerifyEmail(email);
            }
            else
            {
                //step 2 checking user is in our network.
                string logusr = User.Identity.Name;
                //string logusr = User.Identity.Name;

                WindowsIdentity loggedInUser = HttpContext.User.Identity as WindowsIdentity;


                //if (loggedInUser?.User?.AccountDomainSid?.Value == "S-1-5-21-2610387755-854405893-26240035430")
                //string sid = _context.DboSystemConfiguration.SingleOrDefault(m => m.IId == 50).v;
                if (loggedInUser?.User?.AccountDomainSid?.Value == "S-1-5-21-2610387755-854405893-26240035430")
                {
                    // DboCredentialAlternate userCred = _context.DboCredentialAlternate.SingleOrDefault(m => m.Vchr64UserName == GetLoggedInUser(loggedInUser));

                    string[] winLoginNameTrim = loggedInUser.Name.Split('\\');
                    string winLoginName = winLoginNameTrim.Last();
                    TempData["UserName"] = winLoginName;
                    SetSessionUserName(winLoginName);
                    //step 3 checking in CredentialAlternate table 
                    DboCredentialAlternate userCred = _context.DboCredentialAlternate.SingleOrDefault(m => m.Vchr64UserName == loggedInUser.Name);

                    if (userCred != null)
                    {
                        // step 4 Checking in credential table 
                        DboCredential userObject = _context.DboCredential.SingleOrDefault(m => m.BintId == userCred.BintPrimaryCredentialId && m.BEnabled == true);

                        if (userObject != null)
                        {
                            //stpe 5 sign on 
                            return RedirectToAction(nameof(CredentialsController.ManageCredentials), "Credentials", new { actiontype = "ad" });
                        }

                    }
                       
                    //step 6 creating records for the user.
                    new BusinessLayer(_context).CreateWindowsUserCredential(winLoginName, loggedInUser.Name);

                    return RedirectToAction(nameof(CredentialsController.ManageCredentials), "Credentials", new { actiontype = "ad" });


                }
                else
                {
                    //getting IP address and checking against CredentialOrganizationInfo table
                    string remoteIpAddress = HttpContext.Features.Get<IHttpConnectionFeature>()?.RemoteIpAddress.ToString();
                    //step 26 checking IP address in COI.
                    DboCredentialOrganizationInfo creOrg = _context.DboCredentialOrganizationInfo.SingleOrDefault(m => m.Vchr40Ip == remoteIpAddress && m.BAllowIpsignon == true);
                    if (creOrg != null)
                    {
                        //step 11 Checking in Credential table 
                        DboCredential userObject = _context.DboCredential.SingleOrDefault(m => m.BintId == creOrg.BintCredentialId && m.BEnabled == true);
                        if (userObject != null)
                        {
                            //step 16 sign on as org
                            TempData["UserName"] = userObject.Vchr32Name;
                            HttpContext.Session.SetString("lUserName", userObject.Vchr32Name);
                            return RedirectToAction(nameof(CredentialsController.ManageCredentials), "Credentials", new { actiontype = "ad" });
                        }
                        else
                        {
                            //setp 10 Access Denied
                            return RedirectToAction(nameof(AccountController.AccessDenied), "Account", new { debug = "" });
                            //return RedirectToAction(nameof(HomeController.Error), "Home", new { debug = "" });
                        }
                    }
                    else
                    {
                        //step 17 login page
                        return RedirectToAction(nameof(AccountController.Login), "Account", new { debug = "" });
                    }

                }
            }

          
            
        }
/// <summary>
/// sertet
/// </summary>
/// <param name="model">er</param>
/// <param name="token">tykty</param>
/// <returns></returns>
        [HttpPost]
        public IActionResult VerifyEmail(RegisterviewModel model,string token)
        {
            DboEmailVerification dbEmv = _context.DboEmailVerification.SingleOrDefault(m => m.Vchr250Token == token && m.BEnabled == true );
            if(dbEmv != null)
            {
                string username = model.UserName;
                byte[] password= System.Text.Encoding.Unicode.GetBytes(model.Password);
                string domainName = Utility.GetUserNameFromEmail(dbEmv.Nvch128Email, true);
                TempData["UserName"] = username;
                LoginViewModel mode1 = new LoginViewModel { Email = dbEmv.Nvch128Email };

                DboCredentialOrganizationInfo user = _context.DboCredentialOrganizationInfo.SingleOrDefault(m => m.Vchr128EMailDomain == domainName && m.BAllowEmailAssociation == true && m.BAllowSelfRegistration == true);
                //validate whether user record exists
                DboCredential dbCr = _context.DboCredential.SingleOrDefault(m=>m.Vchr32Name ==model.UserName  && m.Bin64PasswordHash == password && m.BEnabled==false);
                if(dbCr != null)
                {
                    //step 6 creating user records.
                    new BusinessLayer(_context).CreateNormalUserCredential(username, user.BintCredentialId);
                    TempData["UserName"] = username;
                    SetSessionUserName(username);
                    dbEmv.BEnabled = false;
                    _context.DboEmailVerification.Update(dbEmv);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(CredentialsController.ManageCredentials), "Credentials", new { debug = "" });
                }
                else
                {
                    ViewData["ErroMessage"] = "User doenst not exists";
                    return View();
                }
               
            }
            else
            {
                //step 10 Access Denied.
                return RedirectToAction(nameof(AccountController.AccessDenied), "Account", new { debug = "" });
            }
            
        }
        //step 12 checking for valid link.
        public IActionResult VerifyEmail(string token)
        {
            @ViewData["token"] = token;
            DboEmailVerification dbEmv = _context.DboEmailVerification.SingleOrDefault(m => m.Vchr250Token == token && m.BEnabled == true);
            if (dbEmv != null)
            {
              
                return View();
            }
            else
            {
                //Access denied page
                return RedirectToAction(nameof(AccountController.AccessDenied), "Account", new { debug = "" });
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
               
                //    string Username = WindowsIdentity.GetCurrent().Name.ToString();

                //var CurLoggedUser = User.Identity.IsAuthenticated;

                //   string domain = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainNamel;

                if(userr.Email.Contains("\\"))
                {
                    string[] winLoginNameTrim = userr.Email.Split('\\');
                    string winLoginName = winLoginNameTrim.Last();
                    string domainName = winLoginNameTrim.First();
                    DboCredentialOrganizationInfo dbCrOrgInfo = _context.DboCredentialOrganizationInfo.FirstOrDefault(m=>m.Vchr8Ldapdomain==(domainName) && m.BAllowLdapauthentication==true);
                    if(dbCrOrgInfo != null)
                    {
                        cn.SecureSocketLayer = true;
                        // cn.Connect("hqmsdcw01.pomeroy.msft", 636);
                        cn.Connect(dbCrOrgInfo.Vchr64LdaphostName, dbCrOrgInfo.ILdapportNumber.Value);
                        try
                        {
                            cn.Bind(userr.Email, userr.Password);
                            //step 18 checking in Credential Alternate Table
                            DboCredentialAlternate userCred = _context.DboCredentialAlternate.SingleOrDefault(m => m.Vchr64UserName == userr.Email);
                            if (userCred != null)
                            {


                                TempData["UserName"] = winLoginName;
                                SetSessionUserName(winLoginName);

                                //step 19 checking in Credential table
                                DboCredential userObject = _context.DboCredential.SingleOrDefault(m => m.BintId == userCred.BintPrimaryCredentialId && m.BEnabled == true);

                                if (userObject != null)
                                {
                                    //step 5 sign on as user
                                    return RedirectToAction(nameof(CredentialsController.ManageCredentials), "Credentials", new { actiontype = "ad" });
                                }
                            }
                            new BusinessLayer(_context).CreateActiveDirectoryUserCredential(userr);
                            //step 5 sign on user

                            return RedirectToAction(nameof(CredentialsController.ManageCredentials), "Credentials", new { actiontype = "ad" });


                        }
                        catch (Exception e)
                        {
                            //step 18
                            int isUseExists = new BusinessLayer(_context).ValidateUser(Utility.GetUserNameFromEmail(userr.Email), userr.Password);
                            if (isUseExists > 0)
                            {
                                //step 5 sign on as system10 user
                                TempData["UserName"] = userr.Email;
                                SetSessionUserName(userr.Email);
                                return RedirectToAction(nameof(HomeController.Index), "Home", new { debug = "" });
                            }
                            ViewData["ErrorMessage"] = "Please provide valid user name and password";
                        }
                    }
                    else
                    {
                        ViewData["ErrorMessage"] = "No domain exists";
                    }
                    
                }
                else
                {
                    int isUseExists = new BusinessLayer(_context).ValidateUser(Utility.GetUserNameFromEmail(userr.Email), userr.Password);
                    if (isUseExists > 0)
                    {
                        TempData["UserName"] = userr.Email;
                        SetSessionUserName(userr.Email);
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


        [HttpGet]
        public ActionResult EmailConfirmation()
        {
            return View();
        }
        //step 22 and step 22 self registration.

        [HttpPost]
        public ActionResult Registration(Models.RegisterviewModel model)
        {
            try
            {
                //step 23 and step 24 checking in COI table.
                DboCredentialOrganizationInfo user = _context.DboCredentialOrganizationInfo.SingleOrDefault(m => m.Vchr128EMailDomain == Utility.GetUserNameFromEmail(model.Email, true) && m.BAllowEmailAssociation == true && m.BAllowSelfRegistration == true);

                if (user != null)
                {
                    //checking Organizatioanl CredentiID credential table whether the user is enalbled or not.
                    DboCredential dbCre = _context.DboCredential.SingleOrDefault(m => m.BintId == user.BintCredentialId && m.BEnabled == true);
                    if (dbCre != null)
                    {
                        //check if the user already exists in dbcren
                        if (_context.DboCredential.SingleOrDefault(m => m.Vchr32Name == model.UserName) != null)
                        {
                            ViewData["ErrorMessage"] = "User Name already exists ,Please choose other name";
                        }
                        else
                        {
                            //step 25 send validation email.
                            string token = System.Guid.NewGuid().ToString();
                            var url = string.Format("{0}://{1}/{2}{3}", Request.Scheme, Request.Host, "Account/Index/?token=", token);

                            new BusinessLayer(_context).SaveEmailVerification(model.Email, token);
                            new BusinessLayer(_context).CreateNewInactiveUserCredential(model);

                            new AuthMessageSender().SendEmail(model.Email, "subject", "body message <a href=" + url + ">click here</a>");
                            return RedirectToAction("EmailConfirmation", "Account", new { token = token });
                        }

                          
                    }
                    else
                    {
                        ViewData["ErrorMessage"] = "You are not a valid user";
                    }

                }
                else
                {
                    ViewData["ErrorMessage"] = "You are not a valid user";
                }
            }
            catch(Exception ex)
            {
                ViewData["ErrorMessage"] = ex.Message;
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
            string redirectUrl = Url.Action("ExternalLoginCallback", "Account", new { ReturnUrl = returnUrl });
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
            ExternalLoginInfo info = await _signInManager.GetExternalLoginInfoAsync();
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
                string email = info.Principal.FindFirstValue(ClaimTypes.Email);
                DboCredentialAlternate dbAltObj = _context.DboCredentialAlternate.SingleOrDefault(m => m.Vchr64UserName == email.Trim());
                if(dbAltObj != null)
                {
                    DboCredential dbCrObj = _context.DboCredential.SingleOrDefault(m => m.BintId == dbAltObj.BintPrimaryCredentialId && m.BEnabled==true);
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
                ApplicationUser user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                IdentityResult result = await _userManager.CreateAsync(user);
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
            ApplicationUser user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Error");
            }
            var result = await _userManager.ConfirmEmailAsync(user, code);
            return View(result.Succeeded ? "ConfirmEmail" : "Error");
        }


    }
}