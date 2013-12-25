/*
 * Skills and tasks project
 * Author: Marek Bar 33808
 * Wyższa Szkoła Inforatyki i Zarządzania w Rzeszowie
 * marekbar1985@gmail.com
 */
using System.Linq;

namespace SkillsAndTasks
{
    /// <summary>
    /// User, implements Action
    /// </summary>
    public class User : Action
    {
        /// <summary>
        /// Database entity
        /// </summary>
        private marekbarEntities db = new marekbarEntities();

        /// <summary>
        /// User identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User first name
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// User last name
        /// </summary>
        public System.String Surname { get; set; }

        /// <summary>
        /// User login
        /// </summary>
        public System.String Login { get; set; }

        /// <summary>
        /// User password
        /// </summary>
        public System.String Password { get; set; }

        /// <summary>
        /// User town
        /// </summary>
        public System.String Town { get; set; }

        /// <summary>
        /// User mail
        /// </summary>
        public System.String Mail { get; set; }

        /// <summary>
        /// Use phone
        /// </summary>
        public System.String Phone { get; set; }

        /// <summary>
        /// User activation code
        /// </summary>
        private System.String code = "";

        /// <summary>
        /// Gets account activation code
        /// </summary>
        /// <returns></returns>
        public System.String GetCode()
        {
            return code;
        }

        /// <summary>
        /// Save User
        /// </summary>
        /// <returns>true - saved, false - failure</returns>
        public bool save()
        {
            try
            {
                code = getCode();
                Id = db.userAdd(Name, Surname, Login, Password, Town, Mail, Phone, code);
                
                var activation = new ActivateAccount(this, code);
                if (!activation.sendCode()) throw new System.Exception("Kod aktywacyjny nie został wysłany. Skontaktuj się z marekbar1985@gmail.com");
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Update user data
        /// </summary>
        /// <returns>true - user updated, false - failure</returns>
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

        /// <summary>
        /// Delete user
        /// </summary>
        /// <returns>true - user removed, false - user removal failure</returns>
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

        /// <summary>
        /// Create new user
        /// </summary>
        /// <returns>true - user created, false - failure</returns>
        public bool create()
        {
            return save();
        }

        /// <summary>
        /// Check if user is activated and can work
        /// </summary>
        /// <returns>true - all fine, work, false - disabled</returns>
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

        /// <summary>
        /// Generate user activation code
        /// </summary>
        /// <returns>String - activation code</returns>
        private System.String getCode()
        {
            var n = System.DateTime.Now;
            RandomStringGenerator.RandomStringGenerator rsg = new RandomStringGenerator.RandomStringGenerator();
            return n.Year.ToString() + n.Month.ToString() + n.Day.ToString() + rsg.Generate(10) + n.Hour.ToString() + n.Minute.ToString() + n.Second.ToString();
        }

        /// <summary>
        /// Get user list
        /// </summary>
        /// <returns>Generic User list</returns>
        public static System.Collections.Generic.List<User> GetFromDatabaseAll()
        {
            System.Collections.Generic.List<User> users = new System.Collections.Generic.List<User>();
            try
            {
                marekbarEntities db = new marekbarEntities();

                foreach (var item in db.userGetAll().ToList())
                {
                    var user = new User();
                    user.Name = item.name;
                    user.Surname = item.surname;
                    user.Id = item.id;
                    user.Login = item.login;
                    user.Password = "";
                    user.Phone = item.phone;
                    user.Mail = item.mail;
                    user.Town = item.town;
                    users.Add(user);
                }
            }
            catch { }
            return users;
        }
    }
}