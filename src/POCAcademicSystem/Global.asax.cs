using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using POCAcademicSystem.Core.Engine;
using POCAcademicSystem.Domain.Engine;
using POCAcademicSystem.EntityFramework;
using POCAcademicSystem.EntityFramework.Repository;
using POCAcademicSystem.Persistence;
using POCAcademicSystem.Persistence.Repository;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;

namespace POCAcademicSystem
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Create the container as usual.
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            //singleton
            container.Register<IServiceProvider>(() => container, Lifestyle.Singleton);

            // Register your types, for instance using the scoped lifestyle:
            //LifeScope
            container.Register<IPOCAcademicContext>(() => new POCAcademicContext(container.GetInstance<IServiceProvider>()), Lifestyle.Scoped);
            container.Register<DbContext>(() => container.GetInstance<IPOCAcademicContext>() as DbContext, Lifestyle.Scoped);
            container.Register<IStudentEngine, StudentEngine>(Lifestyle.Scoped);

            //register repository
            container.Register<IStudentRepository, StudentRepository>(Lifestyle.Scoped);
            container.Register<IEnrollmentRepository, EnrollmentRepository>(Lifestyle.Scoped);
            container.Register<ICourseRepository, CourseRepository>(Lifestyle.Scoped);
            //var repositoryAssembly = typeof(StudentRepository).Assembly;

            //Register all repository
            //var registrations =
            //    from type in repositoryAssembly.GetExportedTypes()
            //    where type.Namespace == "POCAcademicSystem.EntityFramework"
            //    where type.GetInterfaces().Any()
            //    select new
            //    {
            //        Service = type.GetInterfaces().FirstOrDefault(i => i.Name.EndsWith("Repository")),
            //        Implementation = type
            //    };

            //foreach (var reg in registrations.Where(r => r.Service != null))
            //{
            //    container.Register(reg.Service, reg.Implementation, Lifestyle.Scoped);
            //}

            
            // This is an extension method from the integration package.
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            //GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            //GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);  

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);


            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
