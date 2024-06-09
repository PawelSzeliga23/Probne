namespace WebApplication4.Controllers;

public class ReservationDto
{
    public int IdReservation { get; set; }
    public DateOnly DateFrom { get; set; }
    public DateOnly DataTo { get; set; }
    public int IdBoastStandard { get; set; }
    public int Capacity { get; set; }
    public int NumOfBoats { get; set; }
    public bool Fullfiled { get; set; }
    public float? Price { get; set; }
    public string? CancelReason { get; set; }
}