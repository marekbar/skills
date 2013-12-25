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
    /// Skill - what you know - with description, implements Action methods
    /// <see cref="Action"/>
    /// </summary>
    public class Skill : Action
    {
        /// <summary>
        /// Database entity
        /// </summary>
        private marekbarEntities db = new marekbarEntities();

        /// <summary>
        /// Skill identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Skill name
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Skill description
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Save skill to database
        /// </summary>
        /// <returns>true - saved, false - saving failed</returns>
        public bool save()
        {
            try
            {
                Id = (int)db.skillsAdd(Name, Description).FirstOrDefault().Value;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Skill update
        /// </summary>
        /// <returns>true - updated, false - failure</returns>
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

        /// <summary>
        /// Skill remove
        /// </summary>
        /// <returns>true - removed, false - failure</returns>
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

        /// <summary>
        /// Gets skill list from database
        /// </summary>
        /// <returns>Generic Skill list</returns>
        public static System.Collections.Generic.List<Skill> GetFromDatabaseAll()
        {
            System.Collections.Generic.List<Skill> skills = new System.Collections.Generic.List<Skill>();

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