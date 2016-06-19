using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;
using POCAcademicSystem.Domain.Exceptions;
using POCAcademicSystem.Models;

namespace POCAcademicSystem.Handlers
{
    /// <summary>
    /// Trata os resultados colocando os 
    /// códigos HTTP correspondentes
    /// </summary>
    public class ResultHandler : ActionFilterAttribute
    {
        private IDictionary<Type, HttpStatusCode> ExceptionResponseDictionary { get; set; }
                       

        /// <summary>
        /// Result handler
        /// </summary>
        public ResultHandler()
        {

            ExceptionResponseDictionary = new Dictionary<Type, HttpStatusCode>
                                              {
                                                  {typeof (NotFoundException), HttpStatusCode.NotFound},
                                                  {typeof (EntityValidationException), HttpStatusCode.Forbidden},
                                                  {typeof (ArgumentException), HttpStatusCode.Forbidden},
                                                  {typeof (ArgumentNullException), HttpStatusCode.Forbidden},
                                                  {typeof (ArgumentOutOfRangeException), HttpStatusCode.Forbidden},
                                                  {typeof (FormatException), HttpStatusCode.Forbidden},
                                                  {typeof (DuplicateRecordException), HttpStatusCode.Forbidden},
                                                  {typeof (NotSupportedException), HttpStatusCode.Forbidden},
                                                  {typeof (InvalidCastException), HttpStatusCode.Forbidden},
                                                  {typeof (InvalidOperationException), HttpStatusCode.Forbidden},
                                                  {typeof (TypeLoadException), HttpStatusCode.Forbidden},
                                                  {typeof (InvalidRequestException), HttpStatusCode.BadRequest},
                                                  {typeof (UnauthorizedAccessException), HttpStatusCode.Unauthorized},
                                                  {typeof (NotImplementedException), HttpStatusCode.NotImplemented}
                                              };
        }
                
        /// <summary>
        /// Occurs after the action method is invoked.
        /// </summary>
        /// <param name="actionExecutedContext">The action executed context.</param>
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            var controller = actionExecutedContext.ActionContext.ControllerContext.Controller;

            if (actionExecutedContext.Exception == null)
            {

                if (actionExecutedContext.Response.StatusCode == HttpStatusCode.OK || actionExecutedContext.Response.StatusCode == HttpStatusCode.NoContent)
                {
                    switch (actionExecutedContext.Request.Method.Method)
                    {
                        case "POST":
                            actionExecutedContext.Response.StatusCode = HttpStatusCode.Created;
                            break;

                        case "DELETE":
                            actionExecutedContext.Response.StatusCode = HttpStatusCode.OK;
                            break;

                        case "PUT":
                            actionExecutedContext.Response.StatusCode = HttpStatusCode.Accepted;
                            break;

                        default:
                            actionExecutedContext.Response.StatusCode = HttpStatusCode.OK;
                            break;
                    }
                }
                               
            }
            else
            {
                var exception = actionExecutedContext.Exception;

                var response = new ExceptionResponseModel
                {
                    Message = exception.Message,
                    Type = exception.GetType().FullName
                };

                HttpStatusCode httpStatusCode;

                if (exception is HttpException)
                {
                    var httpException = (HttpException)exception;
                    httpStatusCode = (HttpStatusCode)httpException.GetHttpCode();
                }
                else if (ExceptionResponseDictionary.ContainsKey(exception.GetType()))
                {
                    httpStatusCode = ExceptionResponseDictionary[exception.GetType()];
                }
                else
                {
                    httpStatusCode = HttpStatusCode.InternalServerError;
                }

                if (actionExecutedContext.Response == null)
                {
                    actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(httpStatusCode, response);                    
                }
                else
                {
                    actionExecutedContext.Response.StatusCode = httpStatusCode;
                }

                
            }

            base.OnActionExecuted(actionExecutedContext);
        }
    }
}