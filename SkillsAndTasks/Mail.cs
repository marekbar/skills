using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SkillsAndTasks
{
    public class Mail
    {
        public bool isEnabled { get; set; }
        public List<String> MailList = new List<String>();
        public List<String> AttachedFileList = new List<String>();
        public String Login { get; set; }
        public String Password { get; set; }
        public String Server { get; set; }
        public String From { get; set; }
        public int Port { get; set; }
        public bool isSSL { get; set; }
        public String Message { get; set; }
        public String Subject { get; set; }

        private bool validate()
        {
            if (Login == String.Empty || Password == String.Empty || Server == String.Empty
                || Message == String.Empty || Subject == String.Empty)
            {
                return false;
            }

            if (MailList.Count == 0)
            {
                return false;
            }

            foreach (String mailAddress in MailList)
            {
                if (!Mail.IsValidEmail(mailAddress))
                {
                    return false;
                }
            }
            if (!IsValidEmail(From))
            {
                return false;
            }

            foreach (String filename in AttachedFileList)
            {
                if (!System.IO.File.Exists(filename))
                {
                    return false;
                }
            }

            return true;
        }

        private static Mail instance = null;
        public static Mail Instance
        {
            get
            {
                if (instance == null)
                {
                    try
                    {
                        instance = new Mail();
                    }
                    catch { }
                }
                return instance;
            }
        }

        public Mail()
        {
        }

        public bool send(String message = "", String subjectArg = "")
        {
            try
            {
                if (message != "")
                {
                    this.Message = message;
                }
                if (subjectArg != "")
                {
                    this.Subject = subjectArg;
                }

                return this.sendAsync(this.createMessage());
            }
            catch
            {
                return false;
            }

        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool sendAsync(MailMessage mail)
        {
            if (mail == null)
            {
                return false;
            }

            try
            {
                SmtpClient client = new SmtpClient(Server);
                if (Login != string.Empty && Password != string.Empty)
                {
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(Login, Password);
                }
                else
                {
                    return false;
                }
                client.Port = Port;
                client.EnableSsl = isSSL;
                client.SendCompleted += new SendCompletedEventHandler(completed);
                client.Timeout = 180 * 1000;

                client.SendAsync(mail, null);
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void completed(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Cancelled || e.Error != null)
            {
                
            }

        }

        private MailMessage createMessage()
        {
            if (!this.validate())
            {
                return null;
            }
            MailAddress sender = new MailAddress(From);
            MailMessage message = new MailMessage();
            message.From = sender;
            message.Subject = Subject;
            message.Body = Message;
            message.Priority = MailPriority.Normal;
            message.SubjectEncoding = Encoding.UTF8;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = false;

            foreach (String filename in AttachedFileList)
            {
                Attachment attachement = new Attachment(filename);
                message.Attachments.Add(attachement);
            }


            foreach (String mailAddress in MailList)
            {
                MailAddress address = new MailAddress(mailAddress);
                message.To.Add(address);
            }

            return message;
        }
    }//class
}//ns
