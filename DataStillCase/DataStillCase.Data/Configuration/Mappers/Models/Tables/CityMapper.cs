using DataStillCase.Entity.Models.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataStillCase.Data.Configuration.Mappers.Models.Tables
{
    public class CityMapper : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("CITIES", "dbo");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("Id").IsRequired().UseIdentityColumn();
            builder.Property(c => c.Name).HasColumnName("Name").HasMaxLength(50);
        }
    }
}
