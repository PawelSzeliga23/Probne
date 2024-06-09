namespace WebApplication4.Controllers;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<ClientDto> GetClientAsync(int id)
    {
        return await _clientRepository.GetClientAsync(id);
    }
}