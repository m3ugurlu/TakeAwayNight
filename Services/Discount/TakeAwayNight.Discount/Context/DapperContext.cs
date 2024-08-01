﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TakeAwayNight.Discount.Entities;

namespace TakeAwayNight.Discount.Context
{
    public class DapperContext : DbContext

    {
        private readonly IConfiguration _configuration;
     

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConneciton");

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=MUGURLU; initial Catalog=TAN-Discount;integrated Security=true;");
        //}

        public DbSet<DiscountCoupon> DiscountCoupons { get; set; }

        private readonly string _connectionString;
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
