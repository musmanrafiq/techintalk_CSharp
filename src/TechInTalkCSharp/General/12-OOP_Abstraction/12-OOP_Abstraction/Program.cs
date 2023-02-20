using EmailService;
using System.ComponentModel.DataAnnotations;

namespace _12_OOP_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Email emails = new Email();
            emails.Sent("subject", "Body");
        }
    }
}