using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Dapper;

namespace PersonalFiles.DAL
{
    public class EducationRepository : IEducationRepository
    {
        protected readonly string _connectionString;

        public EducationRepository(string connection)
        {
            _connectionString = connection;
        }

        public Education Create(Education item)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();

                    return con.QuerySingle<Education>($@"INSET INTO [Education] ([PersonId], [File], [EndDate])
                            VALUES (@{nameof(Education.PersonId)}, @{nameof(Education.File)}, @{nameof(Education.EndDate)}", item);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using(SqlConnection con =new SqlConnection(_connectionString))
                {
                    con.Open();

                    int rowsAffected = con.Execute($@"DELETE FROM [Education] WHERE [PersonId] = @{nameof(id)}", new { id });

                    return rowsAffected > 0;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Education> Find(Expression<Func<Education, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Education Get(int id)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();

                    return con.QueryFirstOrDefault<Education>($@"SELECT * FROM [Education] WHERE [PersonId] = @{nameof(id)}", new { id });
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Education> GetAll()
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();

                    return con.Query<Education>("SELECT * FROM [Education]").AsList();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(Education item)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();

                    int rowsAffected = con.Execute($@"UPDATE [Education]
                                        SET [File] = @{nameof(Education.File)}, [EndDate] = @{nameof(Education.EndDate)}
                                        WHERE [Id] = @{nameof(Education.Id)}", item);

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
