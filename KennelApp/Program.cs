﻿using System;
using Autofac;
using KennelApp.Config;

namespace KennelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = AFConfig.Configure();

            // Starts the program
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}
