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
    public class Service : IService
    {
        marekbarEntities db = new marekbarEntities();


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
