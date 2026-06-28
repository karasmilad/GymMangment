using GymMnagment.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymMnagment.DAL.Data.Configurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(p => p.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.ToTable(tb =>
            {
                tb.HasCheckConstraint("SesstionCapacityCheck", "Capacity Between 1 and 25");
                tb.HasCheckConstraint("SesstionEndDateCheck", "EndDate > StartDate");
            });
        }
    }
}
