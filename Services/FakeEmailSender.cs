using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

public class FakeEmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        Console.WriteLine($"Correo simulado a {email} con asunto: {subject}");
        return Task.CompletedTask;
    }
}
