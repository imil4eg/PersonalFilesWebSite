using Microsoft.Extensions.Configuration;
using Moq;
using PersonalFiles.DAL;
using Xunit;

namespace PersonalFiles.Tests
{
    public class PersonRepositoryTest
    {
        private const string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=PersonalFiles;Trusted_Connection=true;MultipleActiveResultSets=true";

        [Fact]
        public async System.Threading.Tasks.Task AddNewPersonAsync()
        {
            // Arrange
            var mock = new Mock<IConfiguration>();
            mock.Setup(m => m.GetConnectionString("DefaultConnection")).Returns(_connectionString);
            var userRepository = new UserStore(mock.Object);
            var user = new ApplicationUser
            {
                Email = "test@mail.ru",
                IsDeleted = false,
                PasswordHash = SecurePasswordHasher.Hash("kekman"),
                PhoneNumber = "88005553535",
                UserName = "testman"
            };

            var userResponse = await userRepository.CreateAsync(user, new System.Threading.CancellationToken());
            var personRepository = new PersonRepository(_connectionString);
            var person = new Person
            {
                Id = userRepository.ReturnLastUser().Id,
                LastName = "test",
                FirstName = "test",
                Gender = Gender.Женский,
                MiddleName = "test",
                INN = "123145",
                SNILS = "12345"
            };

            // Act
            var response = personRepository.Create(person);

            // Assert
            Assert.Equal(person, response);
        }

        [Fact]
        public async System.Threading.Tasks.Task UpdatePersonAsync()
        {
            // Arrange
            var mock = new Mock<IConfiguration>();
            mock.Setup(m => m.GetConnectionString("DefaultConnection")).Returns(_connectionString);
            var userRepository = new UserStore(mock.Object);
            var repository = new PersonRepository(_connectionString);
            var user = new ApplicationUser
            {
                Email = "test@mail.ru",
                IsDeleted = false,
                PasswordHash = SecurePasswordHasher.Hash("kekman"),
                PhoneNumber = "88005553535",
                UserName = "testman"
            };

            var userResponse = await userRepository.CreateAsync(user, new System.Threading.CancellationToken());
            var person = new Person
            {
                Id = userRepository.ReturnLastUser().Id,
                LastName = "test",
                FirstName = "test",
                Gender = Gender.Женский,
                MiddleName = "test",
                INN = "123145",
                SNILS = "12345"
            };

            var createPerson = repository.Create(person);

            person.LastName = "Test1";
            person.FirstName = "Test1";


            // Act
            var updatePerson = repository.Update(person);

            // Assert
            Assert.True(updatePerson);
        }
    }
}
