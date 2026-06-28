using GymMnagment.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMnagment.DAL.Data.Configurations
{
    public class MemberShipConfiguration : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CreatedAt)
                .HasColumnName("StartDate")
                .HasDefaultValueSql("GETDATE()");

        }
    }
}
