using Microsoft.EntityFrameworkCore;
using WebApplication4.Context;

namespace WebApplication4.Controllers;

public class ReservationsRepository : IReservationsRepository
{
    private readonly MyDbContext _context;

    public ReservationsRepository(MyDbContext context)
    {
        _context = context;
    }

    public async Task<int?> CreateReservation(ReservationPostDto reservationPostDto)
    {
        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(
                    r => r.Fullfiled == false && r.IdClient == reservationPostDto.IdClient);
            if (reservation != null)
            {
                throw new BadRequestException("Client has active reservation");
            }

            var sailboats = await _context.Sailboats
                .Where(s => s.IdBoatStandardNavigation.Level == reservationPostDto.BoatStandardLevel).ToListAsync();
            if (sailboats.Count < reservationPostDto.NumberOfBoats)
            {
                var levelUpSailboat = await _context.Sailboats
                    .Where(s => s.IdBoatStandardNavigation.Level == reservationPostDto.BoatStandardLevel + 1)
                    .ToListAsync();
                sailboats.Concat(levelUpSailboat);
                if (sailboats.Count < reservationPostDto.NumberOfBoats)
                {
                    throw new BadRequestException($"Not enough sailboats available");
                }
            }

            return null;
        }
        catch (Exception e)
        {
            transaction.RollbackAsync();
            throw new BadRequestException(e.Message);
        }
    }
}

public interface IReservationsRepository
{
    Task<int?> CreateReservation(ReservationPostDto reservationPostDto);
}