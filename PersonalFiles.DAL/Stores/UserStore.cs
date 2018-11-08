using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace PersonalFiles.DAL
{
    public class UserStore : IQueryableUserStore<ApplicationUser>,
                                IUserStore<ApplicationUser>,
                                IUserPasswordStore<ApplicationUser>,
                                IUserRoleStore<ApplicationUser>,
                                IUserTwoFactorStore<ApplicationUser>
    {
        private readonly string _connectionString;

        private readonly RoleStore _rolesTable;
        private readonly UserRoleRepository _userRoles;
        private readonly IUserRepository _userRepository;

        public UserStore(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _rolesTable = new RoleStore(configuration);
            _userRoles = new UserRoleRepository(_connectionString);
            _userRepository = new UserRepository(_connectionString);
        }


        public IQueryable<ApplicationUser> Users => Task.Run(() => _userRepository.GetAll()).Result.AsQueryable();

        /// <summary>
        /// Create user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IdentityResult> CreateAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync(cancellationToken);
                    user.Id = await connection.QuerySingleAsync<int>("INSERT INTO [ApplicationUser] ([UserName], [NormalizedUserName], [Email], [PasswordHash], [IsDeleted])" +
                        $"VALUES (@{nameof(ApplicationUser.UserName)}, @{nameof(ApplicationUser.NormalizedUserName)}, @{nameof(ApplicationUser.Email)}," +
                        $" @{nameof(ApplicationUser.PasswordHash)}, @{nameof(ApplicationUser.IsDeleted)});" +
                        $"SELECT CAST (SCOPE_IDENTITY() as int)", user);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return IdentityResult.Success;
        }

        /// <summary>
        /// Return last user (for tests)
        /// </summary>
        /// <returns></returns>
        public ApplicationUser ReturnLastUser()
        {
            using(var con = new SqlConnection(_connectionString))
            {
                con.Open();

                return con.QuerySingleOrDefault<ApplicationUser>($@"SELECT TOP 1 * FROM [ApplicationUser]
                        ORDER BY [Id] DESC");
            }
        }

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IdentityResult> DeleteAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                await con.OpenAsync(cancellationToken);

                await con.ExecuteAsync($@"UPDATE [ApplicationUser] SET [IsDeleted] = @{nameof(ApplicationUser.IsDeleted)}
                                        WHERE [Id] = @{nameof(ApplicationUser.Id)}", user);
            }

            return IdentityResult.Success;
        }

        /// <summary>
        /// Dispose (nothing to dispose)
        /// </summary>
        public void Dispose()
        {
            //throw new System.NotImplementedException();
        }

        /// <summary>
        /// Find user by id
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using(var con = new SqlConnection(_connectionString))
            {
                await con.OpenAsync(cancellationToken);
                return await con.QuerySingleOrDefaultAsync<ApplicationUser>($@"SELECT * FROM [ApplicationUser]
                                    WHERE [Id] = @{nameof(userId)}", new { userId });
            }
        }

        /// <summary>
        /// Find user by name
        /// </summary>
        /// <param name="normalizedUserName"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                await con.OpenAsync(cancellationToken);
                return await con.QuerySingleOrDefaultAsync<ApplicationUser>($@"SELECT * FROM [ApplicationUser]
                                WHERE [NormalizedUserName] = @{nameof(normalizedUserName)}", new { normalizedUserName });
            }
        }

        public Task<string> GetNormalizedUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.NormalizedUserName);
        }

        /// <summary>
        /// Return hash password
        /// </summary>
        /// <param name="user"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<string> GetPasswordHashAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.PasswordHash);
        }

        /// <summary>
        /// Get users id
        /// </summary>
        /// <param name="user"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<string> GetUserIdAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Id.ToString());
        }

        /// <summary>
        /// Get users name
        /// </summary>
        /// <param name="user"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<string> GetUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.UserName);
        }

        /// <summary>
        /// Check if user has password
        /// </summary>
        /// <param name="user"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<bool> HasPasswordAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.PasswordHash != null);
        }

        public Task SetNormalizedUserNameAsync(ApplicationUser user, string normalizedName, CancellationToken cancellationToken)
        {
            user.NormalizedUserName = normalizedName;
            return Task.FromResult(user.NormalizedUserName);
        }

        /// <summary>
        /// Set user password
        /// </summary>
        /// <param name="user"></param>
        /// <param name="passwordHash"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task SetPasswordHashAsync(ApplicationUser user, string passwordHash, CancellationToken cancellationToken)
        {
            user.PasswordHash = passwordHash;
            return Task.FromResult(user.PasswordHash);
        }

        /// <summary>
        /// SEt users name
        /// </summary>
        /// <param name="user"></param>
        /// <param name="userName"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task SetUserNameAsync(ApplicationUser user, string userName, CancellationToken cancellationToken)
        {
            user.UserName = userName;
            return Task.FromResult(user.UserName);
        }

        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IdentityResult> UpdateAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using(var con = new SqlConnection(_connectionString))
            {
                await con.OpenAsync(cancellationToken);
                await con.ExecuteAsync($@"UPDATE [ApplicationUser] SET
                    [UserName] = @{nameof(ApplicationUser.UserName)}, [NormalizedUserName] = @{nameof(ApplicationUser.NormalizedUserName)}, [Email] = @{nameof(ApplicationUser.Email)},
                    [PasswordHash] = @{nameof(ApplicationUser.PasswordHash)}, [PhoneNumber] = @{nameof(ApplicationUser.PhoneNumber)},
                    [IsDeleted] = @{nameof(ApplicationUser.IsDeleted)}
                    WHERE [Id] = @{nameof(ApplicationUser.Id)}", user);
            }

            return IdentityResult.Success;
        }

        /// <summary>
        /// Add role to user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="roleName"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task AddToRoleAsync(ApplicationUser user, string roleName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if(user == null)
            {
                throw new NullReferenceException("user is null");
            }

            if(roleName == null)
            {
                throw new NullReferenceException("role name is null");
            }

            var role = await _rolesTable.FindByNameAsync(roleName, cancellationToken);

            if(role == null)
            {
                return;
            }

            if(await IsInRoleAsync(user, roleName, cancellationToken))
            {
                return;
            }

            _userRoles.Create(new UserRole {
                UserId = user.Id,
                RoleId = role.Id
            });
        }

        public async Task RemoveFromRoleAsync(ApplicationUser user, string roleName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var role = await _rolesTable.FindByNameAsync(roleName, cancellationToken);
            var userRoles = await _userRoles.GetRolesAsync(user);

            if(role != null)
            {
                _userRoles.Delete(userRoles.SingleOrDefault(r => r.RoleId == role.Id).Id);
            }
        }

        public async Task<IList<string>> GetRolesAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            IEnumerable<int> rolesIds = (await _userRoles.GetRolesAsync(user)).Select(ur => ur.RoleId);
            return _rolesTable.GetRolesByIds(rolesIds).Select(r => r.Name).ToList();
        }

        public async Task<bool> IsInRoleAsync(ApplicationUser user, string roleName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var userRoles = await _userRoles.GetRolesAsync(user);
            var role = await _rolesTable.FindByNameAsync(roleName, cancellationToken);

            return userRoles.Any(ur => ur.RoleId == role.Id);
        }

        public Task<IList<ApplicationUser>> GetUsersInRoleAsync(string roleName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task SetTwoFactorEnabledAsync(ApplicationUser user, bool enabled, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetTwoFactorEnabledAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(false);
        }
    }
}
