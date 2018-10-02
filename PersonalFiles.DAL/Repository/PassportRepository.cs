using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PersonalFiles.DAL
{
    public class PassportRepository : IPassportRepository
    {
        protected readonly string _connectionString;

        public PassportRepository(string connection)
        {
            _connectionString = connection;
        }

        public void Create(Passport item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Passport> Find(Expression<Func<Passport, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Passport Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Passport> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Passport item)
        {
            throw new NotImplementedException();
        }
    }
}
