using WebApplication4.Modles;

namespace WebApplication4.Controllers;

public class ClientDto
{
    public int IdClient { get; set; }
    public string NAme { get; set; }
    public string surname { get; set; }
    public DateOnly BirthYear { get; set; }
    public string Pesel { get; set; }
    public string Email { get; set; }
    public int IdClientCategory { get; set; }
    public IEnumerable<ReservationDto> ReservationDtos { get; set; }
}