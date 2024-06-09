using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication4.Modles;

namespace WebApplication4.EfConfig;

public class BoatStandardEfConfig : IEntityTypeConfiguration<BoatStandard>
{
    public void Configure(EntityTypeBuilder<BoatStandard> builder)
    {
        builder.ToTable("BoatStandard");

        builder.HasKey(c => c.IdBoatStandard);
        builder.Property(c => c.IdBoatStandard).ValueGeneratedOnAdd();

        builder.Property(c => c.Name).HasMaxLength(100).IsRequired();
        builder.Property(c => c.Level).IsRequired();

        builder.HasMany(bs => bs.Reservations)
            .WithOne(r => r.IdBoatStandardNavigation)
            .HasForeignKey(r => r.IdBoastStandard);
        
        builder.HasMany(bs => bs.Sailboats)
            .WithOne(s => s.IdBoatStandardNavigation)
            .HasForeignKey(s => s.IdBoatStandard);
    }
}