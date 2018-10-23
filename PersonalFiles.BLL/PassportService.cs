using System.Collections.Generic;
using PersonalFiles.DAL;

namespace PersonalFiles.BLL
{
    /// <summary>
    /// Service for <see cref="Passport"/> class
    /// </summary>
    public sealed class PassportService : IPassportService
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
        public PassportService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get all passports
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Passport> GetAll()
        {
            return this._unitOfWork.Passports.GetAll();
        }

        /// <summary>
        /// Get passport by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Passport GetPassportById(int id)
        {
            return this._unitOfWork.Passports.Get(id);
        }

        /// <summary>
        /// Create passport
        /// </summary>
        /// <param name="passport"></param>
        public void CreatePassport(Passport passport)
        {
            this._unitOfWork.Passports.Create(passport);
        }

        /// <summary>
        /// Deletes passport
        /// </summary>
        /// <param name="id"></param>
        public void DeletePassport(int id)
        {
            this._unitOfWork.Passports.Delete(id);
        }

        /// <summary>
        /// Updates passport information
        /// </summary>
        /// <param name="passport"></param>
        public void UpdatePassport(Passport passport)
        {
            this._unitOfWork.Passports.Update(passport);
        } 

        #endregion
    }
}
