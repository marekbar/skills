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
    /// UserSkill - connection between User and Skill
    /// </summary>
    /// <see cref="User"/>
    /// <see cref="Skill"/>
    public class UserSkill : Action
    {
        /// <summary>
        /// Database entity
        /// </summary>
        private marekbarEntities db = new marekbarEntities();

        /// <summary>
        /// User - Skill connection identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        /// <see cref="User"/>
        public int UserId { get; set; }

        /// <summary>
        /// Skill identifier
        /// </summary>
        /// <see cref="Skill"/>
        public int SkillId { get; set; }

        /// <summary>
        /// Save user - skill connection
        /// </summary>
        /// <returns>boolean</returns>
        public bool save()
        {
            try
            {
                Id = (int)db.addUserSkills(UserId, SkillId).FirstOrDefault().Value;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Update  user - skill connection
        /// </summary>
        /// <returns>boolean</returns>
        public bool update()
        {
            try
            {
                db.modUserSkills(Id, UserId, SkillId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Delete  user - skill connection
        /// </summary>
        /// <returns>boolean</returns>
        public bool delete()
        {
            try
            {
                db.delUserSkills(Id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Gets  user - skill connection list
        /// </summary>
        /// <returns>Generic UserSkill list</returns>
        public static System.Collections.Generic.List<UserSkill> GetFromDatabaseAll()
        {
            System.Collections.Generic.List<UserSkill> userSkills = new System.Collections.Generic.List<UserSkill>();

            try 
            {
                marekbarEntities db = new marekbarEntities();

                foreach (var item in db.userSkillsGetAll().ToList())
                {
                    var us = new UserSkill();
                    us.Id = item.id;
                    us.UserId = item.user_id;
                    us.SkillId = item.skill_id;
                    userSkills.Add(us);
                }
                
            }
            catch { }

            return userSkills;
        }
    }
}