using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using System.Linq;

using PersonalFiles.DAL;
using PersonalFiles.Models;
using PersonalFiles.BLL;
using System.Text.RegularExpressions;
using System;

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

        /// <summary>
        /// Acccess to person db
        /// </summary>
        protected IPersonService _personService;

        /// <summary>
        /// The manager for handling roles
        /// </summary>
        protected RoleManager<ApplicationRole> _roleManager;

        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="userManager"></param>
        /// <param name="signInManager"></param>
        public AuthorizationController(IPersonService personService, UserManager<ApplicationUser> userManager,
                                        SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._personService = personService;
            this._roleManager = roleManager;
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
        [Authorize(Roles = "Admin")]
        public IActionResult RegisterUser()
        {
            RegisterViewModel model = new RegisterViewModel();
            model.UserRole = new SelectRoleViewModel();
            model.UserRole.Roles = this._roleManager.Roles.ToList();
            return View(model);
        }

        /// <summary>
        /// Register post method
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async System.Threading.Tasks.Task<IActionResult> RegisterUser(RegisterViewModel model)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasNumber.IsMatch(model.Password)
                || !hasUpperChar.IsMatch(model.Password)
                || !hasSymbols.IsMatch(model.Password)
                || !hasLowerChar.IsMatch(model.Password))
            {
                ModelState.AddModelError("", "Пароль должен содержать: " +
                            "Хотя бы одну букву малого регистра;\n" +
                            "Хотя бы одну букву большого регистра;\n" +
                            "Хотя бы одну цифру;\n" +
                            "Хотя бы один спец. символ;");
                model.UserRole.Roles = this._roleManager.Roles.ToList();
                return View(model);
            }

            if (!ModelState.IsValid)
            {
                model.UserRole.Roles = this._roleManager.Roles.ToList();
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
                await this._userManager.AddToRoleAsync(user, (await this._roleManager.FindByIdAsync(model.UserRole.SelectedRoleId.ToString())).Name);
            }

            return RedirectToAction("Persons", "Person");
        }

        [HttpGet]
        public async System.Threading.Tasks.Task<IActionResult> LogOff()
        {
            await this._signInManager.SignOutAsync();
            return RedirectToAction("Login", "Authorization");
        }

        private static bool ValidatePassword(string password)
        {
            const int MIN_LENGTH = 8;

            if (password == null) throw new ArgumentNullException();

            bool meetsLengthRequirements = password.Length >= MIN_LENGTH;
            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;

            if (meetsLengthRequirements)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpperCaseLetter = true;
                    else if (char.IsLower(c)) hasLowerCaseLetter = true;
                    else if (char.IsDigit(c)) hasDecimalDigit = true;
                }
            }

            bool isValid = meetsLengthRequirements
                        && hasUpperCaseLetter
                        && hasLowerCaseLetter
                        && hasDecimalDigit
                        ;
            return isValid;

        }
    }
}