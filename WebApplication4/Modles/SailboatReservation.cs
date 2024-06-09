namespace WebApplication4.Modles;

public class SailboatReservation
{
    public int IdReservation { get; set; }
    public int IdSailboat { get; set; }
    public virtual Reservation IdReservationNavigation { get; set; }
    public virtual Sailboat IdSailboatNavigation { get; set; }
}