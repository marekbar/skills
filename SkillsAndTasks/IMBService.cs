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
        Response loginExists(String name);


        [OperationContract]
        Response login(String name, String password);

        [OperationContract]
        List<Skill> getSkills();

        [OperationContract]
        List<Task> getTasks();

        [OperationContract]
        List<User> getUsers();

        [OperationContract]
        List<UserSkill> getUserSkills();

        [OperationContract]
        DatabaseData getDatabase();

        [OperationContract]
        Response sendLocalDatabase(DatabaseData db);
    }

    [DataContract]
    public class DatabaseData
    {
        [DataMember]
        public List<User> Users { get; set; }

        [DataMember]
        public List<Skill> Skills { get; set; }

        [DataMember]
        public List<Task> Tasks { get; set; }

        [DataMember]
        public List<UserSkill> UserSkills { get; set; }
    }

    [DataContract]
    public class Response
    {
        [DataMember]
        public bool Result { get; set; }

        [DataMember]
        public String Error { get; set; }

        [DataMember]
        public bool HasError { get; set; }
    }
}
