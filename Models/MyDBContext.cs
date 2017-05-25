using hastowork.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace hastowork.Models 
{ 
    public class MyDbContext : DbContext 
    {
        public DbSet<Movie> Movies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Filename=./mydb.db");
        } 

    }
}