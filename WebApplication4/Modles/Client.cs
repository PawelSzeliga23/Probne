namespace WebApplication4.Modles;

public class Client
{
    public int IdClient { get; set; }
    public string NAme { get; set; }
    public string surname { get; set; }
    public DateOnly BirthYear { get; set; }
    public string Pesel { get; set; }
    public string Email { get; set; }
    public int IdClientCategory { get; set; }
    public virtual ICollection<Reservation> Reservations { get; set; }
    public virtual ClientCategory IdClientCategoryNavigation { get; set; }
}