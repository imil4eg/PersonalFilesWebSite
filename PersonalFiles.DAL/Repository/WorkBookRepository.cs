using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Dapper;

namespace PersonalFiles.DAL
{
    public class WorkBookRepository : IWorkBookRepository
    {
        protected readonly string _connectionString;

        public WorkBookRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public WorkBook Create(WorkBook item)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.QuerySingleOrDefault<WorkBook>($@"INSERT INTO [WorkBook] ([PersonId] [Post] [DateOfBeggining])
                            VALUES (@{nameof(WorkBook.PersonId)}, @{nameof(WorkBook.Post)}, @{nameof(WorkBook.DateOfBeggining)})", item);
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
                    int rowsAffected = con.Execute($@"DELETE FROM [WorkBook]
                                        WHERE [PersonId] = @{nameof(id)}", new { id });

                    return rowsAffected > 0;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<WorkBook> Find(Expression<Func<WorkBook, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public WorkBook Get(int id)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.QuerySingleOrDefault<WorkBook>($@"SELECT * FROM [WorkBook]
                                WHERE [PersonId] = @{nameof(id)}", new { id });
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<WorkBook> GetAll()
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.Query<WorkBook>($@"SELECT * FROM [WorkBook]").AsList();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(WorkBook item)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    int rowsAffected = con.Execute($@"UPDATE [WorkBook]
                                        SET [Post] = @{nameof(WorkBook.Post)}, [DateOfBeggining] = @{nameof(WorkBook.DateOfBeggining)}", item);

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
