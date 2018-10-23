using System.Collections.Generic;
using PersonalFiles.DAL;

namespace PersonalFiles.BLL
{
    public sealed class InsuranceService : IInsuranceService
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
        public InsuranceService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets all insurance policies
        /// </summary>
        /// <returns></returns>
        public IEnumerable<InsurancePolicy> GetAllPolicies()
        {
            return this._unitOfWork.Insurances.GetAll();
        }

        /// <summary>
        /// Gets insurance policy with specific id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public InsurancePolicy GetPolicyById(int id)
        {
            return this._unitOfWork.Insurances.Get(id);
        }

        /// <summary>
        /// Creates insurance policy
        /// </summary>
        /// <param name="policy"></param>
        public void CreatePolicy(InsurancePolicy policy)
        {
            this._unitOfWork.Insurances.Create(policy);
        }

        /// <summary>
        /// Deletes insurance policy
        /// </summary>
        /// <param name="id"></param>
        public void DeletePolicy(int id)
        {
            this._unitOfWork.Insurances.Delete(id);
        }

        /// <summary>
        /// Updates insurance policy
        /// </summary>
        /// <param name="policy"></param>
        public void UpdatePolicy(InsurancePolicy policy)
        {
            this._unitOfWork.Insurances.Update(policy);
        } 

        #endregion
    }
}
