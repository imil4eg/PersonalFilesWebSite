using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

using PersonalFiles.BLL;
using PersonalFiles.DAL;
using AutoMapper;
using PersonalFiles.Models;

namespace PersonalFiles.Controllers
{
    public class UserController : Controller
    {
        #region Private Fields

        /// <summary>
        /// Access to user db
        /// </summary>
        private readonly UserManager<ApplicationUser> _userManager;

        /// <summary>
        /// Accces to role db
        /// </summary>
        private readonly RoleManager<ApplicationRole> _roleManager;

        private readonly IUserRoleService _userRoleService;

        /// <summary>
        /// Mapper for objects
        /// </summary>
        private readonly IMapper _mapper;

        #endregion

        #region Constructor

        public UserController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, IUserRoleService userRoleService, IMapper mapper)
        {
            this._userManager = userManager;
            this._roleManager = roleManager;
            this._userRoleService = userRoleService;
            this._mapper = mapper;
        }

        #endregion

        #region Methods

        [HttpGet]
        public async System.Threading.Tasks.Task<IActionResult> Users()
        {
            var users = this._mapper.Map<IEnumerable<ApplicationUser>, IEnumerable<UserViewModel>>(_userManager.Users.ToList());
            var roles = this._roleManager.Roles;

            foreach(var user in users)
            {
                var role = (await this._userRoleService.GetUserRolesAsync(user.Id)).First();
                user.RoleName = roles.FirstOrDefault(r => r.Id == role.RoleId).Name;
            }

            return View(users);
        } 

        [HttpGet]
        public async System.Threading.Tasks.Task<IActionResult> EditUser(int userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());

            var model = new EditUserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
            };

            model.SelectRole = new SelectRoleViewModel();
            model.SelectRole.Roles = this._roleManager.Roles.ToList();
            model.SelectRole.SelectedRoleId = (await this._userRoleService.GetUserRolesAsync(userId)).First().RoleId;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditUser(EditUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            this._userRoleService.Update(model.Id, model.SelectRole.SelectedRoleId);

            return RedirectToAction("Users", "User");
        }

        public IActionResult DeleteUser(int userId)
        {


            return RedirectToAction("Users", "User");
        }

        #endregion
    }
}