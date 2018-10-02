using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PersonalFiles.DAL
{
    public class WorkBookRepository : IWorkBookRepository
    {
        protected readonly string connectionString;

        public WorkBookRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Create(WorkBook item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WorkBook> Find(Expression<Func<WorkBook, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public WorkBook Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WorkBook> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(WorkBook item)
        {
            throw new NotImplementedException();
        }
    }
}
