namespace WebApplication4.Controllers;

public class ReservationPostDto
{
    public int IdClient { get; set; }
    public DateOnly DateFrom { get; set; }
    public DateOnly DateTo { get; set; }
    public int BoatStandardLevel { get; set; }
    public int NumberOfBoats { get; set; }
}