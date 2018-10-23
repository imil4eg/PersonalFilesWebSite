using System.Collections.Generic;
using PersonalFiles.DAL;

namespace PersonalFiles.BLL
{
    public interface IInsuranceService
    {
        void CreatePolicy(InsurancePolicy policy);
        void DeletePolicy(int id);
        IEnumerable<InsurancePolicy> GetAllPolicies();
        InsurancePolicy GetPolicyById(int id);
        void UpdatePolicy(InsurancePolicy policy);
    }
}