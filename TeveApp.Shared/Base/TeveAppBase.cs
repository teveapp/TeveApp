using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeveApp.Shared.Base.Interfaces;

namespace TeveApp.Shared.Base
{
    public class TeveAppBase
    {
        private static TeveAppBase instance;
        private MauiAppBuilder builder;

        public static TeveAppBase Instance
        {
            get
            {
                if (instance == null)
                    instance = new TeveAppBase();

                return instance;
            }
        }

        public MauiAppBuilder Builder
        {
            get
            {
                if (builder == null)
                    builder = MauiApp.CreateBuilder();

                return builder;
            }

            set { builder = value; }
        }

        public void InjectDependencies(IDependencyInjectionBase dependencyInjectionBase)
        {
            dependencyInjectionBase.InjectDependencies();
        }
    }
}
