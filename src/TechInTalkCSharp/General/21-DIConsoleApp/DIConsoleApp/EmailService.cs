
namespace DIConsoleApp
{
    public interface IEmailService
    {
        void SendEmail(string email);
    }
    internal class EmailService : IEmailService
    {
        public void SendEmail(string email)
        {
            // implementation
        }
    }
}
