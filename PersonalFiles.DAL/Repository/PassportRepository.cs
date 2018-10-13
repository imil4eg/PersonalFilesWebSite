using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Dapper;

namespace PersonalFiles.DAL
{
    public class PassportRepository : IPassportRepository
    {
        protected readonly string _connectionString;

        public PassportRepository(string connection)
        {
            _connectionString = connection;
        }

        public Passport Create(Passport item)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.QuerySingleOrDefault<Passport>($@"INSET INTO [Passport] ([PersonId] [Number] [Series] [GivenBy] [DateOfGive] [Address])
                                VALUES (@{nameof(Passport.PersonId)}, @{nameof(Passport.Number)}, @{nameof(Passport.Series)}, @{nameof(Passport.GivenBy)},
                                @{nameof(Passport.DateOfGive)}, @{nameof(Passport.Address)}", item);
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
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    int affectedRows = con.Execute($@"DELETE FROM [Passport]
                                        WHERE [PersonId] = @{nameof(id)}", new { id });

                    return affectedRows > 0;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Passport> Find(Expression<Func<Passport, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Passport Get(int id)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.QuerySingleOrDefault<Passport>($@"SELECT * FROM [Passport]
                                WHERE [PersonId] = @{nameof(id)}", new { id });
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Passport> GetAll()
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.Query<Passport>($@"SELECT * FROM [Passport]");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(Passport item)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    int rowsAffected = con.Execute($@"UPDATE [Passport]
                                        SET [Number] = @{nameof(Passport.Number)}, [Series] = @{nameof(Passport.Series)}, [GivenBy] = @{nameof(Passport.GivenBy)},
                                        [DateOfGive] = @{nameof(Passport.DateOfGive)}, [Address] = @{nameof(Passport.Address)}", item);

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
