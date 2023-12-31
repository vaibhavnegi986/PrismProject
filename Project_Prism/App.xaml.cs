﻿using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using Project_Prism_Modules;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Project_Prism
{ 
    /// <summary>

    /// Interaction logic for App.xaml TEst 2.0

    // Hello World 123

    /// </summary>
    public partial class App : PrismApplication
    {
       
        protected override Window CreateShell()
        {
            return Container.Resolve<AppShell>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<StartupModule>();
        }
    }
}
