using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication4.Modles;

namespace WebApplication4.EfConfig;

public class SailboatReservationsEfConfig : IEntityTypeConfiguration<SailboatReservation>
{
    public void Configure(EntityTypeBuilder<SailboatReservation> builder)
    {
        builder.ToTable("Sailboat_Reservations");

        builder.HasKey(c => new { c.IdReservation, c.IdSailboat });

        builder.HasOne(sr => sr.IdReservationNavigation)
            .WithMany(r => r.SailboatReservations)
            .HasForeignKey(sr => sr.IdReservation);
        
        builder.HasOne(sr => sr.IdSailboatNavigation)
            .WithMany(s => s.SailboatReservations)
            .HasForeignKey(sr => sr.IdSailboat);
    }
}