using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GsbWebService
{
    [DataContract]
    public class DoctorEntity
    {
        [DataMember]
        public int? Id { get; set; }

        [DataMember]
        public String FirstName { get; set; }

        [DataMember]
        public String LastName { get; set; }

        [DataMember]
        public String Address { get; set; }

        [DataMember]
        public String Phone { get; set; }

        [DataMember]
        public String Specialty { get; set; }

        [DataMember]
        public int Department { get; set; }

    }
}