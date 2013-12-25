/*
 * Skills and tasks project
 * Author: Marek Bar 33808
 * Wyższa Szkoła Inforatyki i Zarządzania w Rzeszowie
 * marekbar1985@gmail.com
 */
namespace SkillsAndTasks
{
    /// <summary>
    /// Activating user account
    /// </summary>
    public class ActivateAccount
    {
        /// <summary>
        /// User object - user which will be activated or not
        /// </summary>
        private User user = null;

        /// <summary>
        /// Activation code
        /// </summary>
        private System.String code = "";

        /// <summary>
        /// Activate user account constructor
        /// </summary>
        /// <param name="user">User - who</param>
        /// <param name="code">String - activation code</param>
        public ActivateAccount(User user, System.String code)
        {
            this.user = user;
            this.code = code;
        }

        /// <summary>
        /// Send activation code to mail
        /// </summary>
        /// <returns>true - activation code sent, false - activation code not send</returns>
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
                System.Text.StringBuilder b = new System.Text.StringBuilder();
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