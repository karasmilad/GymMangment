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
    public class HelthRecordConfiguration : IEntityTypeConfiguration<HelthRecord>
    {
        public void Configure(EntityTypeBuilder<HelthRecord> builder)
        {
            builder.Property(p => p.BloodType).HasMaxLength(5);
            builder.Property(p=> p.Note).HasMaxLength(500);
        }
    }
}
