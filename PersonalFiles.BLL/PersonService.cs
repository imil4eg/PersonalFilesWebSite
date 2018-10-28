using PersonalFiles.DAL;
using System.Collections.Generic;
using System.Linq;

namespace PersonalFiles.BLL
{
    /// <summary>
    /// Service for <see cref="Person"/> class
    /// </summary>
    public class PersonService : IPersonService
    {
        #region Fields

        /// <summary>
        /// Access to database
        /// </summary>
        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        public PersonService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets all persons
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Person> GetPersons()
        {
            return this._unitOfWork.Persons.GetAll();
        }

        /// <summary>
        /// Gets person with specific id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Person GetPersonById(int id)
        {
            return this._unitOfWork.Persons.Get(id);
        }

        /// <summary>
        /// Creates person
        /// </summary>
        /// <param name="person"></param>
        public void CreatePerson(Person person)
        {
            this._unitOfWork.Persons.Create(person);
        }

        /// <summary>
        /// Deletes person
        /// </summary>
        /// <param name="id"></param>
        public void DeletePerson(int id)
        {
            this._unitOfWork.Persons.Delete(id);
        }

        /// <summary>
        /// Updates person information
        /// </summary>
        /// <param name="person"></param>
        public void UpdatePerson(Person person)
        {
            this._unitOfWork.Persons.Update(person);
        }

        public IEnumerable<Person> GetPersonsWithPosts()
        {
            var persons = this._unitOfWork.Persons.GetAll();

            foreach(var person in persons)
            {
                var personPositions = this._unitOfWork.PersonsPositions.GetAll()
                    .Where(pp => pp.PersonId == person.Id);
                person.Posts = this._unitOfWork.Positions.GetAll()
                    .Where(p => personPositions.Any(pp => pp.PositionId == p.Id))
                    .Select(p => p.Name);
            }

            return persons;
        }

        public Person GetPersonWithPosts(int id)
        {
            var person = this._unitOfWork.Persons.Get(id);
            var personPositions = this._unitOfWork.PersonsPositions.GetAll()
                    .Where(pp => pp.PersonId == person.Id);
            person.Posts = this._unitOfWork.Positions.GetAll()
                .Where(p => personPositions.Any(pp => pp.PositionId == p.Id))
                .Select(p => p.Name);

            return person;
        }

        #endregion
    }
}
