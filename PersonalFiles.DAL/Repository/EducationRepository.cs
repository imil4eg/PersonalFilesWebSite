using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

                    using(var cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = "INSERT INTO [Education] ([PersonId], [File], [EndDate])" +
                            "VALUES (@personId, @file, @endDate)";

                        cmd.Parameters.Add("@personId", System.Data.SqlDbType.Int).Value = item.PersonId;
                        cmd.Parameters.Add("@file", System.Data.SqlDbType.VarBinary, item.File.AsList().Count).Value = item.File;
                        cmd.Parameters.Add("@endDate", System.Data.SqlDbType.Date).Value = item.EndDate;

                        cmd.ExecuteNonQuery();
                    }

                    //return con.QuerySingle<Education>($@"INSET INTO [Education] ([PersonId], [File], [EndDate])
                    //        VALUES (@{nameof(Education.PersonId)}, @{nameof(Education.File)}, @{nameof(Education.EndDate)}",
                    //        new { PersonId = item.PersonId, File = item.File, EndDate = item.EndDate });

                    return null;
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

                    int rowsAffected = con.Execute($@"DELETE FROM [Education] WHERE [Id] = @{nameof(id)}", new { id });

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

                    return con.QueryFirstOrDefault<Education>($@"SELECT * FROM [Education] WHERE [Id] = @{nameof(id)}", new { id });
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
                    int rowsAffected;
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = "UPDATE [Education] SET [File] = @file, [EndDate] = @date " +
                            "WHERE [Id] = @id";

                        cmd.Parameters.Add("@file", System.Data.SqlDbType.VarBinary, item.File.Count()).Value = item.File;
                        cmd.Parameters.Add("@date", System.Data.SqlDbType.Date).Value = item.EndDate.Date;
                        cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = item.Id;

                        rowsAffected = cmd.ExecuteNonQuery();
                    }

                    //int rowsAffected = con.Execute($@"UPDATE [Education]
                    //                    SET [File] = @{nameof(Education.File)}, [EndDate] = @{nameof(Education.EndDate)}
                    //                    WHERE [Id] = @{nameof(Education.Id)}", item);

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
