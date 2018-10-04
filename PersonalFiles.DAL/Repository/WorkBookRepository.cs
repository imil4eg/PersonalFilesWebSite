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

        public WorkBook Create(WorkBook item)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
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

        public bool Update(WorkBook item)
        {
            throw new NotImplementedException();
        }
    }
}
