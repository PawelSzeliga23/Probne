using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication4.Modles;

namespace WebApplication4.EfConfig;

public class SailboatEfConfig : IEntityTypeConfiguration<Sailboat>
{
    public void Configure(EntityTypeBuilder<Sailboat> builder)
    {
        builder.ToTable("Sailboat");

        builder.HasKey(c => c.IdSailboat);
        builder.Property(c => c.IdSailboat).ValueGeneratedOnAdd();

        builder.Property(c => c.Name).HasMaxLength(100).IsRequired();
        builder.Property(c => c.Capacity).IsRequired();
        builder.Property(c => c.Description).HasMaxLength(100).IsRequired();
        builder.Property(c => c.Price).IsRequired();
    }
}