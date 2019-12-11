using AppLog.Domain.Models;
using AppLog.Domain.Models.Configuration;
using Microsoft.EntityFrameworkCore;

namespace AppDomainContext
{
    public class LogContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Environment> Environments { get; set; }
        public DbSet<Application> Applications  { get; set; }
        public DbSet<ApplicationCategory> ApplicationCategories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // CONNECTION USANDO LOCALSQLTRADICIONAL
            optionsBuilder.UseSqlServer(@"Server=localhost\sqlexpress;Database=Log;Trusted_Connection=True");
            // CONNECTION USANDO DOCKER
            optionsBuilder.UseSqlServer("Data Source = localhost, 11433; Initial Catalog = Log; User Id = SA; Password = DockerSql2017!;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EnvinromentEfConfig());
            builder.ApplyConfiguration(new ApplicationEfConfig());
            builder.ApplyConfiguration(new ApplicationCategoryEfConfig());
            base.OnModelCreating(builder); 
        }
    }
}