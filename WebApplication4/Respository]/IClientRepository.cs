namespace WebApplication4.Controllers;

public interface IClientRepository
{
    Task<ClientDto> GetClientAsync(int id);
}