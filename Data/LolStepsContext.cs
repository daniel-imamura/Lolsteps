namespace lolsteps_api.Data
{
    public class LolStepsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string connectionString = "server=us-cdbr-east-06.cleardb.net;database=heroku_3e8b3593a04eac2;user=b752dad96730eb;password=ac388159;";
            optionsBuilder.UseMySQL(connectionString);

        }
        public LolStepsContext(DbContextOptions<LolStepsContext> options) : base(options)
        {
        }

        public DbSet<Champions> Champions { get; set; }
    }
}