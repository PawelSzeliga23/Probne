namespace WebApplication4.Controllers;

public class BadRequestException : Exception
{
    public BadRequestException(string eMessage) : base(eMessage)
    {
    }
}