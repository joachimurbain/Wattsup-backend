using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wattsup.Domain.CustomEnums;
using Wattsup.Domain.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Wattsup.DAL.Database.Configurations;
public class StoreConfig : IEntityTypeConfiguration<Store>
{
    public void Configure(EntityTypeBuilder<Store> builder)
    {
        builder.ToTable("Stores");

        #region Properties
        builder.Property(s => s.Id)
            .HasColumnName("Id")
            .ValueGeneratedOnAdd();

        builder.Property(s => s.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(s => s.Name)
            .IsRequired()
            .HasMaxLength(100);







        #endregion

        #region Keys
        builder.HasKey(u => u.Id);
        #endregion

        #region Relations

        #endregion
    }
}
