using System.Data;
using Microsoft.Data.SqlClient; // to create a database connection to Azure Data Studio
using Dapper; // to run queries on after an database connection has been setup with Azure Data Studio
using Microsoft.EntityFrameworkCore; // Microsoft Entity Framework
using HelloWorld.Models; // contains the "Computer" table model

namespace HelloWorld.Data
{
    public class DataContextEF : DbContext
    {
        public DbSet<Computer>? Computer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=false;User Id=sa;Password=SQLConnect1;",
                (options) =>
                {
                    options.EnableRetryOnFailure();
                });
            }

        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.HasDefaultSchema("SchemaOne");
            model.Entity<Computer>().HasKey(c => c.ComputerId);


        }

    }

}