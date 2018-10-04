using Microsoft.AspNetCore.Identity;
using PersonalFiles.DAL;
using System.Text;
using Xunit;

namespace PersonalFiles.Tests
{
    public class UserRepositoryTests
    {
        private const string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=PersonalFiles;Trusted_Connection=true;MultipleActiveResultSets=true";

        private ApplicationUser User { get; set; }

        public UserRepositoryTests()
        {
            User = new ApplicationUser
            {
                Email = "test@mail.ru",
                IsDeleted = false,
                PasswordHash = Encoding.ASCII.GetBytes("kekman").ToString(),
                PhoneNumber = "88005553535",
                UserName = "testman"
            };
        }

        [Fact]
        public void CreateNewUser()
        {
            // Arrange
            var repository = new UserStore(_connectionString);

            // Act
            var result = repository.CreateAsync(User, new System.Threading.CancellationToken());

            // Assert
            Assert.Equal(IdentityResult.Success, result.Result);
        }
    }
}
