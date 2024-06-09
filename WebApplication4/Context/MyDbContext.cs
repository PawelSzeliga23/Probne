using Microsoft.EntityFrameworkCore;
using WebApplication4.EfConfig;
using WebApplication4.Modles;

namespace WebApplication4.Context;

public class MyDbContext : DbContext
{
    public DbSet<Client> Clients;
    public DbSet<Reservation> Reservations;
    public DbSet<Sailboat> Sailboats;
    public DbSet<SailboatReservation> SailboatReservations;
    public DbSet<BoatStandard> BoatStandards;
    public DbSet<ClientCategory> ClientCategories;

    protected MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClientEfConfig());
        modelBuilder.ApplyConfiguration(new ReservationEfConfig());
        modelBuilder.ApplyConfiguration(new BoatStandardEfConfig());
        modelBuilder.ApplyConfiguration(new ClientCategoryEfConfig());
        modelBuilder.ApplyConfiguration(new SailboatEfConfig());
        modelBuilder.ApplyConfiguration(new SailboatReservationsEfConfig());
    }
}