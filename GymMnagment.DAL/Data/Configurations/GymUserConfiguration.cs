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
    public class GymUserConfiguration<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(p => p.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            builder.Property(p => p.Email)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            builder.HasIndex(i => i.Email).IsUnique();
            builder.HasIndex(i => i.Phone).IsUnique();
            builder.ToTable(tb =>
            {
                tb.HasCheckConstraint("EmailCheck", "Email LIKE '_%@_%._%'");
                tb.HasCheckConstraint("PhoneCheck", "Phone LIKE '01%'");
            });
            builder.OwnsOne(x => x.Address, address =>
            {
                address.Property(p => p.City).HasColumnName("City").HasColumnType("varchar").HasMaxLength(30);
                address.Property(p => p.Street).HasColumnName("Street").HasColumnType("varchar").HasMaxLength(30);
            });
        }
    }
}
