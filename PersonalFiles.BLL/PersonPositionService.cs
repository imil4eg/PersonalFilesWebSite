using PersonalFiles.DAL;
using System.Collections.Generic;

namespace PersonalFiles.BLL
{
    public class PersonPositionService : IPersonPositionService
    {
        #region Private Fields

        /// <summary>
        /// Access to database
        /// </summary>
        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor with database access parameter
        /// </summary>
        /// <param name="unitOfWork"></param>
        public PersonPositionService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns all existing persons positions
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PersonPosition> GetPersonsPositions()
        {
            return this._unitOfWork.PersonsPositions.GetAll();
        }

        /// <summary>
        /// Returns persons position with specific id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PersonPosition GetPersonPositionById(int id)
        {
            return this._unitOfWork.PersonsPositions.Get(id);
        }

        /// <summary>
        /// Adds a new position to a person
        /// </summary>
        /// <param name="personPosition"></param>
        public void AddPersonPosition(PersonPosition personPosition)
        {
            this._unitOfWork.PersonsPositions.Create(personPosition);
        }

        /// <summary>
        /// Removes a persons position with specific id 
        /// </summary>
        /// <param name="id"></param>
        public void RemovePersonPosition(int id)
        {
            this._unitOfWork.Persons.Delete(id);
        }

        /// <summary>
        /// Updates a persons position
        /// </summary>
        /// <param name="personPosition"></param>
        public void UpdatePersonPosition(PersonPosition personPosition)
        {
            this._unitOfWork.PersonsPositions.Update(personPosition);
        }

        #endregion
    }
}
