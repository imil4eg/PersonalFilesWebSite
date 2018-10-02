using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PersonalFiles.DAL
{
    public class OtherDocmentRepository : IOtherDocumentRepository
    {
        protected readonly string _connectionString;

        public OtherDocmentRepository(string connection)
        {
            _connectionString = connection;
        }

        public void Create(OtherDocument item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OtherDocument> Find(Expression<Func<OtherDocument, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public OtherDocument Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OtherDocument> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(OtherDocument item)
        {
            throw new NotImplementedException();
        }
    }
}
