using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

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
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                if(connection.State == ConnectionState.Open)
                {
                    using(SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = $"INSERT INTO [Person] (Id, LastName, FirstName, MiddleName, Gender, SNILS, INN)" +
                            $"VALUES (@param0, @param1, @param2, @param3, @param4, @param5, @param6)";

                        cmd.Parameters.Add("@param0", SqlDbType.BigInt).Value = item.Id;
                        cmd.Parameters.Add("@param1", SqlDbType.NVarChar, 150).Value = item.LastName;
                        cmd.Parameters.Add("@param2", SqlDbType.NVarChar, 100).Value = item.FirstName;
                        cmd.Parameters.Add("@param3", SqlDbType.NVarChar, 150).Value = item.MiddleName;
                        cmd.Parameters.Add("@param4", SqlDbType.TinyInt).Value = item.Gender;
                        cmd.Parameters.Add("@param5", SqlDbType.NVarChar, 11).Value = item.SNILS;
                        cmd.Parameters.Add("@param6", SqlDbType.NVarChar, 13).Value = item.INN;

                        int result = cmd.ExecuteNonQuery();
                    }
                }
            }

            return item;
        }

        public int Delete(int id)
        {
            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                if(con.State == ConnectionState.Open)
                {
                    using(SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = $"DELETE FROM Person WHERE Id = {id}";
                        int result = cmd.ExecuteNonQuery();
                    }
                }
            }

            return id;
        }

        public IEnumerable<Person> Find(Expression<Func<Person, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            Person person = new Person();

            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                if(con.State == ConnectionState.Open)
                {
                    using(SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = $"SELECT * FROM Person WHERE Id = {id}";
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                person.Id = reader.GetValue<int>(0);
                                person.LastName = reader.GetValue<string>(1);
                                person.FirstName = reader.GetValue<string>(2);
                                person.MiddleName = reader.GetValue<string>(3);
                                person.Gender = reader.GetValue<Gender>(4);
                                person.SNILS = reader.GetValue<string>(5);
                                person.INN = reader.GetValue<string>(6);
                            }
                        }
                    }
                }
            }

            return person;
        }

        public IEnumerable<Person> GetAll()
        {
            List<Person> persons = new List<Person>();

            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                if(con.State == ConnectionState.Open)
                {
                    using(SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = $"SELECT * FROM Person";
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                persons.Add(new Person
                                {
                                    Id = reader.GetValue<int>(0),
                                    LastName = reader.GetValue<string>(1),
                                    FirstName = reader.GetValue<string>(2),
                                    MiddleName = reader.GetValue<string>(3),
                                    Gender = reader.GetValue<Gender>(4),
                                    SNILS = reader.GetValue<string>(5),
                                    INN = reader.GetValue<string>(6),
                                });
                            }
                        }
                    }
                }
            }

            return persons;
        }

        public bool Update(Person item)
        {
            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                if(con.State == ConnectionState.Open)
                {
                    using(SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = $"UPDATE [Person] SET LastName = @param1, FirstName = @param2, " +
                            $"MiddleName = @param3, Gender = @param4, SNILS = @param5, INN = @param6";

                        cmd.Parameters.Add("@param1", SqlDbType.NVarChar).Value = item.LastName;
                        cmd.Parameters.Add("@param2", SqlDbType.NVarChar).Value = item.FirstName;
                        cmd.Parameters.Add("@param3", SqlDbType.NVarChar).Value = item.MiddleName;
                        cmd.Parameters.Add("@param4", SqlDbType.Int).Value = item.Gender;
                        cmd.Parameters.Add("@param5", SqlDbType.NVarChar).Value = item.SNILS;
                        cmd.Parameters.Add("@param6", SqlDbType.NVarChar).Value = item.INN;

                        int result = cmd.ExecuteNonQuery();
                    }
                }
            }

            return true;
        }
    }
}
