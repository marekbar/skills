/*
 * Skills and tasks project
 * Author: Marek Bar 33808
 * Wyższa Szkoła Inforatyki i Zarządzania w Rzeszowie
 * marekbar1985@gmail.com
 */
namespace SkillsAndTasks
{
    /// <summary>
    /// Database data for remote user who want to syncronize its local xml database
    /// </summary>
    [System.Runtime.Serialization.DataContract]
    public class DatabaseData
    {
        /// <summary>
        /// User list
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public System.Collections.Generic.List<User> Users { get; set; }

        /// <summary>
        /// Skill list
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public System.Collections.Generic.List<Skill> Skills { get; set; }

        /// <summary>
        /// Tasks list
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public System.Collections.Generic.List<Task> Tasks { get; set; }

        /// <summary>
        /// UserSkill list
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public System.Collections.Generic.List<UserSkill> UserSkills { get; set; }

        /// <summary>
        /// Gets DatabaseData which contains generic lists of: users, skills, tasks and user skills
        /// </summary>
        /// <returns>DatabaseData</returns>
        public static DatabaseData Get()
        {
            DatabaseData db = new DatabaseData();
            db.Users = User.GetFromDatabaseAll();
            db.Tasks = Task.GetFromDatabaseAll();
            db.Skills = Skill.GetFromDatabaseAll();
            db.UserSkills = UserSkill.GetFromDatabaseAll();
            return db;
        }
    }
}