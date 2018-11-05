using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PersonalFiles.DAL;
using PersonalFiles.Models;
using PersonalFiles.BLL;

namespace PersonalFiles.Controllers
{
    public class AuthorizationController : Controller
    {
        #region Fields

        /// <summary>
        /// The manager for handling user creation, deletion, searcing, roles
        /// </summary>
        protected UserManager<ApplicationUser> _userManager;

        /// <summary>
        /// The manager for handling sing in and out for users
        /// </summary>
        protected SignInManager<ApplicationUser> _signInManager;

        protected IPersonService _personService;

        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="userManager"></param>
        /// <param name="signInManager"></param>
        public AuthorizationController(IPersonService personService, UserManager<ApplicationUser> userManager,
                                        SignInManager<ApplicationUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._personService = personService;
        }

        /// <summary>
        /// Login get method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Persons", "Person");
            }

            LoginViewModel model = new LoginViewModel();
            return View(model);
        }

        /// <summary>
        /// Login post method
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async System.Threading.Tasks.Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ApplicationUser user = await _userManager.FindByNameAsync(model.UserName);
            //var res = _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Persons", "Person");
            }
            else
            {
                ModelState.AddModelError("", "Неверный логин или пароль");
                return View(model);
            }
        }

        /// <summary>
        /// Register get method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Register()
        {
            RegisterViewModel model = new RegisterViewModel();
            return View(model);
        }

        /// <summary>
        /// Register post method
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async System.Threading.Tasks.Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByNameAsync(model.UserName);
            if(user != null)
            {
                ModelState.AddModelError("", "Подобный логин уже используется");
                return View(model);
            }

            var result = await _userManager.CreateAsync(new ApplicationUser
            {
                Email = model.Email,
                UserName = model.UserName,
                PhoneNumber = model.Phone,
                IsDeleted = false
            }, model.Password);

            if (result.Succeeded)
            {
                user = await _userManager.FindByNameAsync(model.UserName);
            }

            return null;
        }
    }
}