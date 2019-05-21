using Autofac;
using Autofac.Integration.WebApi;
using Swashbuckle.Application;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SalaryCalculator.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Swagger configuration registration
            SwaggerConfig.Register(config);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "Swagger UI",
                routeTemplate: "",
                defaults: null,
                constraints: null,
                handler: new RedirectHandler(SwaggerDocsConfig.DefaultRootUrlResolver, "swagger/ui/index")
            );

            //Map the route for the parameterless format api call. 
            config.Routes.MapHttpRoute(
                name: "ParameterlessFormatApi",
                routeTemplate: "{controller}/{action}"
            );

            var cors = new EnableCorsAttribute("*", "*", "*")
            { SupportsCredentials = true };
            config.EnableCors(cors);

            // Autofac configuration
            var builder = new ContainerBuilder();
            AutofacRegister(builder);

            IContainer container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static void AutofacRegister(ContainerBuilder builder)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            //Register anything that inherits ApiController with IoC Container
            builder.RegisterApiControllers(assemblies);

            //Register Database Contexts with IoC Container
            builder.RegisterAssemblyTypes(assemblies)
                .Where(x => x.Name.EndsWith("Context"))
                .InstancePerRequest();

            //Register Repositores with IoC Container
            builder.RegisterAssemblyTypes(assemblies)
                .Where(x => x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerRequest();

            //Register Services with IoC Container
            builder.RegisterAssemblyTypes(assemblies)
                .Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerRequest();
        }
    }
}
