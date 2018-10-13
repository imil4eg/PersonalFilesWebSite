﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                connection.Execute($@"INSERT INTO [Person] ([Id], [LastName], [FirstName], 
                            [MiddleName], [Gender], [SNILS], [INN])
                            VALUES (@{nameof(Person.Id)}, @{nameof(Person.LastName)}, @{nameof(Person.FirstName)}, 
                            @{nameof(Person.MiddleName)}, @{nameof(Person.Gender)}, @{nameof(Person.SNILS)},
                            @{nameof(Person.INN)});", item);
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
            Person person = new Person();

            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                con.QuerySingleOrDefault<Person>($@"SELECT * FROM [Person] WHERE [Id] = @{nameof(id)}", new { id });
            }

            return person;
        }

        public IEnumerable<Person> GetAll()
        {
            List<Person> persons = new List<Person>();

            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                persons = con.Query<Person>("SELECT * FROM [Person]").AsList();
            }

            return persons;
        }

        public bool Update(Person item)
        {
            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                con.Execute($@"UPDATE [Person] SET [LastName] = @{nameof(Person.LastName)}, 
                    [FirstName] = @{nameof(Person.FirstName)}, [MiddleName] = @{nameof(Person.MiddleName)}, 
                    [Gender] = @{nameof(Person.Gender)}, [SNILS] = @{nameof(Person.SNILS)}, [INN] = @{nameof(Person.INN)}", item);
            }

            return true;
        }
    }
}
