using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Dapper;

namespace PersonalFiles.DAL
{
    public class PositionRepository : IPositionRepository
    {
        private readonly string _connectionString;

        public PositionRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public Position Create(Position item)
        {
            try
            {
                using(var con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.QuerySingleOrDefault<Position>($@"INSERT INTO [Position] ([Name]) VALUES (@{nameof(Position.Name)})", item);
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
                    int rowAffected = con.Execute($@"DELETE FROM [Position] WHERE [Id] = @{nameof(id)}", new { id });

                    return rowAffected > 0;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Position> Find(Expression<Func<Position, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Position Get(int id)
        {
            try
            {
                using(var con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.QuerySingleOrDefault<Position>($@"SELECT * FROM [Position] WHERE [Id] = @{nameof(id)}", new { id });
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Position> GetAll()
        {
            try
            {
                using(var con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    return con.Query<Position>($@"SELECT * FROM [Position]");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(Position item)
        {
            try
            {
                using(var con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    int rowsAffected = con.Execute($@"UPDATE [Position] SET [Name] = @{nameof(Position.Name)}
                                        WHERE [Id] = @{nameof(Position.Id)}", item);

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
