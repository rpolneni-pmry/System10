using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System10.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System10.Services;
using System.Security.Claims;

namespace System10.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        private readonly IEmailSender _emailSender;
        private readonly ISmsSender _smsSender;
        private readonly ILogger _logger;



        public HomeController(
    UserManager<ApplicationUser> userManager,
    SignInManager<ApplicationUser> signInManager,
    IEmailSender emailSender,
    ISmsSender smsSender,
    ILoggerFactory loggerFactory)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _smsSender = smsSender;
            _logger = loggerFactory.CreateLogger<AccountController>();
        }


        public async Task<IActionResult> Index()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                WindowsIdentity loggedInUser = WindowsIdentity.GetCurrent();
                if (loggedInUser.User.AccountDomainSid.Value == "S-1-5-21-2610387755-854405893-2624003543")
                {
                    var winLoginNameTrim = loggedInUser.Name.Split('\\');
                    var winLoginName = winLoginNameTrim.Last();
                    var user = new ApplicationUser { UserName = winLoginName, Email = winLoginName };
                    var userC = await _userManager.CreateAsync(user);
                    if (userC.Succeeded)
                    {
                        var results = await _userManager.AddLoginAsync(user, new UserLoginInfo("WindowsUser", "", "disply"));
                    }
                    await _signInManager.SignInAsync(user, isPersistent: false);
                }
            }
          //  return View();

            return RedirectToAction(nameof(HomeController.About), "Home");
        }


        [Authorize]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        [Authorize]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
