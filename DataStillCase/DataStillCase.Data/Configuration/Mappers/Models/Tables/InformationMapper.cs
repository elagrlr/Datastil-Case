using DataStillCase.Entity.Models.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataStillCase.Data.Configuration.Mappers.Models.Tables
{
    public class InformationMapper : IEntityTypeConfiguration<Information>
    {
        public void Configure(EntityTypeBuilder<Information> builder)
        {
            builder.ToTable("INFORMATIONS", "dbo");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id).HasColumnName("Id").IsRequired().UseIdentityColumn();
            builder.Property(i => i.CityId).HasColumnName("CityId").IsRequired();

            builder.Property(i => i.Latitude).HasColumnName("Latitude").IsRequired();
            builder.Property(i => i.Longitude).HasColumnName("Longitude").IsRequired();

            builder.Property(i => i.Editor).HasColumnName("Editor");

            builder.HasOne(i => i.City).WithMany(c => c.Informations).HasForeignKey(i => i.CityId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
