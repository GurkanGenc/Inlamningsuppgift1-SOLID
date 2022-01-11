using Autofac;
using KennelApp.Models;
using System.Linq;
using System.Reflection;

namespace KennelApp
{
    internal class AFConfig
    {
        internal static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register the main application
            builder.RegisterType<Application>().As<IApplication>();

            // Register the rest of the service
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(n => n.Namespace.Contains("Menu")) // "Menu" here is the folder's name that contains all the menu classes.
                .As(n => n.GetInterfaces() // Self-explanatory
                .FirstOrDefault(x => x.Name == "I" + n.Name)) // Gets the first same name with the "Menu" with an "I".
                .AsImplementedInterfaces();

            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //   .Where(n => n.Namespace.Contains("Models")) // "Models" here is the folder's name that contains all the menu classes.
            //   .As(n => n.GetInterfaces() // Self-explanatory
            //   .FirstOrDefault(x => x.Name == "I" + n.Name)) // Gets the first same name with the "Models" with an "I".
            //   .AsImplementedInterfaces();

            // Return the builder
            return builder.Build();
        }
    }
}