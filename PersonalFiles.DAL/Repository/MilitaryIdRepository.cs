using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PersonalFiles.DAL
{
    public class MilitaryIdRepository : IMilitaryIdRepository
    {
        protected readonly string _connectionString;

        public MilitaryIdRepository(string connection)
        {
            _connectionString = connection;
        }

        public void Create(MilitaryID item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MilitaryID> Find(Expression<Func<MilitaryID, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public MilitaryID Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MilitaryID> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(MilitaryID item)
        {
            throw new NotImplementedException();
        }
    }
}
