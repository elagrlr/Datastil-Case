using DataStillCase.Data.Configuration.Mappers.Models.Tables;
using DataStillCase.Data.Configuration.Seeds.Models.Tables;
using DataStillCase.Entity.Models.Tables;
using Microsoft.EntityFrameworkCore;

namespace DataStillCase.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            var migrations = Database.GetPendingMigrationsAsync().Result;
            if (migrations.ToList().Count != 0)
            {
                Database.MigrateAsync().Wait();
            }
        }

        #region DBSets
        public DbSet<City> Cities { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<VisitorHistory> VisitorHistories { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Turkish_CI_AS");
            modelBuilder.HasDefaultSchema("dbo");
            base.OnModelCreating(modelBuilder);

            #region Mappers
            modelBuilder.ApplyConfiguration(new CityMapper());
            modelBuilder.ApplyConfiguration(new InformationMapper());
            modelBuilder.ApplyConfiguration(new VisitorHistoryMapper());
            #endregion

            #region Seed
            modelBuilder.ApplyConfiguration(new CitySeed());
            modelBuilder.ApplyConfiguration(new InformationSeed());
            modelBuilder.ApplyConfiguration(new VisitorHistorySeed());
            #endregion
        }
    }
}
