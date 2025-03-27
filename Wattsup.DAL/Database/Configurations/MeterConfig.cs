using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wattsup.Domain.Models;
using Wattsup.Domain.CustomEnums;

namespace Wattsup.DAL.Database.Configurations;
public class MeterConfig : IEntityTypeConfiguration<Meter>
{
    public void Configure(EntityTypeBuilder<Meter> builder)
    {
        builder.ToTable("Meters");

        #region Properties
        builder.Property(m => m.Id)
            .HasColumnName("Id")
            .ValueGeneratedOnAdd();

        builder.Property(m => m.QrCode )
            .IsRequired();

        builder.Property(m => m.DeactivationDate);

        builder.Property(m => m.Uuid)
            .IsRequired();

        builder.Property(m => m.Type)
            .IsRequired()
            .HasConversion(
                g => g.ToString(),
                g => (MeterType)Enum.Parse(typeof(MeterType),
                g
            )
        );

        #endregion

        #region Keys
        builder.HasKey(u => u.Id);
        #endregion

        #region Relations
        builder.HasOne(m => m.Store)
            .WithMany(s => s.Meters)
            .HasForeignKey("StoreId")
            .OnDelete(DeleteBehavior.Cascade);
        #endregion
    }
}
