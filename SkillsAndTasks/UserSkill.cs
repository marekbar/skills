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
                Id = db.addUserSkills(UserId, SkillId);
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
    }
}