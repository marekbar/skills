using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillsAndTasks
{
    public class Skill : Action
    {
        private marekbarEntities db = new marekbarEntities();
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public bool save()
        {
            try
            {
                Id = db.skillsAdd(Name, Description);
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
                db.skillUpdate(Id, Name, Description);
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
               db.skillDelete(Id);
               return true;
           }
           catch
           {
               return false;
           }
        }

        public static List<Skill> GetFromDatabaseAll()
        {
            List<Skill> skills = new List<Skill>();

            try
            {
                marekbarEntities db = new marekbarEntities();

                foreach (var item in db.skillGetAll().ToList())
                {
                    var skill = new Skill();

                    skill.Id = item.id;
                    skill.Description = item.description;
                    skill.Name = item.name;

                    skills.Add(skill);
                }
            }
            catch { }

            return skills;
        }
    }
}