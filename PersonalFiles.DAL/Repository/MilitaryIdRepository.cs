using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Dapper;

namespace PersonalFiles.DAL
{
    public class MilitaryIdRepository : IMilitaryIdRepository
    {
        protected readonly string _connectionString;

        public MilitaryIdRepository(string connection)
        {
            _connectionString = connection;
        }

        public MilitaryID Create(MilitaryID item)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.QuerySingleOrDefault<MilitaryID>($@"INSERT INTO [MilitaryID]
                            ([PersonId] [NumberOfUnit] [Place] [BegginingDate] [EndDate] [Rank] [GaveBy])
                            VALUES (@{nameof(MilitaryID.PersonId)}, @{nameof(MilitaryID.NumberOfUnit)}, @{nameof(MilitaryID.Place)}, @{nameof(MilitaryID.BegginingDate)},
                            @{nameof(MilitaryID.EndDate)}, @{nameof(MilitaryID.Rank)}, @{nameof(MilitaryID.GaveBy)}", item);
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
                    int affectedRows = con.Execute($@"DELETE FROM [MilitaryID]
                                        WHERE [PersonId] = @{nameof(id)}", new { id });

                    return affectedRows > 0;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<MilitaryID> Find(Expression<Func<MilitaryID, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public MilitaryID Get(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.QuerySingleOrDefault<MilitaryID>($@"SELECT * FROM [MilitaryID]
                                WHERE [PersonId] = @{nameof(id)}", new { id });
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<MilitaryID> GetAll()
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.Query<MilitaryID>("SELECT * FROM [MilitaryID]");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(MilitaryID item)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    int affectedRows = con.Execute($@"UPDATE [MilitaryID]
                                        SET [NumberOfUnit] = @{nameof(MilitaryID.NumberOfUnit)}, [Place] = @{nameof(MilitaryID.Place)},
                                        [BegginingDate] = @{nameof(MilitaryID.BegginingDate)}, [EndDate] = @{nameof(MilitaryID.EndDate)}
                                        [Rank] = @{nameof(MilitaryID.Rank)}, [GaveBy] = @{nameof(MilitaryID.GaveBy)}", item);

                    return affectedRows > 0;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
