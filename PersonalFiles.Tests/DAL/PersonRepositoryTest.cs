using PersonalFiles.DAL;
using System.Data.SqlClient;
using System.Text;
using Xunit;

namespace PersonalFiles.Tests
{
    public class PersonRepositoryTest
    {
        private const string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=PersonalFiles;Trusted_Connection=true;MultipleActiveResultSets=true";
        
        private ApplicationUser User { get; set; }

        public PersonRepositoryTest()
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
        public void AddNewPerson()
        {
            // Arrange
            var userRepository = new UserStore(_connectionString);

            var personRepository = new PersonRepository(_connectionString);
            var userResponse = userRepository.CreateAsync(User, new System.Threading.CancellationToken());
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
        public void UpdatePerson()
        {
            // Arrange
            var userRepository = new UserStore(_connectionString);
            var repository = new PersonRepository(_connectionString);

            var userResponse = userRepository.CreateAsync(User, new System.Threading.CancellationToken());
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
