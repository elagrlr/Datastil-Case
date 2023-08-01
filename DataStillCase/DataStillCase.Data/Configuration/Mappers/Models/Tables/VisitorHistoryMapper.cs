using DataStillCase.Entity.Models.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataStillCase.Data.Configuration.Mappers.Models.Tables
{
    public class VisitorHistoryMapper : IEntityTypeConfiguration<VisitorHistory>
    {
        public void Configure(EntityTypeBuilder<VisitorHistory> builder)
        {
            builder.ToTable("VISITORHISTORIES", "dbo");

            builder.HasKey(v => v.Id);

            builder.Property(v => v.Id).HasColumnName("Id").IsRequired().UseIdentityColumn();
            builder.Property(v => v.CityId).HasColumnName("CityId").IsRequired();

            builder.Property(v => v.Date).HasColumnName("Date").IsRequired().HasDefaultValueSql("GETDATE()");
            builder.Property(v => v.VisitorCount).HasColumnName("VisitorCount").IsRequired();

            builder.HasOne(v => v.City).WithMany(c => c.VisitorHistories).HasForeignKey(v => v.CityId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
