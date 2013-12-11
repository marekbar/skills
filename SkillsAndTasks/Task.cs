using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillsAndTasks
{
    public class Task : Action
    {
        private marekbarEntities db = new marekbarEntities();
        public int Id { get; set; }
        public String TaskName { get; set; }
        public String Description { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatedBy { get; set; }
        public int AssignedTo { get; set; }
        public DateTime ModificationDate { get; set; }
        public int ModifiedBy { get; set; }
        public bool IsFinished { get; set; }
        public String Status { get; set; }

        public bool save()
        {
            try
            {
                Id = db.taskAdd(TaskName, Description, CreationDate, CreatedBy, AssignedTo, ModificationDate, ModifiedBy, IsFinished, Status);
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
                db.taskUpdate(Id, TaskName, Description, CreationDate, CreatedBy, AssignedTo, ModificationDate, ModifiedBy, IsFinished, Status);
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
               db.taskDelete(Id); 
               return true;
           }
           catch
           {
               return false;
           }
        }
    }
}