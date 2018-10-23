using System.Collections.Generic;
using System.Linq;
using PersonalFiles.DAL;


namespace PersonalFiles.BLL
{
    /// <summary>
    /// Service for <see cref="Education"/> class
    /// </summary>
    public sealed class EducationService : IEducationService
    {
        #region Fields

        /// <summary>
        /// Access to database
        /// </summary>
        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        public EducationService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets all education documents
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Education> GetAll()
        {
            return this._unitOfWork.Educations.GetAll();
        }

        /// <summary>
        /// Gets education with specific id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Education GetEducationById(int id)
        {
            return this._unitOfWork.Educations.Get(id);
        }

        /// <summary>
        /// Creates education
        /// </summary>
        /// <param name="education"></param>
        public void CreateEducation(Education education)
        {
            this._unitOfWork.Educations.Create(education);
        }

        /// <summary>
        /// Deletes education
        /// </summary>
        /// <param name="id"></param>
        public void DeleteEducation(int id)
        {
            this._unitOfWork.Educations.Delete(id);
        }

        /// <summary>
        /// Updates education
        /// </summary>
        /// <param name="education"></param>
        public void UpdateEducation(Education education)
        {
            this._unitOfWork.Educations.Update(education);
        }

        /// <summary>
        /// Gets all persons educations
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        public IEnumerable<Education> GetAllPersonsEducation(int personId)
        {
            return this._unitOfWork.Educations.GetAll().Where(e => e.PersonId == personId);
        }

        #endregion
    }
}
