using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SkillsAndTasks
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MBService : IMBService
    {
        marekbarEntities db = new marekbarEntities();

        public Response loginExists(String login)
        {
            Response result = new Response();
            try
            {
                var hasLogin = new System.Data.Objects.ObjectParameter("result", 0);
                db.userLoginExists(login, hasLogin);
                result.Result = (bool)hasLogin.Value;
                result.Error = "";
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.HasError = true;
                result.Error = ex.Message + (ex.InnerException != null ? ex.InnerException.Message : "");
            }
            return result;
        }

        public Response createAccount(User user)
        {
            Response result = new Response();
            try
            {
                result.Result = user.create();
                if (result.Result)
                {
                    String code = getCode(user.Id);
                    db.userSetCode(user.Id, code);
                    sendEmail(user.Mail, "Aktywacja konta w aplikacji Umiejętności i zadania",
                        @"
                            Witaj, " + user.Name + " " + user.Surname + @"

                            Otrzymujesz tego maila, w celu aktywacji konta w aplikacji Umiejętności i zadania.

                            Twój kod:" + code + @"

                            Jeśli masz pytania: marekbar1985@gmail.com
                        ");
                }
                result.Error = "";
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.Error = ex.Message + (ex.InnerException != null ? ex.InnerException.Message : "");
            }
            return result;
        }

        private String getCode(int userId)
        {
            RandomStringGenerator.RandomStringGenerator rsg = new RandomStringGenerator.RandomStringGenerator();
            return rsg.Generate(10) + userId.ToString();
        }

        private bool sendEmail(String email, String title, String message)
        {
            var mail = new Mail();
            mail.MailList.Add(email);
            mail.Server = "smtp.gmail.com";
            mail.From = "skillsandtasks@gmail.com";
            mail.isEnabled = true;
            mail.isSSL = true;
            mail.Port = 465;
            mail.Login = "skillsandtasks";
            mail.Password = "qqlka123!@";
            mail.Message = message;
            return mail.send(message, title);
        }

        public Response login(String name, String password)
        {
            Response result = new Response();
            var user = new User();
            user.Login = name;
            user.Password = password;
            try
            {
                result.Result = user.CanWork();
                result.Error = "";
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.Error = ex.Message + (ex.InnerException != null ? ex.InnerException.Message : "");
            }
            return result;
        }

        public List<Skill> getSkills()
        {
            List<Skill> skills = new List<Skill>();

            return skills;
        }

        public List<Task> getTasks()
        {
            List<Task> tasks = new List<Task>();

            return tasks;
        }

        public List<User> getUsers()
        {
            List<User> users = new List<User>();

            return users;
        }

        public List<UserSkill> getUserSkills()
        {
            List<UserSkill> us = new List<UserSkill>();
            
            return us;
        }

        public DatabaseData getDatabase()
        {
            return new DatabaseData();
        }

        public Response sendLocalDatabase(DatabaseData db)
        {
            Response r = new Response();

            return r;
        }
    }
}
