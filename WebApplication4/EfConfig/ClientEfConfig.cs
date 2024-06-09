using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication4.Modles;

namespace WebApplication4.EfConfig;

public class ClientEfConfig : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.ToTable("Client");

        builder.HasKey(c => c.IdClient);
        builder.Property(c => c.IdClient).ValueGeneratedOnAdd();

        builder.Property(c => c.NAme).HasMaxLength(100).IsRequired();
        builder.Property(c => c.surname).HasMaxLength(100).IsRequired();
        builder.Property(c => c.Email).HasMaxLength(100).IsRequired();
        builder.Property(c => c.Pesel).HasMaxLength(100).IsRequired();
        builder.Property(c => c.BirthYear).IsRequired();

        builder.HasMany<Reservation>(c => c.Reservations)
            .WithOne(r => r.IdClientNavigation)
            .HasForeignKey(r => r.IdClient).OnDelete(DeleteBehavior.Cascade);
        
        builder.HasOne<ClientCategory>(c => c.IdClientCategoryNavigation)
            .WithMany(cc => cc.Clients)
            .HasForeignKey(c => c.IdClientCategory);
    }
}