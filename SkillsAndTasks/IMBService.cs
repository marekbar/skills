using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SkillsAndTasks
{
    [ServiceContract]
    public interface IMBService
    {
        [OperationContract]
        Response createAccount(User user);

        [OperationContract]
        Response createSkill(Skill skill);

        [OperationContract]
        int createTask(Task task);

        [OperationContract]
        Response createUserSkill(UserSkill us);

        [OperationContract]
        Response loginExists(String name);

        [OperationContract]
        Response activateByCode(String code);

        [OperationContract]
        Response login(String name, String password);

        [OperationContract]
        DatabaseData getDatabase();
    }
}
