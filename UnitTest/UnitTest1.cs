using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkillsAndTasks;

namespace UnitTest
{
    [TestClass]
    public class TestJednostkowyMaile
    {
        [TestMethod]
        public void MailTest()
        {
            Assert.IsTrue(sendEmail("marekbar1985@gmail.com", "Aktywacja", "Kod dostępu"));
        }

        private bool sendEmail(String email, String title, String message)
        {
            var mail = new Gmail();

            mail.FromName = "Aktywacja";
            mail.From = "skillsandtasks@gmail.com";

            mail.Login = "skillsandtasks";
            mail.Password = "qqlka123!@";

            mail.Message = message;
            mail.Subject = "Akctywacja konta";

            mail.MailAddressName = "Ty";
            mail.MailAddress = email;
            mail.send();

            return true;
        }
    }
}
