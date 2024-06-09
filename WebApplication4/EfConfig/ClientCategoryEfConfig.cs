using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication4.Modles;

namespace WebApplication4.EfConfig;

public class ClientCategoryEfConfig : IEntityTypeConfiguration<ClientCategory>
{
    public void Configure(EntityTypeBuilder<ClientCategory> builder)
    {
        builder.ToTable("ClientCategory");

        builder.HasKey(c => c.IdClientCategory);
        builder.Property(c => c.IdClientCategory).ValueGeneratedOnAdd();

        builder.Property(c => c.Name).HasMaxLength(100).IsRequired();
        builder.Property(c => c.DiscountPrice).IsRequired();
    }
}