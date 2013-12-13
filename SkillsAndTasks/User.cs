using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillsAndTasks
{
    public class User : Action
    {
        private marekbarEntities db = new marekbarEntities();

        public int Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public String Town { get; set; }
        public String Mail { get; set; }
        public String Phone { get; set; }

        private String code = "";
        public String GetCode()
        {
            return code;
        }

        public bool save()
        {
            try
            {
                code = getCode();
                Id = db.userAdd(Name, Surname, Login, Password, Town, Mail, Phone, code);
                
                var activation = new ActivateAccount(this, code);
                if (!activation.sendCode()) throw new Exception("Kod aktywacyjny nie został wysłany. Skontaktuj się z marekbar1985@gmail.com");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool update()
        {
            try
            {
                db.userUpdate(Id, Name, Surname, Login, Password, Town, Mail, Phone);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delete()
        {
            try
            {
                db.userDelete(Id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool create()
        {
            return save();
        }

        public bool CanWork()
        {
            try
            {
                return db.checkUser(Login, Password) == 1;     
            }
            catch
            {
                return false;
            }
        }

        private String getCode()
        {
            RandomStringGenerator.RandomStringGenerator rsg = new RandomStringGenerator.RandomStringGenerator();
            return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + rsg.Generate(10) + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
        }
    }
}