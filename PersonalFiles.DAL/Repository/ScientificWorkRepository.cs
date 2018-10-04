using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PersonalFiles.DAL
{
    public class ScientificWorkRepository : IScientificWorkRepository
    {
        protected readonly string connectionString;

        public ScientificWorkRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public ScientificWork Create(ScientificWork item)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ScientificWork> Find(Expression<Func<ScientificWork, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ScientificWork Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ScientificWork> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(ScientificWork item)
        {
            throw new NotImplementedException();
        }
    }
}
