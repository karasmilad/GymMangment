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
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.Ignore(p => p.Id);
            builder.Property(p => p.CreatedAt)
                .HasColumnName("BookingDate")
                .HasDefaultValueSql("GETDATE()");
            builder.HasKey(p=> new { p.MemberId, p.SessionId });
        }
    }
}
