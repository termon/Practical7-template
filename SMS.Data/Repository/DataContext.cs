using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SMS.Data.Entities;

namespace SMS.Data.Repository;

internal class DataContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
        .UseSqlite("Filename=data.db");
        //.LogTo(Console.WriteLine, LogLevel.Information);
    }

    // custom method used in development to keep database in sync with models
    public void Initialise() 
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    
}

