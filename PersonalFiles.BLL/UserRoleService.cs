
using PersonalFiles.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFiles.BLL
{
    public sealed class UserRoleService : IUserRoleService
    {
        #region Private Fields

        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Constructor

        public UserRoleService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        #endregion

        #region Methods

        public async Task<IEnumerable<UserRole>> GetUserRolesAsync(int id)
        {
            return await this._unitOfWork.UserRole.GetRolesAsync(id);
        }

        public async Task Update(int userId, int roleId)
        {
            var role = (await this._unitOfWork.UserRole.GetRolesAsync(userId)).First();
            role.RoleId = roleId;
            this._unitOfWork.UserRole.Update(role);
        }

        public void Delete(int userId)
        {
            
        }

        #endregion

    }
}
