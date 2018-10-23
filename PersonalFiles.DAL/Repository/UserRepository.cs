using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Dapper;

namespace PersonalFiles.DAL
{
    public class UserRepository : IUserRepository
    {
        protected readonly string _connectionString;

        public UserRepository(string connectionStirng)
        {
            _connectionString = connectionStirng;
        }

        public ApplicationUser Create(ApplicationUser item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationUser> Find(Expression<Func<ApplicationUser, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();

                    return con.Query<ApplicationUser>("SELECT * FROM [ApplicationUser]");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(ApplicationUser item)
        {
            throw new NotImplementedException();
        }
    }
}
