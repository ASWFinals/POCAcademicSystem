using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Filters;

namespace POCAcademicSystem.Handlers
{
    public class AuthHandler : ActionFilterAttribute
    {
        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            try
            {
               
                var auth = actionContext.Request.Headers.Authorization;

                if (auth.Scheme.Equals("Token"))
                {
                    var token = Guid.Parse(auth.Parameter);
                    var valid = token.Equals(new Guid("93e9a191-529b-4c72-8fab-ebd9ba9061c9"));

                    if (!valid)
                    {
                        throw new Exception("Unathorized - " + auth.Parameter);
                    }
                    
                }

                if (auth.Scheme.Equals("Basic"))
                {
                    var param = Convert.FromBase64String(auth.Parameter);//cG9jdXNlcnVpOnBvY3B3ZHVp

                    var auths = Encoding.UTF8.GetString(param).Split(':');
                    var valid = auths[0].Equals("pocuserui") && auths[1].Equals("pocpwdui");
                    if (!valid)
                    {
                        throw new Exception("Unathorized - " + auth.Parameter);
                    }
                    
                }
            }
            catch
            {
                actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }

            base.OnActionExecuting(actionContext);
        }
    }
}