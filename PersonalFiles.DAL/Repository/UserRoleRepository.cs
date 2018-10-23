using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dapper;

namespace PersonalFiles.DAL
{
    internal sealed class UserRoleRepository : IUserRoleRepository
    {
        private readonly string _connectionString;

        public UserRoleRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public UserRole Create(UserRole item)
        {
            try
            {
                using (var con = new SqlConnection(_connectionString))
                {
                    con.Open();

                    return con.QuerySingleOrDefault<UserRole>($@"INSERT INTO [UserRole] ([UserId], [RoleId])
                            VALUES (@{nameof(UserRole.UserId)}, @{nameof(UserRole.RoleId)});
                            SELECT CAST (SCOPE_IDENTITY() as int)", item);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using(var con = new SqlConnection(_connectionString))
                {
                    con.Open();

                    con.Execute($@"DELETE FROM [UserRole] WHERE [Id] = @{nameof(id)}", id);

                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// no need to implement that
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<UserRole> Find(Expression<Func<UserRole, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// No need to implement that
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserRole Get(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// No need to impement that
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserRole> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get roles of user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<IEnumerable<UserRole>> GetRolesAsync(ApplicationUser user)
        {
            using(var con = new SqlConnection(_connectionString))
            {
                con.Open();

                return await con.QueryAsync<UserRole>($@"SELECT * FROM [UserRole]
                                                        WHERE UserId = @{nameof(UserRole.Id)}", new { user.Id });
            }
        }

        /// <summary>
        /// No need to implement that
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Update(UserRole item)
        {
            try
            {
                using(var con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    int rowAffected = con.Execute($@"UPDATE [UserRole] SET [RoleId] = @{nameof(UserRole.RoleId)}
                                        WHERE [Id] = @{nameof(UserRole.Id)}", item);

                    return rowAffected > 0;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
