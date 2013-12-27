/*
 * Skills and tasks project
 * Author: Marek Bar 33808
 * Wyższa Szkoła Inforatyki i Zarządzania w Rzeszowie
 * marekbar1985@gmail.com
 */
namespace SkillsAndTasks
{
    /// <summary>
    /// Web service interface - methods that will be implemented within and public visible
    /// </summary>
    [System.ServiceModel.ServiceContract]
    public interface IMBService
    {
        /// <summary>
        /// Create user account
        /// </summary>
        /// <param name="user">User - user asking for enrollment to the system</param>
        /// <see cref="Response"/>
        /// <see cref="User"/>
        /// <returns>Response</returns>
        [System.ServiceModel.OperationContract]
        Response createAccount(User user);

        /// <summary>
        /// Create skill
        /// </summary>
        /// <param name="skill">Skill - skill from user</param>
        /// <see cref="Skill"/>
        /// <see cref="Response"/>
        /// <returns>Response</returns>
        [System.ServiceModel.OperationContract]
        Response createSkill(Skill skill);

        /// <summary>
        /// Deletes skill
        /// </summary>
        /// <param name="id">skill id</param>
        /// <returns>Response</returns>
        [System.ServiceModel.OperationContract]
        Response deleteSkill(int id);

        /// <summary>
        /// Update skill
        /// </summary>
        /// <param name="skill">Skill</param>
        /// <returns>Response</returns>
        [System.ServiceModel.OperationContract]
        Response updateSkill(Skill skill);

        /// <summary>
        /// Create task
        /// </summary>
        /// <param name="task">Task - task from user</param>
        /// <see cref="Task"/>
        /// <see cref="Response"/>
        /// <returns>Response</returns>
        [System.ServiceModel.OperationContract]
        Response createTask(Task task);

        /// <summary>
        /// Deletes task
        /// </summary>
        /// <param name="id">int - task id</param>
        /// <returns>Response</returns>
        [System.ServiceModel.OperationContract]
        Response deleteTask(int id);

        /// <summary>
        /// Updates task
        /// </summary>
        /// <param name="task">Task</param>
        /// <returns>Response</returns>
        [System.ServiceModel.OperationContract]
        Response updateTask(Task task);

        /// <summary>
        /// UserSkill - create new association user with skill
        /// </summary>
        /// <param name="us">UserSkill - user skill</param>
        /// <see cref="UserSkill"/>
        /// <see cref="Response"/>
        /// <returns>Response</returns>
        [System.ServiceModel.OperationContract]
        Response createUserSkill(UserSkill us);

        /// <summary>
        /// Deletes user - skill connections
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>Response</returns>
        [System.ServiceModel.OperationContract]
        Response deleteUserSkill(int id);

        /// <summary>
        /// Updates user - skill connection
        /// </summary>
        /// <param name="us">UserSkill</param>
        /// <returns>Response</returns>
        [System.ServiceModel.OperationContract]
        Response updateUserSkill(UserSkill us);

        /// <summary>
        /// Check if login exists
        /// </summary>
        /// <param name="name">String - login name</param>
        /// <see cref="Response"/>
        /// <returns>Response</returns>
        [System.ServiceModel.OperationContract]
        Response loginExists(System.String name);

        /// <summary>
        /// Activate user by code from mail
        /// </summary>
        /// <param name="code">String- code from e-mail</param>
        /// <see cref="Response"/>
        /// <returns>Response</returns>
        [System.ServiceModel.OperationContract]
        Response activateByCode(System.String code);

        /// <summary>
        /// Login to system
        /// </summary>
        /// <param name="name">String - login</param>
        /// <param name="password">string - password</param>
        /// <see cref="Response"/>
        /// <returns>Response</returns>
        [System.ServiceModel.OperationContract]
        Response login(System.String name, System.String password);

        /// <summary>
        /// Gets data for local sync
        /// </summary>
        /// <see cref="DatabaseData"/>
        /// <returns>DatabaseData</returns>
        [System.ServiceModel.OperationContract]
        DatabaseData getDatabase();
    }
}
