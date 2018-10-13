using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Dapper;

namespace PersonalFiles.DAL
{
    public class WorkContactRepository : IWorkContactRepository
    {
        protected readonly string _connectionString;

        public WorkContactRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public WorkContract Create(WorkContract item)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.QuerySingleOrDefault<WorkContract>($@"INSERT INTO [WorkContract] ([PersonId] [File] [Date])
                            VALUES (@{nameof(WorkContract.PersonId)}, @{nameof(WorkContract.File)}, @{nameof(WorkContract.Date)})", item);
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
                    int rowsAffected = con.Execute($@"DELETE FROM [WorkContract]
                                        WHERE [PersonId] = @{nameof(id)}", new { id });

                    return rowsAffected > 0;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<WorkContract> Find(Expression<Func<WorkContract, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public WorkContract Get(int id)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.QuerySingleOrDefault<WorkContract>($@"SELECT * FROM [WorkContract]
                            WHERE [PersonId] = @{nameof(id)}", new { id });
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<WorkContract> GetAll()
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.Query<WorkContract>($@"SELECT * FROM [WorkContract]");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(WorkContract item)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    int rowsAffected = con.Execute($@"UPDATE [WorkContract]
                                        SET [File] = @{nameof(WorkContract.File)}, [Date] = @{nameof(WorkContract.Date)}", item);

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
