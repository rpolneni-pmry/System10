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
    public class BaseController : Controller
    {
       

        //public AccountController(System10Context context)
        //{

        //    _context = context;

        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <ex
        protected void SetSessionUserName(string name)
        {
            HttpContext.Session.SetString("lUserName", name);
        }
        protected string GettSessionUserName()
        {
            return HttpContext.Session.GetString("lUserName");
        }







    }
}