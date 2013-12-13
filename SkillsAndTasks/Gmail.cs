using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace SkillsAndTasks
{
    public class Gmail
    {
        public String MailAddress { get; set; }
        public String MailAddressName { get; set;}
        public String Login { get; set; }
        public String Password { get; set; }
        public String From { get; set; }
        public String FromName {get; set; }
        public String Message { get; set; }
        public String Subject { get; set; }

        public void send()
        {
            
            var fromAddress = new MailAddress(From, FromName );
            var toAddress = new MailAddress(MailAddress, MailAddressName);

            var smtp = new SmtpClient
               {
                   Host = "smtp.gmail.com",
                   Port = 587,
                   EnableSsl = true,
                   DeliveryMethod = SmtpDeliveryMethod.Network,
                   UseDefaultCredentials = false,
                   Credentials = new NetworkCredential(fromAddress.Address, Password)
               };
                
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = Subject,
                Body = Message
            })
            {
                smtp.Send(message);
            }
     }
  }
}
