using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System10.Models;

namespace System10.Controllers
{
    public class CredentialsController : Controller
    {
        private readonly System10Context _context;

        public CredentialsController(System10Context context)
        {

            _context = context;
        }
       

        // GET: Credentials
       
        public ActionResult ManageCredentials(string actiontype = "")
        {
            if (HttpContext.Request.Query["email"].ToString() != string.Empty)
            {
                string email = HttpContext.Request.Query["email"].ToString();
                string username = Utility.GetUserNameFromEmail(email);
                TempData["UserName"] = username;
                LoginViewModel mode1 = new LoginViewModel { Email = email };
                actiontype = "";
                new BusinessLayer(_context).CreateNormalUserCredential(mode1);


            }
            

            var userName= TempData["UserName"].ToString();
            ViewData["userName"] = userName;
            ViewData["action"] = actiontype;
            return View();
        }
        [HttpPost]
        public ActionResult ManageCredentials(MangeCredentialViewModel model)
        {
            var userInfo = _context.DboCredential.SingleOrDefault(m=>m.Vchr32Name==model.UserName);
            if(userInfo != null)
            {
                userInfo.Bin64PasswordHash=  Convert.FromBase64String(model.Password);
                _context.DboCredential.Update(userInfo);
            }
            return View();
        }

    }
}
