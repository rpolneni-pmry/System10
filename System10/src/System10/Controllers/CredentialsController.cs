using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System10.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System10.Services;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace System10.Controllers
{
    public class CredentialsController : BaseController
    {
       

       
        private readonly System10Context _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ISmsSender _smsSender;
        private readonly ILogger _logger;

        public CredentialsController(
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

        // GET: Credentials

         public ActionResult ResetPassword()
        {
            if(GettSessionUserName() == null || GettSessionUserName() == string.Empty)
            {
                return RedirectToAction(nameof(AccountController.Login), "Account", new { debug = "" });
            }
            return View();
        }
        [HttpPost]
        public ActionResult ResetPassword(MangeCredentialViewModel model)
        {
            //checking the new passowr and confirm password
            if(model.NewPassword.Trim() == model.ConfirmPassword.Trim())
            {
                byte[] password = System.Text.Encoding.Unicode.GetBytes(model.Password);
                //checking tyhe old password
                DboCredential dbCr = _context.DboCredential.SingleOrDefault(m => m.Vchr32Name == GettSessionUserName() && m.Bin64PasswordHash == password);
                if (dbCr != null)
                {
                    password = System.Text.Encoding.Unicode.GetBytes(model.NewPassword.Trim());
                    dbCr.Bin64PasswordHash = password;
                    _context.DboCredential.Update(dbCr);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(HomeController.Index), "Home", new { debug = "" });
                }
                else
                {
                    ViewData["ErrorMessage"] = "Please enter correct apassword";
                }
            }
            else
            {
                ViewData["ErrorMessage"] = "NewPassword and COnfirm Password must be same";
            }
           
            return View();
        }
        public ActionResult ManageCredentials(string actiontype = "")
        {
            if (GettSessionUserName() == null || GettSessionUserName() == string.Empty)
            {
                return RedirectToAction(nameof(AccountController.Login), "Account", new { debug = "" });
            }
            MangeCredentialViewModel model = new MangeCredentialViewModel();
            //if (HttpContext.Request.Query["email"].ToString() != string.Empty)
            //{
            //    string email = HttpContext.Request.Query["email"].ToString();
            //    string username = Utility.GetUserNameFromEmail(email);
            //    string domainName = Utility.GetUserNameFromEmail(email,true);
            //    TempData["UserName"] = username;
            //    LoginViewModel mode1 = new LoginViewModel { Email = email };
            //    actiontype = "";
            //    var user = _context.DboCredentialOrganizationInfo.SingleOrDefault(m => m.Vchr128EMailDomain == domainName && m.BAllowEmailAssociation == true && m.BAllowSelfRegistration == true);

            //    new BusinessLayer(_context).CreateNormalUserCredential(mode1,user.BintCreatorCredentialId);


            //}

            if (GettSessionUserName() != null)
            {
                DboCredential dboCr = _context.DboCredential.SingleOrDefault(m => m.Vchr32Name == TempData["UserName"].ToString());
                if(dboCr != null)
                {
                    List<DboCredentialAlternate> dboCrAl = _context.DboCredentialAlternate.Where(m=>m.BintPrimaryCredentialId ==dboCr.BintId).ToList();
                    model.dboAlternAte = dboCrAl;
                    model.localization = _context.LkpLocalization.ToList();
                  
                    //var f = df.BintConcept;
                }
            }


            string userName = GettSessionUserName();// TempData["UserName"].ToString();
            ViewData["userName"] = userName;
            ViewData["action"] = actiontype;
            return View(model);
        }
        //[HttpPost]
        //public ActionResult ManageCredentials(MangeCredentialViewModel model)
        //{
        //    DboCredential userInfo = _context.DboCredential.SingleOrDefault(m=>m.Vchr32Name==model.UserName);
        //    if(userInfo != null)
        //    {
        //       byte[] password= System.Text.Encoding.Unicode.GetBytes(model.Password);
        //        userInfo.Bin64PasswordHash= password;
        //        _context.DboCredential.Update(userInfo);
        //        _context.SaveChanges();
        //        return RedirectToAction(nameof(HomeController.Index), "Home", new { debug = "" });
        //    }
        //    else
        //    {
        //        ViewData["ErroMessage"] = "Something is wrong";
        //    }
        //    return View();
        //}

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult ExternalLogin(string provider, string returnUrl = null)
        {
            string[] provInfo = provider.Split('-');
            if(provInfo.Length > 1)
            {
                //This method will hit when we user wants to delete the exisitng account
                provInfo.Last();
                DboCredential dbCr = _context.DboCredential.SingleOrDefault(m=>m.Vchr32Name==GettSessionUserName());
                if(dbCr != null)
                {
                    List<DboCredentialAlternate> dlist = _context.DboCredentialAlternate.Where(m => m.BintPrimaryCredentialId == dbCr.BintId && m.ICredentialTypeId == Convert.ToInt32(provInfo.Last())).ToList();
                    if(dlist.Count() > 1)
                    {
                        DboCredentialAlternate dbCrAld = _context.DboCredentialAlternate.FirstOrDefault(m => m.BintPrimaryCredentialId == dbCr.BintId && m.ICredentialTypeId == Convert.ToInt32(provInfo.Last()) && !m.DtInactivated.HasValue);
                        dbCrAld.DtInactivated = DateTime.Now;
                        _context.DboCredentialAlternate.Update(dbCrAld);
                        _context.SaveChanges();

                    }
                    else
                    {
                        DboCredentialAlternate dbCrAl = _context.DboCredentialAlternate.SingleOrDefault(m => m.BintPrimaryCredentialId == dbCr.BintId && m.ICredentialTypeId == Convert.ToInt32(provInfo.Last()));
                        dbCrAl.DtInactivated = DateTime.Now;
                        _context.DboCredentialAlternate.Update(dbCrAl);
                        _context.SaveChanges();
                    }
                    
                    return RedirectToAction(nameof(HomeController.Index), "Home", new { debug = "d" });

                }
                else
                {
                    ViewData["ErrorMessage"] = "Seems there is an error";
                    return View();
                }
                
            }
            else
            {
                //This method will hit when we user wants to add any external account
                string redirectUrl = Url.Action("ExternalLoginCallback", "Credentials", new { ReturnUrl = returnUrl });
                var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
                return Challenge(properties, provider);
            }
            // Request a redirect to the external login provider.
           
        }
        private void SetSessionUserName(string name)
        {
            HttpContext.Session.SetString("lUserName", name);
        }
        private string GettSessionUserName()
        {
            return HttpContext.Session.GetString("lUserName");
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
                return View(nameof(ManageCredentials));
            }
            ExternalLoginInfo info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return RedirectToAction(nameof(ManageCredentials));
            }          
            else
            {
                // If the user does not have an account, then ask the user to create an account.
                ViewData["ReturnUrl"] = returnUrl;
                ViewData["LoginProvider"] = info.LoginProvider;
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);
                string username = GettSessionUserName();
                DboCredential dbCrObj = _context.DboCredential.SingleOrDefault(m => m.Vchr32Name == username);
                if (dbCrObj != null)
                {
                    new BusinessLayer(_context).CreateOAuthUserCredential(email, dbCrObj.BintId, info.LoginProvider);
                }
                //var dbAltObj = _context.DboCredentialAlternate.SingleOrDefault(m => m.Vchr64UserName == email.Trim());
                //if (dbAltObj != null)
                //{
                //    var dbCrObj = _context.DboCredential.SingleOrDefault(m => m.BintId == dbAltObj.BintPrimaryCredentialId && m.BEnabled == true);
                //    if (dbCrObj != null)
                //    {
                //        SetSessionUserName(dbCrObj.Vchr32Name);
                //        return RedirectToAction(nameof(HomeController.Index), "Home", new { debug = "" });

                //    }
                //}
                //else
                //{
                //    string username = GettSessionUserName();
                //    var dbCrObj = _context.DboCredential.SingleOrDefault(m => m.Vchr32Name == username);
                //    if(dbCrObj != null)
                //    {
                //        new BusinessLayer(_context).CreateOAuthUserCredential(username, dbCrObj.BintId);
                //    }


                //}

                return RedirectToAction(nameof(HomeController.Index), "Home", new { debug = "d" });
            }
        }

    }
}
