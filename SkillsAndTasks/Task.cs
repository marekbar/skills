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
    /// Task - task for user: done/undone, implements Action
    /// </summary>
    /// <see cref="Action"/>
    public class Task : Action
    {
        /// <summary>
        /// Database entity
        /// </summary>
        private marekbarEntities db = new marekbarEntities();

        /// <summary>
        /// Task identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Task name
        /// </summary>
        public System.String TaskName { get; set; }

        /// <summary>
        /// Task description
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Task creation date
        /// </summary>
        public System.DateTime CreationDate { get; set; }

        /// <summary>
        /// Task created by User - user id
        /// </summary>
        /// <see cref="User"/>
        public int CreatedBy { get; set; }

        /// <summary>
        /// Task assigned to User - user id
        /// </summary>
        /// <see cref="User"/>
        public int AssignedTo { get; set; }

        /// <summary>
        /// Task modification date
        /// </summary>
        public System.DateTime ModificationDate { get; set; }

        /// <summary>
        /// Task modified by User - user id
        /// </summary>
        /// <see cref="User"/>
        public int ModifiedBy { get; set; }

        /// <summary>
        /// Determinates if task is closed or not
        /// </summary>
        public bool IsFinished { get; set; }

        /// <summary>
        /// Task status - user choice
        /// </summary>
        public System.String Status { get; set; }


        /// <summary>
        /// Save task
        /// </summary>
        /// <returns>true - task saved, false - task saving failed</returns>
        public bool save()
        {
            try
            {
                var ret = db.taskAdd(TaskName, Description, CreationDate, CreatedBy, AssignedTo, ModificationDate, ModifiedBy, IsFinished, Status).FirstOrDefault().Value;
                this.Id = (int)ret;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Update task
        /// </summary>
        /// <returns>true - task updated, false - update failure</returns>
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

        /// <summary>
        /// Task delete
        /// </summary>
        /// <returns>true - task removed, false - task removal failure</returns>
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

        /// <summary>
        /// Gets task list
        /// </summary>
        /// <returns>Generic Task list</returns>
        public static System.Collections.Generic.List<Task> GetFromDatabaseAll()
        {
            System.Collections.Generic.List<Task> tasks = new System.Collections.Generic.List<Task>();
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
                    task.ModificationDate = (System.DateTime)item.modification_date;
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