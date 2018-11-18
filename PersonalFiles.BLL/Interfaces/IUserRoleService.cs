using System.Collections.Generic;
using System.Threading.Tasks;
using PersonalFiles.DAL;

namespace PersonalFiles.BLL
{
    public interface IUserRoleService
    {
        Task<IEnumerable<UserRole>> GetUserRolesAsync(int id);

        Task Update(int userId, int roleId);

        void Delete(int userId);
    }
}