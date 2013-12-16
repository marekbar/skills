using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SkillsAndTasks
{
    [DataContract]
    public class Response
    {
        [DataMember]
        public bool Result { get; set; }

        [DataMember]
        public String Error { get; set; }

        [DataMember]
        public bool HasError { get; set; }

        [DataMember]
        public object Data { get; set; }
    }
}