﻿using System;
using System.ServiceModel;

namespace SkillsAndTasks
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehaviorAttribute(IgnoreExtensionDataObject=true)]//as disabled breaks distinct on client side
    public class MBService : IMBService
    {
        /// <summary>
        /// Database Entity
        /// </summary>
        marekbarEntities db = new marekbarEntities();

        /// <summary>
        /// Check if login exists
        /// </summary>
        /// <param name="login">String</param>
        /// <returns>Response</returns>
        public Response loginExists(String login)
        {
            Response result = new Response();
            try
            {
                var hasLogin = new System.Data.Objects.ObjectParameter("result", 0);
                db.userLoginExists(login, hasLogin);
                result.Result = (bool)hasLogin.Value;
                result.Error = "";
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.HasError = true;
                result.Error = ex.Message + (ex.InnerException != null ? ex.InnerException.Message : "");
            }
            return result;
        }

        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="user">User</param>
        /// <returns>Response</returns>
        public Response createAccount(User user)
        {
            Response result = new Response();
            try
            {
                result.Result = user.create();
                if (result.Result)
                {
                    result.Result = true;
                    result.HasError = false;
                    result.Error = "";
                    result.Data = user.Id;
                }
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.HasError = true;
                result.Error = ex.Message + (ex.InnerException != null ? ex.InnerException.Message : "");
                result.Data = -1;
            }
            return result;
        }

        /// <summary>
        /// Activate account by sending code
        /// </summary>
        /// <param name="code">String</param>
        /// <returns>Response</returns>
        public Response activateByCode(String code)
        {
            Response result = new Response();
            try
            {
                var isActivated = new System.Data.Objects.ObjectParameter("result",0);
                db.userAccountActivate(code, isActivated);
                if ((bool)isActivated.Value)
                {
                    result.Result = true;
                    result.HasError = false;
                    result.Error = "";
                }
                else
                {
                    result.Result = true;
                    result.HasError = true;
                    result.Error = "Konto nie zostało aktywowane.";
                }
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Result = false;
                result.Error = ex.Message + (ex.InnerException != null ? ex.InnerException.Message : "");
            }
            return result;
        }

        /// <summary>
        /// Check if user is allowed to use web service
        /// </summary>
        /// <param name="name">String - login</param>
        /// <param name="password">String - password</param>
        /// <returns>Response</returns>
        public Response login(String name, String password)
        {
            Response result = new Response();
            var user = new User();
            user.Login = name;
            user.Password = password;
            try
            {
                result.Result = user.CanWork();
                result.HasError = !result.Result;
                if (result.Result == false)
                {
                    throw new Exception("Nie można zalogować użytkownika: " + name);
                }
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.HasError = true;
                result.Error = ex.Message + (ex.InnerException != null ? ex.InnerException.Message : "");
            }
            return result;
        }

        /// <summary>
        /// Gets database data to sync
        /// </summary>
        /// <returns>DatabaseData</returns>
        public DatabaseData getDatabase()
        {
            return DatabaseData.Get();
        }

        /// <summary>
        /// Create new skill
        /// </summary>
        /// <param name="skill">Skill</param>
        /// <returns>Response</returns>
        public Response createSkill(Skill skill)
        {
            Response result = new Response();

            try
            {
                if (skill.save())
                {
                    result.Result = true;
                    result.HasError = false;
                    result.Error = "";
                    result.Data = skill.Id;
                }
                else
                {
                    result.Result = true;
                    result.HasError = true;
                    result.Error = "Umiejętność nie została dodana.";
                    result.Data = -1;
                }
            }
            catch(Exception ex)
            {
                result.Result = false;
                result.HasError = true;
                result.Error = ex.Message + (ex.InnerException == null ? "" : " " + ex.InnerException.Message);
                result.Data = -1;
            }

            return result;
        }


        /// <summary>
        /// Create new task
        /// </summary>
        /// <param name="task">Task</param>
        /// <returns>Response</returns>
        public Response createTask(Task task)
        {
            Response result = new Response();
            try
            {
                if (task.save())
                {
                    result.Result = true;
                    result.HasError = false;
                    result.Error = "";
                    result.Data = task.Id;
                }
                else
                {
                    result.Result = true;
                    result.HasError = true;
                    result.Error = "Zadanie nie zostało utworzone.";
                    result.Data = -1;
                }
            }
            catch(Exception ex)
            {
                result.Result = false;
                result.HasError = true;
                result.Error = ex.Message + ex.InnerException != null ? ex.InnerException.Message : "";
                result.Data = -1;
            }

            return result;
        }
        
        /// <summary>
        /// Create new association user - skill
        /// </summary>
        /// <param name="us">UserSkill</param>
        /// <returns>Response</returns>
        public Response createUserSkill(UserSkill us)
        {
            Response result = new Response();

            try
            {
                if (us.save())
                {
                    result.Result = true;
                    result.HasError = false;
                    result.Error = "";
                    result.Data = us.Id;
                }
                else
                {
                    result.Result = true;
                    result.HasError = true;
                    result.Error = "Umiejętność nie została powiązana z użytkownikiem.";
                    result.Data = -1;
                }
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.HasError = true;
                result.Error = ex.Message + (ex.InnerException == null ? "" : " " + ex.InnerException.Message);
                result.Data = -1;
            }

            return result;
        }

        /// <summary>
        /// Remove skill
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>Response</returns>
        public Response deleteSkill(int id)
        {
            Response result = new Response();
            try
            {
                db.skillDelete(id);
                result.Result = true;
                result.HasError = false;
                result.Error = "";
                result.Data = id;
            }
            catch (Exception ex) 
            {
                result.Result = false;
                result.HasError = true;
                result.Error = ex.Message + (ex.InnerException == null ? "" : " " + ex.InnerException.Message);
                result.Data = -1;
            }
            return result;
        }

        /// <summary>
        /// Modify skil
        /// </summary>
        /// <param name="skill">Skill</param>
        /// <returns>Response</returns>
        public Response updateSkill(Skill skill)
        {
            Response result = new Response();
            try
            {
                db.skillUpdate(skill.Id, skill.Name, skill.Description);
                result.Result = true;
                result.HasError = false;
                result.Error = "";
                result.Data = skill.Id;//zwracanie obiektu rozwala klienta - błąd 502 Bad Gateway
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.HasError = true;
                result.Error = ex.Message + (ex.InnerException == null ? "" : " " + ex.InnerException.Message);
                result.Data = -1;
            }
            return result;
        }

        /// <summary>
        /// Delete task
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>Response</returns>
        public Response deleteTask(int id)
        {
            Response result = new Response();
            try
            {
                db.taskDelete(id);
                result.Result = true;
                result.HasError = false;
                result.Error = "";
                result.Data = id;
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.HasError = true;
                result.Error = ex.Message + (ex.InnerException == null ? "" : " " + ex.InnerException.Message);
                result.Data = -1;
            }
            return result;
        }

        /// <summary>
        /// Modify task
        /// </summary>
        /// <param name="task">Task</param>
        /// <returns>Response</returns>
        public Response updateTask(Task task)
        {
            Response result = new Response();
            try
            {
                db.taskUpdate(task.Id, task.TaskName, task.Description, task.CreationDate, task.CreatedBy, task.AssignedTo, task.ModificationDate, task.ModifiedBy, task.IsFinished, task.Status);
                result.Result = true;
                result.HasError = false;
                result.Error = "";
                result.Data = task.Id;//zwracanie obiektu rozwala klienta - błąd 502 Bad Gateway, a ja nie potrzebuję obiektu z powrotem, bo po co
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.HasError = true;
                result.Error = ex.Message + (ex.InnerException == null ? "" : " " + ex.InnerException.Message);
                result.Data = -1;
            }
            return result;
        }

        /// <summary>
        /// Delete association user - skill
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>Response</returns>
        public Response deleteUserSkill(int id)
        {
            Response result = new Response();
            try
            {
                db.delUserSkills(id);
                result.Result = true;
                result.HasError = false;
                result.Error = "";
                result.Data = id;
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.HasError = true;
                result.Error = ex.Message + (ex.InnerException == null ? "" : " " + ex.InnerException.Message);
                result.Data = -1;
            }
            return result;
        }

        /// <summary>
        /// Modify association user - skill
        /// </summary>
        /// <param name="us">UserSkill</param>
        /// <returns>Response</returns>
        public Response updateUserSkill(UserSkill us)
        {
            Response result = new Response();
            try
            {
                db.modUserSkills(us.Id, us.UserId, us.SkillId);
                result.Result = true;
                result.HasError = false;
                result.Error = "";
                result.Data = us.Id;//zwracanie obiektu rozwala klienta - błąd 502 Bad Gateway
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.HasError = true;
                result.Error = ex.Message + (ex.InnerException == null ? "" : " " + ex.InnerException.Message);
                result.Data = -1;
            }
            return result;
        }
    }
}
