using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PersonalFiles.DAL
{
    public class UserStore : IUserStore<ApplicationUser>, IUserPasswordStore<ApplicationUser>
    {
        private readonly string _connectionString;

        public UserStore(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IdentityResult> CreateAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            //  cancellationToken.ThrowIfCancellationRequested();

            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = $@"INSERT INTO [ApplicationUser] ([UserName], [Email], [PasswordHash], [IsDeleted]) " +
                        $"VALUES (@param1, @param2, @param3, " +
                        $"@param4)";

                    cmd.Parameters.Add("@param1", SqlDbType.NVarChar).Value = user.UserName;
                    cmd.Parameters.Add("@param2", SqlDbType.NVarChar).Value = user.Email;
                    cmd.Parameters.Add("@param3", SqlDbType.NVarChar).Value = Encoding.ASCII.GetBytes(user.PasswordHash).ToString();
                    cmd.Parameters.Add("@param4", SqlDbType.Bit).Value = user.IsDeleted;

                    cmd.ExecuteNonQuery();
                }
            }

            return IdentityResult.Success;
        }

        public ApplicationUser ReturnLastUser()
        {
             List<ApplicationUser> users = new List<ApplicationUser>();

            using(var con = new SqlConnection(_connectionString))
            {
                con.Open();
                
                using(var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM [ApplicationUser]";
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())

                        users.Add(new ApplicationUser
                        {
                            Id = reader.GetValue<int>(0),
                            UserName = reader.GetValue<string>(1),
                            Email = reader.GetValue<string>(2),
                            PasswordHash = reader.GetValue<string>(3),
                            PhoneNumber = reader.GetValue<string>(4),
                            IsDeleted = reader.GetValue<bool>(5)
                        });
                }
            }

            return users[users.Count - 1];
        }

        public async Task<IdentityResult> DeleteAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = $"UPDATE [ApplicationUser] SET IsDeleted = 1";
                    cmd.ExecuteNonQuery();
                }
            }

            return IdentityResult.Success;
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public async Task<ApplicationUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            ApplicationUser user;

            using(var con = new SqlConnection(_connectionString))
            {
                con.Open();

                using(var cmd = new SqlCommand())
                {
                    cmd.CommandText = $@"SELECT * FROM [ApplicationUser] WHERE [Id] = {userId}";
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    user = new ApplicationUser
                    {
                        Id = reader.GetValue<int>(0),
                        UserName = reader.GetValue<string>(1),
                        Email = reader.GetValue<string>(2),
                        PasswordHash = reader.GetValue<string>(3),
                        PhoneNumber = reader.GetValue<string>(4),
                        IsDeleted = reader.GetValue<bool>(5)
                    };
                }
            }

            return user;
        }

        public Task<ApplicationUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetNormalizedUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetPasswordHashAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.PasswordHash);
        }

        public Task<string> GetUserIdAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> HasPasswordAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.PasswordHash != null);
        }

        public Task SetNormalizedUserNameAsync(ApplicationUser user, string normalizedName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task SetPasswordHashAsync(ApplicationUser user, string passwordHash, CancellationToken cancellationToken)
        {
            user.PasswordHash = passwordHash;
            return Task.FromResult(user.PasswordHash);
        }

        public Task SetUserNameAsync(ApplicationUser user, string userName, CancellationToken cancellationToken)
        {
            user.UserName = userName;
            return Task.FromResult(user.UserName);
        }

        public async Task<IdentityResult> UpdateAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            using(var con = new SqlConnection(_connectionString))
            {
                con.Open();

                using(var cmd = new SqlCommand())
                {
                    cmd.CommandText = string.Format("UPDATE [ApplicationUser] SET" +
                        $"[UserName] = {user.UserName}" +
                        $"[Email] = { user.Email}" +
                        $"[PasswordHash] = {user.PasswordHash}" +
                        $"[PhoneNumber] = {user.PhoneNumber}" +
                        $"[IsDeleted] = {user.IsDeleted}");

                    cmd.ExecuteNonQuery();
                }
            }

            return IdentityResult.Success;
        }
    }
}
