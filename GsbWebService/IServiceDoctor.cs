using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GsbWebService
{
    [ServiceContract]
    public interface IServiceDoctor
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "ConsultAllDoctors")]
        IList<DoctorEntity> ConsultAllDoctors();

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "ConsultDoctorsByDepartment?dep={department}")]
        IList<DoctorEntity> ConsultDoctorsByDepartment(int department);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "ConsultDoctorsByLastname?name={lastname}")]
        IList<DoctorEntity> ConsultDoctorsByLastname(String lastname);
    }
}
