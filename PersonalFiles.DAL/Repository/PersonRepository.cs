using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;

using Dapper;

namespace PersonalFiles.DAL
{
    public class PersonRepository : IPersonRepository
    {
        protected readonly string _connectionString;

        public PersonRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Person Create(Person item)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    //connection.Execute($@"INSERT INTO [Person] ([LastName], [FirstName], 
                    //            [MiddleName], [Gender], [SNILS], [INN])
                    //            VALUES (@{nameof(Person.LastName)}, @{nameof(Person.FirstName)}, 
                    //            @{nameof(Person.MiddleName)}, @{nameof(Person.Gender)}, @{nameof(Person.SNILS)},
                    //            @{nameof(Person.INN)});", item);

                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO [Person] ([LastName], [FirstName], [MiddleName], [Gender], [SNILS], [INN], [Image])" +
                            "VALUES (@lastname, @firstname, @middlename, @gender, @snils, @inn, @image)";

                        cmd.Parameters.Add("@lastname", System.Data.SqlDbType.NVarChar).Value = item.LastName;
                        cmd.Parameters.Add("@firstname", System.Data.SqlDbType.NVarChar).Value = item.FirstName;
                        cmd.Parameters.AddWithValue("@middlename", item.MiddleName ?? SqlString.Null);
                        cmd.Parameters.Add("@gender", System.Data.SqlDbType.Bit).Value = item.Gender;
                        cmd.Parameters.Add("@snils", System.Data.SqlDbType.NVarChar).Value = item.SNILS;
                        cmd.Parameters.Add("@inn", System.Data.SqlDbType.NVarChar).Value = item.INN;
                        cmd.Parameters.Add("@image", System.Data.SqlDbType.VarBinary, -1).Value = item.Image ?? (object)DBNull.Value;

                        cmd.ExecuteNonQuery();
                    }

                    item.Id = this.GetAll().Last().Id;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return item;
        }

        public bool Delete(int id)
        {
            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                con.Execute($"DELETE FROM [Person] WHERE [Id] = @{nameof(id)}", new { id });
            }

            return true;
        }

        public IEnumerable<Person> Find(Expression<Func<Person, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                return con.QuerySingleOrDefault<Person>($@"SELECT * FROM [Person] WHERE [Id] = @{nameof(id)}", new { id });
            }
        }

        public IEnumerable<Person> GetAll()
        {
            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                return con.Query<Person>("SELECT * FROM [Person]").AsList();
            }
        }

        public bool Update(Person item)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    int rowsAffected = 0;
                    using(var cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = "UPDATE [Person] SET [LastName] = @lastname, [FirstName] = @firstname, [MiddleName] = @middlename, " +
                            "[Gender] = @gender, [SNILS] = @snils, [INN] = @inn, [Image] = @image " +
                            "WHERE [Id] = @id";

                        cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = item.Id;
                        cmd.Parameters.Add("@lastname", System.Data.SqlDbType.NVarChar).Value = item.LastName;
                        cmd.Parameters.Add("@firstname", System.Data.SqlDbType.NVarChar).Value = item.FirstName;
                        cmd.Parameters.AddWithValue("@middlename", item.MiddleName ?? SqlString.Null);
                        cmd.Parameters.Add("@gender", System.Data.SqlDbType.Bit).Value = item.Gender;
                        cmd.Parameters.Add("@snils", System.Data.SqlDbType.NVarChar).Value = item.SNILS;
                        cmd.Parameters.Add("@inn", System.Data.SqlDbType.NVarChar).Value = item.INN;
                        cmd.Parameters.Add("@image", System.Data.SqlDbType.VarBinary, -1).Value = item.Image ?? (object)DBNull.Value;

                        rowsAffected = cmd.ExecuteNonQuery();
                    }


                   // int rowsAffected = con.Execute($@"UPDATE [Person] SET [LastName] = @{nameof(Person.LastName)}, 
                   //                 [FirstName] = @{nameof(Person.FirstName)}, [MiddleName] = @{nameof(Person.MiddleName)}, 
                   //                 [Gender] = @{nameof(Person.Gender)}, [SNILS] = @{nameof(Person.SNILS)}, [INN] = @{nameof(Person.INN)}
                   //                 WHERE [Id] = @{nameof(Person.Id)}", item);

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
