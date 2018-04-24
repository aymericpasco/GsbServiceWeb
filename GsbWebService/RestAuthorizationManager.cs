using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;

namespace GsbWebService
{
    public class RestAuthorizationManager : ServiceAuthorizationManager
    {

        protected override bool CheckAccessCore(OperationContext operationContext)
        {
            var authHeader = WebOperationContext.Current.IncomingRequest.Headers["Authorization"];

            if ((authHeader != null) && (authHeader != String.Empty))
            {
                var svcCredentials = System.Text.ASCIIEncoding.ASCII
                    .GetString(Convert.FromBase64String(authHeader.Substring(6))).Split(':');

                var user = new { Name = svcCredentials[0], Password = svcCredentials[1] };

                if ((user.Name == "gsb") && (user.Password == "gsb"))
                {
                    return true;
                }
                else
                {
                    WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.Forbidden;
                    return false;
                }
            }
            else
            {
                WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.Forbidden;
                throw new WebFaultException<string>("Unauthorized", HttpStatusCode.Forbidden);
            }

        }
    } 
}