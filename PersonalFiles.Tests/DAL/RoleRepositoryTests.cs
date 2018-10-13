using Microsoft.Extensions.Configuration;
using Moq;
using PersonalFiles.DAL;
using Xunit;

namespace PersonalFiles.Tests.DAL
{
    public class RoleRepositoryTests
    {
        private const string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=PersonalFiles;Trusted_Connection=true;MultipleActiveResultSets=true";

        public async System.Threading.Tasks.Task CreateNewRoleAsync()
        {
            // Arrange
            var mock = new Mock<IConfiguration>();
            mock.Setup(m => m.GetConnectionString("DefaultConnection")).Returns(_connectionString);
            var repository = new RoleStore(mock.Object);
            var role = new ApplicationRole
            {
                Name = "Test"
            };

            // Act
            var response = await repository.CreateAsync(role, new System.Threading.CancellationToken());

            // Assert
            Assert.True(response.Succeeded);
        }
    }
}
