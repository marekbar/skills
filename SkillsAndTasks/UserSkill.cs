using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillsAndTasks
{
    public class UserSkill : Action
    {
        private marekbarEntities db = new marekbarEntities();
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SkillId { get; set; }

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

        public static List<UserSkill> GetFromDatabaseAll()
        {
            List<UserSkill> userSkills = new List<UserSkill>();

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