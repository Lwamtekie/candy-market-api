using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CandyMarket.Api.DataModels;
using CandyMarket.Api.Dtos;
using Dapper;

namespace CandyMarket.Api.Repositories
{
    public class CandyRepository : ICandyRepository
    {
         string _connectionString = "Server=localhost;Database=CandyMarket;Trusted_Connection=True;";
        public IEnumerable<Candy> GetAllCandy()
        {
            using var db = new SqlConnection(_connectionString);
            var candies = db.Query<Candy>("Select * From Candy");


            return candies; 
        }
        public Candy Get(string name)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"select *
                           from Candy
                            where Candy.Name = @candyName";
                var parameters = new { CandyName = name };
                var candy = db.QueryFirst<Candy>(sql, parameters);
                return candy;
            }
        }

        public bool AddCandy(AddCandyDto newCandy)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"
                            Insert into Candy
                            ([Name],[candytypeId],[Candyflavor])
                            output inserted.*
                            values (@name,@candytypeid,@candyflavor)";
                return db.Execute(sql, newCandy) == 1;
            }
        }

        public bool EatCandy(int candyIdToDelete)
        {
           using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"delete
                            from Candy
                            where [id] = @candyIdToDelete";

                return db.Execute(sql, new { candyIdToDelete }) >= 1;

            }
        }

        public bool UpdateCandy(int candyIdToUpdate)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"update Candy
                            set [Name] = @name,
                                [candyflavor] = @candyflavor
                                where [id] = @candyIdToDelete";
                return db.Execute(sql, new { candyIdToUpdate }) == 1;

            }
        }
    }
}