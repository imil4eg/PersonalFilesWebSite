using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PersonalFiles.DAL
{
    public class AutobiographyRepository : IAutobiographyRepository
    {
        protected readonly string _connectionString;

        public AutobiographyRepository(string connection)
        {
            _connectionString = connection;
        }

        public void Create(Autobiography item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Autobiography> Find(Expression<Func<Autobiography, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Autobiography Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Autobiography> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Autobiography item)
        {
            throw new NotImplementedException();
        }
    }
}
