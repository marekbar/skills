using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SkillsAndTasks
{
    [DataContract]
    public class DatabaseData
    {
        [DataMember]
        public List<User> Users { get; set; }

        [DataMember]
        public List<Skill> Skills { get; set; }

        [DataMember]
        public List<Task> Tasks { get; set; }

        [DataMember]
        public List<UserSkill> UserSkills { get; set; }

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