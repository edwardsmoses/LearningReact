using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataPersist
{

    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<DataContext>();
          builder.UseSqlite("Data source=learnreact.db");
        return new DataContext(builder.Options);
    }
}

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Domain.Value> Values { get; set; }


        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Domain.Value>().HasData(
                new Domain.Value{
                    Id = 1,
                    Name = "Value 101"
                },
                 new Domain.Value{
                    Id = 2,
                    Name = "Value 102"
                },
                 new Domain.Value{
                    Id = 3,
                    Name = "Value 103"
                },
                 new Domain.Value{
                    Id = 4,
                    Name = "Value 104"
                }
            );
            
        }

    }
}
