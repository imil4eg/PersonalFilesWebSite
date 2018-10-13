using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

using Dapper;
using System;

namespace PersonalFiles.DAL
{
    /// <summary>
    /// Class of roles
    /// </summary>
    public class RoleStore : IRoleStore<ApplicationRole>
    {
        #region private Fileds

        private readonly string _connectionString;

        #endregion        
        
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="configuration"></param>
        public RoleStore(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        #endregion

        #region Methods

        /// <summary>
        /// Creates a new role
        /// </summary>
        /// <param name="role"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IdentityResult> CreateAsync(ApplicationRole role, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            try
            {
                using (var con = new SqlConnection(_connectionString))
                {
                    await con.OpenAsync(cancellationToken);
                    role.Id = await con.QuerySingleAsync<int>("INSERT INTO [ApplicationRole] ([Name])" +
                        $"VALUES (@{nameof(ApplicationRole.Name)}); SELECT CAST (SCOPE_IDENTITY() AS int)", role);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return IdentityResult.Success;
        }

        /// <summary>
        /// Deletes a role
        /// </summary>
        /// <param name="role"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IdentityResult> DeleteAsync(ApplicationRole role, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using (var con = new SqlConnection(_connectionString))
            {
                await con.OpenAsync(cancellationToken);
                await con.ExecuteAsync($"DELETE FROM [ApplicationRole] WHERE [Id] = @{nameof(ApplicationRole.Id)}", role);
            }

            return IdentityResult.Success;
        }

        /// <summary>
        /// Disposes (Nothing to dispose)
        /// </summary>
        public void Dispose()
        {
            
        }

        /// <summary>
        /// Finds a role by id
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<ApplicationRole> FindByIdAsync(string roleId, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using (var con = new SqlConnection(_connectionString))
            {
                await con.OpenAsync(cancellationToken);
                return await con.QuerySingleOrDefaultAsync<ApplicationRole>($@"SELECT * FROM [ApplicationRole]
                        WHERE [Id] = @{nameof(roleId)}", new { roleId });
            }
        }

        /// <summary>
        /// Finds a role by name
        /// </summary>
        /// <param name="normalizedRoleName"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<ApplicationRole> FindByNameAsync(string normalizedRoleName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            try
            {
                using (var con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return await con.QuerySingleOrDefaultAsync<ApplicationRole>($@"SELECT * FROM [ApplicationRole]
                            WHERE [Name] = @{nameof(normalizedRoleName)}", new { normalizedRoleName });
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Gets a normalized name of a role
        /// </summary>
        /// <param name="role"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<string> GetNormalizedRoleNameAsync(ApplicationRole role, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetRoleIdAsync(ApplicationRole role, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetRoleNameAsync(ApplicationRole role, CancellationToken cancellationToken)
        {
            return Task.FromResult(role.Name);
        }

        public Task SetNormalizedRoleNameAsync(ApplicationRole role, string normalizedName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task SetRoleNameAsync(ApplicationRole role, string roleName, CancellationToken cancellationToken)
        {
            role.Name = roleName;
            return Task.FromResult(role.Name);
        }

        public async Task<IdentityResult> UpdateAsync(ApplicationRole role, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using (var con = new SqlConnection(_connectionString))
            {
                await con.OpenAsync(cancellationToken);
                await con.ExecuteAsync($@"UPDATE [ApplicationRole] SET [Name] = @{nameof(ApplicationRole.Name)}", role);
            }

            return IdentityResult.Success;
        }

        #endregion

    }
}
