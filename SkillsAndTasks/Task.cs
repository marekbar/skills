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

        public static List<Task> GetFromDatabaseAll()
        {
            List<Task> tasks = new List<Task>();
            try
            {
                marekbarEntities db = new marekbarEntities();
                foreach (var item in db.taskGetAll().ToList())
                {
                    var task = new Task();

                    task.Id = item.id;
                    task.TaskName = item.task;
                    task.Description = item.description;
                    task.AssignedTo = (int)item.assigned_to_user;
                    task.CreatedBy = item.created_by;
                    task.CreationDate = item.creation_date;
                    task.IsFinished = item.is_finished;
                    task.ModificationDate = (DateTime)item.modification_date;
                    task.ModifiedBy = (int)item.modified_by;
                    task.Status = item.status;
                   
                    tasks.Add(task);
                }
            }
            catch { }
            return tasks;
        }
    }
}