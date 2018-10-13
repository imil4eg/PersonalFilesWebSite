using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Moq;
using PersonalFiles.DAL;
using Xunit;

namespace PersonalFiles.Tests
{
    public class UserRepositoryTests
    {
        private const string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=PersonalFiles;Trusted_Connection=true;MultipleActiveResultSets=true";

        [Fact]
        public void CreateNewUser()
        {
            // Arrange
            var fakeConfig = Isolate.Fake.Instance<IConfiguration>();
            Isolate.WhenCalled(() => fakeConfig.GetConnectionString("DefaultConnection")).WillReturn(_connectionString);
            var repository = new UserStore(fakeConfig);
            var user = new ApplicationUser
            {
                Email = "test@mail.ru",
                IsDeleted = false,
                PasswordHash = SecurePasswordHasher.Hash("kekman"),
                PhoneNumber = "88005553535",
                UserName = "testman"
            };

            // Act
            var result = repository.CreateAsync(user, new System.Threading.CancellationToken());

            // Assert
            Assert.Equal(IdentityResult.Success, result.Result);
        }

        [Fact]
        public void ReturnLastUser()
        {
            // Arrange
            var mock = new Mock<IConfiguration>();
            mock.Setup(m => m.GetConnectionString("DefaultConnection")).Returns(_connectionString);
            var repository = new UserStore(mock.Object);

            // Act
            var result = repository.ReturnLastUser();

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void UpdateUser()
        {
            // Arrange
            var fakeConfig = Isolate.Fake.Instance<IConfiguration>();
            Isolate.WhenCalled(() => fakeConfig.GetConnectionString("DefaultConnection")).WillReturn(_connectionString);
            var repository = new UserStore(fakeConfig);
            var user = new ApplicationUser
            {
                Id = 1,
                Email = "testchanged@mail.ru",
                IsDeleted = false,
                PasswordHash = SecurePasswordHasher.Hash("kekman"),
                PhoneNumber = "88005553535",
                UserName = "testman"
            };

            // Act
            var result = repository.UpdateAsync(user, new System.Threading.CancellationToken());

            // Assert
            Assert.Equal(IdentityResult.Success, result.Result);
        }

        [Fact]
        public async System.Threading.Tasks.Task FindByIdUserAsync()
        {
            // Arrange
            var mock = new Mock<IConfiguration>();
            mock.Setup(m => m.GetConnectionString("DefaultConnection")).Returns(_connectionString);
            var repository = new UserStore(mock.Object);

            // Act
            var result = await repository.FindByIdAsync("1", new System.Threading.CancellationToken());

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async System.Threading.Tasks.Task DeleteUserAsync()
        {
            // Arrange
            var mock = new Mock<IConfiguration>();
            mock.Setup(m => m.GetConnectionString("DefaultConnection")).Returns(_connectionString);
            var repository = new UserStore(mock.Object);
            var user = new ApplicationUser
            {

                Email = "testchanged@mail.ru",
                IsDeleted = false,
                PasswordHash = SecurePasswordHasher.Hash("kekman"),
                PhoneNumber = "88005553535",
                UserName = "testman"
            };
            var createResponse = await repository.CreateAsync(user, new System.Threading.CancellationToken());
            var createdUser = repository.ReturnLastUser();

            // Act
            var result = await repository.DeleteAsync(createdUser, new System.Threading.CancellationToken());

            // Assert
            Assert.True(result.Succeeded);
        }
    }
}
