using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public Autobiography Create(Autobiography item)
        {
            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                if(con.State == ConnectionState.Open)
                {
                    using(SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO Autobiography";
                    }
                }
            }

            return item;
        }

        public int Delete(int id)
        {
            return id;
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

        public bool Update(Autobiography item)
        {
            throw new NotImplementedException();
        }
    }
}
