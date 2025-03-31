using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wattsup.Domain.CustomEnums;
using Wattsup.Domain.Models;

namespace Wattsup.DAL.Database.Configurations;
public class MeterReadingConfig : IEntityTypeConfiguration<MeterReading>
{
	public void Configure(EntityTypeBuilder<MeterReading> builder)
	{
		builder.ToTable("MeterReadings");

		#region Properties
		builder.Property(m => m.Id)
			.HasColumnName("Id")
			.ValueGeneratedOnAdd();

		builder.Property(m => m.ReadingDate)
			.IsRequired();

		builder.Property(m => m.Value)
			.IsRequired();


		builder.Property(m => m.Source)
			.IsRequired()
			.HasConversion(
				g => g.ToString(),
				g => (MeterReadingSource)Enum.Parse(typeof(MeterReadingSource),
				g
			)
		);

		#endregion

		#region Keys
		builder.HasKey(m => m.Id);
		#endregion

		#region Relations
		builder.HasOne(m => m.Meter)
			.WithMany(m => m.Readings)
			.HasForeignKey(m => m.MeterId)
			.OnDelete(DeleteBehavior.Cascade);
		#endregion
	}
}
