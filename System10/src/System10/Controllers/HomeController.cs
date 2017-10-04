using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System10.Models;
using System.Text;
using System.Security.Principal;
using Novell.Directory.Ldap;
using Microsoft.AspNetCore.Http.Features;
using System10.Services;

namespace System10.Controllers
{
    public class HomeController : Controller
    {

        private readonly System10Context _context;
        public HomeController(System10Context context)
        {
            
            _context = context;
        }
        // same network authentication using windows identity
        public IActionResult Index()
        {
            return View();
                
        }
      
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }


        //public IActionResult Login()
        //{
        //    return View();
        //}
        //private string GetUserNameFromEmail(string email)
        //{
        //    String[] userData = email.Split(new[] { '@' });
        //  //  String[] userData = email.Split(new[] { '\\' });
        //    String username = userData[0];
        //    return username;
        //}
        //[HttpPost]
        ////Active directory users login
        //public IActionResult Login(Models.LoginViewModel userr,string ReturnUrl)
        //{
        //    //Authenticating using Active Directory
        //    using (var cn = new LdapConnection())
        //    {
        //        // connect
        //        //   cn.Connect("<<hostname>>", 389);
        //        // bind with an username and password
        //        // this how you can verify the password of an user

        //        cn.SecureSocketLayer = true;
        //        cn.Connect("hqmsdcw01.pomeroy.msft", 636);
        //        //    string Username = WindowsIdentity.GetCurrent().Name.ToString();

        //        //var CurLoggedUser = User.Identity.IsAuthenticated;

        //        //   string domain = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainNamel;



        //        try
        //        {
        //            cn.Bind(userr.Email, userr.Password);
        //            //checking in Credential Alternate Table
        //            DboCredentialAlternate userCred = _context.DboCredentialAlternate.SingleOrDefault(m => m.Vchr64UserName == userr.Email);
        //            if (userCred != null)
        //            {
        //                TempData["UserName"] = userr.Email;
        //                //checking in Credential table
        //                var userObject = _context.DboCredential.SingleOrDefault(m => m.BintId == userCred.BintPrimaryCredentialId && m.BEnabled == true);

        //                if (userObject != null)
        //                {
        //                    return RedirectToAction(nameof(CredentialsController.ManageCredentials), "Credentials", new { actiontype = "ad" });
        //                }
                       

        //            }
                    
                   
        //            //if (IsValid(userr.Vchr32Name, userr.Vchr256ModifiedContext) >= 1)
        //            //{
        //            //    return RedirectToAction("Index", "Home");
        //            //}
        //            //else
        //            //{
        //            //Adding record in Credential and Credential Alternate Table
        //            new BusinessLayer().CreateActiveDirectoryUserCredential(userr);

        //            return RedirectToAction(nameof(CredentialsController.ManageCredentials), "Credentials", new { actiontype = "ad" });



        //            // }

        //        }
        //        catch (Exception e)
        //        {
        //            ModelState.AddModelError(string.Empty, e.Message);
        //            ModelState.AddModelError("", "Login details are wrong.");
        //        }
        //    }

           
        //    return View();
        //}


        [NonAction]
        private int IsValid(string Vchr32Name, string Password)
        {
            
            string sPassword = Password != null ? Password : "";
            byte[] bytes = Convert.FromBase64String(sPassword);

            //var user = from c in _context.DboCredential where c.Vchr32Name == Vchr32Name && c.Bin64PasswordHash == bytes select new { c.BintId };
            var user = from c in _context.DboCredential where c.Vchr32Name == Vchr32Name  select new { c.BintId };
            int icount = user !=null ?user.Count():0;
            return icount;
        }
        //public ActionResult Registration()
        //{
        //    return View();
        //}
        //[HttpGet]
        //public ActionResult Registration()
        //{
        //    return View();
        //}

        // [HttpPost]
        //public ActionResult Registration(Models.RegisterviewModel model)
        //{
        //    var url= string.Format("{0}://{1}/{2}{3}", Request.Scheme, Request.Host, "Credentials/ManageCredentials/?email=",model.Email);
        //    var user = _context.DboCredentialOrganizationInfo.SingleOrDefault(m=>m.Vchr128EMailDomain==Utility.GetUserNameFromEmail(model.Email,true) && m.BAllowEmailAssociation == true && m.BAllowSelfRegistration == true);
            
        //    if (user != null)
        //    {
        //        new AuthMessageSender().SendEmail(model.Email,"subject","body message <a href="+ url+">click here</a>");
        //    }
        //    else
        //    {
        //        ViewData["ErrorMessage"] = "You are not a valid user";
        //    }


        //    return View();
        //}
       
    }
}
