namespace WebApplication4.Modles;

public class ClientCategory
{
    public int IdClientCategory { get; set; }
    public string Name { get; set; }
    public int DiscountPrice { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
}