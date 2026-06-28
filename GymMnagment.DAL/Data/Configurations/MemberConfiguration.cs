using GymMnagment.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GymMnagment.DAL.Data.Configurations
{
    public class MemberConfiguration : GymUserConfiguration<Member> , IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(p => p.CreatedAt)
                .HasDefaultValueSql("GETDATE()")
                .HasColumnName("JoinDate");
            base.Configure(builder);

        }
    }
}
