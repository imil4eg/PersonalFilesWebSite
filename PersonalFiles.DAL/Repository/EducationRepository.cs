using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PersonalFiles.DAL
{
    public class EducationRepository : IEducationRepository
    {
        protected readonly string _connectionString;

        public EducationRepository(string connection)
        {
            _connectionString = connection;
        }

        public void Create(Education item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Education> Find(Expression<Func<Education, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Education Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Education> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Education item)
        {
            throw new NotImplementedException();
        }
    }
}
