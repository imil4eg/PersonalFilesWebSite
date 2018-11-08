using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using PersonalFiles.BLL;
using PersonalFiles.DAL;

namespace PersonalFiles.Controllers
{
    public class UserController : Controller
    {
        #region Private Fields

        /// <summary>
        /// Access to user db
        /// </summary>
        private readonly UserManager<ApplicationUser> _userManager;

        #endregion

        #region Constructor

        public UserController(UserManager<ApplicationUser> userManager)
        {
            this._userManager = userManager;
        }

        #endregion

        #region Methods

        public IActionResult Users()
        {


            return View();
        } 

        #endregion
    }
}