namespace WebApplication4.Modles;

public class Reservation
{
    public int IdReservation { get; set; }
    public int IdClient { get; set; }
    public DateOnly DateFrom { get; set; }
    public DateOnly DataTo { get; set; }
    public int IdBoastStandard { get; set; }
    public int Capacity { get; set; }
    public int NumOfBoats { get; set; }
    public bool Fullfiled { get; set; }
    public float Price { get; set; }
    public string CancelReason { get; set; }
    public virtual Client IdClientNavigation { get; set; }
    public virtual BoatStandard IdBoatStandardNavigation { get; set; }
    public virtual ICollection<SailboatReservation> SailboatReservations { get; set; }
}