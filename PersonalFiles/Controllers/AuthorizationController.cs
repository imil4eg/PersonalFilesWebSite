using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PersonalFiles.DAL;
using PersonalFiles.Models;

namespace PersonalFiles.Controllers
{
    public class AuthorizationController : Controller
    {
        #region Fields

        /// <summary>
        /// Database access
        /// </summary>
        protected IUnitOfWork _unitOfWork;

        /// <summary>
        /// The manager for handling user creation, deletion, searcing, roles
        /// </summary>
        protected UserManager<ApplicationUser> _userManager;

        /// <summary>
        /// The manager for handling sing in and out for users
        /// </summary>
        protected SignInManager<ApplicationUser> _signInManager;

        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="userManager"></param>
        /// <param name="signInManager"></param>
        public AuthorizationController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this._unitOfWork = unitOfWork;
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async System.Threading.Tasks.Task<IActionResult> LoginAsync(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ApplicationUser user = await _userManager.FindByNameAsync(model.UserName);
            if(user == null)
            {
                ViewBag.errorMessage = "Неверный логин или пароль";
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Неверный логин или пароль");
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Register()
        {
            RegisterViewModel model = new RegisterViewModel();
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async System.Threading.Tasks.Task<IActionResult> RegisterAsync(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByNameAsync(model.Login);
            if(user != null)
            {
                ModelState.AddModelError("", "Подобный логин уже используется");
                return View(model);
            }

            var result = await _userManager.CreateAsync(new ApplicationUser
            {
                Email = model.Email,
                UserName = model.Login,
                PhoneNumber = model.Phone,
                IsDeleted = false
            }, model.Password);

            if (result.Succeeded)
            {
                user = await _userManager.FindByNameAsync(model.Login);
            }

            return null;
        }
    }
}