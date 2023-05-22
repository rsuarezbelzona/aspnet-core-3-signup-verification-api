using DataDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApi.Entities;

namespace WebApi.Helpers
{
    public class DataContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        //-----------------------------------------------------------------------

        public DbSet<Belzona_Nations> Belzona_Nations { get; set; }

        public DbSet<CustomerTable> CustomerTables { get; set; }

        //public DataDBContext myContext;

        private readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;

            //DbContextOptionsBuilder options = new DbContextOptionsBuilder();
            //options.UseSqlServer(Configuration.GetConnectionString("DataDBModel1"));
            //var c = options;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //var builder = WebApplication.CreateBuilder(args);

            //builder.Services.AddDbContext<DataContext>(options =>
            //options.UseSqlServer(builder.Configuration.GetConnectionString("MvcMovieContext")));

            // connect to sqlite database

            //options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
            //var c = options;

            options.UseSqlServer(Configuration.GetConnectionString("DataDBModel1"));
            //var d = options;


        }
    }
}