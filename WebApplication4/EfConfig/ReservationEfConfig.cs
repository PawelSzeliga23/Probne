using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication4.Modles;

namespace WebApplication4.EfConfig;

public class ReservationEfConfig : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        builder.ToTable("reservations");

        builder.HasKey(r => r.IdReservation);
        builder.Property(r => r.IdReservation).ValueGeneratedOnAdd();

        builder.Property(r => r.Capacity).IsRequired();
        builder.Property(r => r.Fullfiled).IsRequired();
        builder.Property(r => r.DateFrom).IsRequired();
        builder.Property(r => r.DataTo).IsRequired();
        builder.Property(r => r.NumOfBoats).IsRequired();
        builder.Property(r => r.Price);
        builder.Property(r => r.CancelReason).HasMaxLength(200);
    }
}