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
    [ServiceBehaviorAttribute(IgnoreExtensionDataObject=true)]//as disabled breaks distinct on client side
    public class MBService : IMBService
    {
        marekbarEntities db = new marekbarEntities();

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

        public Response login(String name, String password)
        {
            Response result = new Response();
            var user = new User();
            user.Login = name;
            user.Password = password;
            try
            {
                result.Result = user.CanWork();
                result.Error = "";
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.Error = ex.Message + (ex.InnerException != null ? ex.InnerException.Message : "");
            }
            return result;
        }

        public DatabaseData getDatabase()
        {
            return DatabaseData.Get();
        }

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
                    result.Error = "Zadanie nie zostało dodane.";
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
    }
}
