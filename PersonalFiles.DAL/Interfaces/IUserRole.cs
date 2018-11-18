using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalFiles.DAL
{
    public interface IUserRoleRepository : IRepository<UserRole> 
    {
        Task<IEnumerable<UserRole>> GetRolesAsync(int id);
    }
}
