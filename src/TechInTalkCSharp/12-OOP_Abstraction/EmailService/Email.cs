using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService
{
    public class Email
    {
        public void Sent(string subject, string body)
        {

        }
        public void Sent(string subject, string body, Stream[] attachments)
        {

        }

        private void CheckSmtpServerStatus() { }
        private void ScanAttachments() { }
        private void QueueEmail() { }

    }
}
