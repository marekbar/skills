/*
 * Skills and tasks project
 * Author: Marek Bar 33808
 * Wyższa Szkoła Inforatyki i Zarządzania w Rzeszowie
 * marekbar1985@gmail.com
 */
namespace SkillsAndTasks
{
    /// <summary>
    /// Response from web service - used for better connnnntrl of what's going on
    /// </summary>
    [System.Runtime.Serialization.DataContract]
    public class Response
    {
        /// <summary>
        /// Web service method call general result
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public bool Result { get; set; }

        /// <summary>
        /// Web service method call errors
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public System.String Error { get; set; }

        /// <summary>
        /// Web service method call internal method error occurance
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public bool HasError { get; set; }

        /// <summary>
        /// Web service method result data object
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public object Data { get; set; }
    }
}