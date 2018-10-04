using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PersonalFiles.DAL
{
    public class WorkContactRepository : IWorkContactRepository
    {
        protected readonly string connectionString;

        public WorkContactRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public WorkContract Create(WorkContract item)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WorkContract> Find(Expression<Func<WorkContract, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public WorkContract Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WorkContract> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(WorkContract item)
        {
            throw new NotImplementedException();
        }
    }
}
