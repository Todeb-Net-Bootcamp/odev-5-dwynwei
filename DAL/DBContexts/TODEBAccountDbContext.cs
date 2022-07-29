using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models.Entities;

namespace DAL.DBContexts
{
    /*
     * 
     * DBContext
     * Contains -> Configuration {Presentation Layer}
     * DbSet for each Model
     * Connection String from appsettings.json
     */
    public class TODEBAccountDbContext:DbContext
    {
        private IConfiguration _configuration;
        public TODEBAccountDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<Account> Accounts { get; set; } //DB Context of Account Model
        public DbSet<Card> Cards { get; set; } //DB Context of Card Model
        /*
         * DB Context of Transaction Model
         * It is create for calculating the transactions between expense operations and income operations
         */
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connStr = _configuration.GetConnectionString("MySql");
            base.OnConfiguring(optionsBuilder.UseMySQL(connStr)); // MySql Connection with EFCore via 'appsettings.json'
        }
    }
}