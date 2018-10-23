using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Dapper;

namespace PersonalFiles.DAL
{
    public class PersonPositionRepository : IPersonPositionRepository
    {
        private readonly string _connectionString;

        public PersonPositionRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public PersonPosition Create(PersonPosition item)
        {
            try
            {
                using (var con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.QuerySingleOrDefault<PersonPosition>($@"INSERT INTO [PersonPosition] ([PersonId], [PositionId])
                            VALUES (@{nameof(PersonPosition.PersonId)}, @{nameof(PersonPosition.PositionId)})", item);
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
                using(var con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    int rowsAffected = con.Execute($@"DELETE FROM [PersonPosition] WHERE [Id] = @{nameof(id)}", new { id });

                    return rowsAffected > 0;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<PersonPosition> Find(Expression<Func<PersonPosition, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public PersonPosition Get(int id)
        {
            try
            {
                using(var con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.QuerySingleOrDefault<PersonPosition>($@"SELECT * FROM [PersonPosition] WHERE [Id] = @{nameof(id)}", new { id });
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<PersonPosition> GetAll()
        {
            try
            {
                using(var con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.Query<PersonPosition>($@"SELECT * FROM [PersonPosition]");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(PersonPosition item)
        {
            try
            {
                using(var con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    int rowAffected = con.Execute($@"UPDATE [PersonPosition]
                                        SET [Position] = @{nameof(PersonPosition.PositionId)}", item);

                    return rowAffected > 0;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
