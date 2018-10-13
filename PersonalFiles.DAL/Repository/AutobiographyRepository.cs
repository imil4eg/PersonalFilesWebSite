using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using Dapper;

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
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.QuerySingle<Autobiography>($@"INSERT INTO [Autobiography] ([PersonId] [File])
                            VALUES (@{nameof(Autobiography.PersonId)}, @{nameof(Autobiography.File)}", item);
                    
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Delete(int id)
        {
            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                int rowAffected = con.Execute($@"DELETE FROM [Autobiography] WHERE [PersonId] = @{nameof(id)}", new { id });

                return rowAffected > 0;
            }
        }

        public IEnumerable<Autobiography> Find(Expression<Func<Autobiography, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Autobiography Get(int id)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();

                    return con.QuerySingleOrDefault<Autobiography>($@"SELECT * FROM [Autobiography] WHERE [PersonId] = @{nameof(id)}", new { id });
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Autobiography> GetAll()
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();

                    return con.Query<Autobiography>($@"SELECT * FROM [Autobiography]").ToList();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(Autobiography item)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();

                    int rowsAffected = con.Execute($@"UPDATE [Autobiography] SET [File] = @{nameof(Autobiography.File)}", item);

                    return rowsAffected > 0;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
