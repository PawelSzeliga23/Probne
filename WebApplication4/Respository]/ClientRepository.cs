using Microsoft.EntityFrameworkCore;
using WebApplication4.Context;

namespace WebApplication4.Controllers;

public class ClientRepository : IClientRepository
{
    private readonly MyDbContext _context;

    public ClientRepository(MyDbContext context)
    {
        _context = context;
    }

    public async Task<ClientDto> GetClientAsync(int id)
    {
        var client = await _context.Clients.FirstOrDefaultAsync(c => c.IdClient == id);
        if (client == null)
        {
            throw new NotFoundException($"Client with id : {id} not found");
        }

        var reservations = await _context.Reservations
            .Where(r => r.IdClient == id)
            .Select(r => new ReservationDto()
            {
                IdReservation = r.IdReservation,
                DateFrom = r.DateFrom,
                DataTo = r.DataTo,
                Capacity = r.Capacity,
                IdBoastStandard = r.IdBoastStandard,
                CancelReason = r.CancelReason ?? "",
                Fullfiled = r.Fullfiled,
                NumOfBoats = r.NumOfBoats,
                Price = r.Price
            }).ToListAsync();
        var res = new ClientDto()
        {
            IdClient = client.IdClient,
            BirthYear = client.BirthYear,
            Email = client.Email,
            IdClientCategory = client.IdClientCategory,
            NAme = client.NAme,
            surname = client.surname,
            Pesel = client.Pesel,
            ReservationDtos = reservations
        };
        return res;
    }
}