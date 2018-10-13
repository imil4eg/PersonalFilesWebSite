using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Dapper;

namespace PersonalFiles.DAL
{
    public class InsuranceRepository : IInsurancePolicyRepository
    {
        protected readonly string _connectionString;

        public InsuranceRepository(string connection)
        {
            _connectionString = connection;
        }

        public InsurancePolicy Create(InsurancePolicy item)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.QuerySingleOrDefault<InsurancePolicy>($@"INSERT INTO [InsurancePolicy] ([PersonId] [Number] [Company])
                            VALUES (@{nameof(InsurancePolicy.PersonId)}, @{nameof(InsurancePolicy.Number)}, @{nameof(InsurancePolicy.Company)})", item);
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
                    int rowsAffected = con.Execute($@"DELETE FROM [InsurancePolicy] WHERE [PersonId] = @{nameof(id)}", new { id });

                    return rowsAffected > 0;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<InsurancePolicy> Find(Expression<Func<InsurancePolicy, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public InsurancePolicy Get(int id)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.QuerySingleOrDefault<InsurancePolicy>($@"SELECT * FROM [InsurancePolicy]
                                            WHERE [PersonId] = @{nameof(id)}", new { id });
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<InsurancePolicy> GetAll()
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.Query<InsurancePolicy>($@"SELECT * FROM [InsurancePolicy]").AsList();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(InsurancePolicy item)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    int rowsAffected = con.Execute($@"UPDATE [InsurancePolicy]
                        SET [Number] = @{nameof(InsurancePolicy.Number)}, [Company] = @{nameof(InsurancePolicy.Company)}", item);

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
