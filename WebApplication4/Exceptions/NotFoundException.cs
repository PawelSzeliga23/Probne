namespace WebApplication4.Controllers;

public class NotFoundException(string message) : Exception(message)
{
}