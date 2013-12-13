using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SkillsAndTasks
{
    public class ActivateAccount
    {
        private User user = null;
        private String code = "";
        public ActivateAccount(User user, String code)
        {
            this.user = user;
            this.code = code;
        }

        public bool sendCode()
        {
            try
            {
                Gmail mail = new Gmail();
                mail.Login = "skillsandtasks";
                mail.Password = "qqlka123!@";
                mail.Subject = "Aktywacja konta w aplikacji Umiejętności i zadania";
                mail.MailAddress = user.Mail;
                mail.MailAddressName = user.Name + " " + user.Surname + " (" + user.Login + ")";
                mail.From = "skillsandtasks@gmail.com";
                mail.FromName = "Umiejętności i zadania";
                StringBuilder b = new StringBuilder();
                b.Append("Witaj, " + user.Name + " " + user.Surname);
                b.AppendLine();
                b.Append("Twój kod aktywacji konta w aplikacji Umiejętności i zadania to:");
                b.AppendLine();
                b.AppendLine();
                b.Append(code);
                b.AppendLine();
                b.AppendLine();
                b.Append("Miłego użytkowania -:)");

                mail.Message += b.ToString();

                mail.send();
                return true;
            }
            catch
            {
                return false;
            }
        }

       
    }
}