namespace WebApplication4.Modles;

public class Sailboat
{
    public int IdSailboat { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Capacity { get; set; }
    public int IdBoatStandard { get; set; }
    public float Price { get; set; }
    public virtual BoatStandard IdBoatStandardNavigation { get; set; }
    public virtual ICollection<SailboatReservation> SailboatReservations { get; set; }
}