using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PersonalFiles.DAL
{
    public class InsuranceRepository : IInsurancePolicyRepository
    {
        protected readonly string _connectionString;

        public InsuranceRepository(string connection)
        {
            _connectionString = connection;
        }

        public InsurancePolicy Create(InsurancePolicy item)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InsurancePolicy> Find(Expression<Func<InsurancePolicy, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public InsurancePolicy Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InsurancePolicy> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(InsurancePolicy item)
        {
            throw new NotImplementedException();
        }
    }
}
