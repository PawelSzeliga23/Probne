namespace WebApplication4.Controllers;

public interface IClientService
{
    Task<ClientDto> GetClientAsync(int id);
}