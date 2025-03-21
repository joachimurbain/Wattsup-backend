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
public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        #region Properties
        builder.Property(u => u.Id)
            .HasColumnName("Id")
            .ValueGeneratedOnAdd();

        builder.Property(u => u.Firstname)
            .IsRequired()
            .HasMaxLength(50);
        builder.Property(u => u.Lastname)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(c => c.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.Password)
            .IsRequired()
            .HasMaxLength(1024);

        builder.Property(c => c.IsActive)
            .IsRequired();

        builder.Property(c => c.Role)
            .IsRequired()
            .HasConversion(
                g => g.ToString(),
                g => (Role)Enum.Parse(typeof(Role),
                g
            )
        );




        #endregion

        #region Keys
        builder.HasKey(u => u.Id);
        #endregion

        #region Relations

        #endregion
    }
}
