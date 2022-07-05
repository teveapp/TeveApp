using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeveApp.Shared.Base;
using TeveApp.Shared.Base.Interfaces;
using TeveApp.Shared.DependencyInjection;
using TeveApp.View.Interfaces;

namespace TeveApp.View.DependencyInjection
{
    public class InjectViewDependencies : IDependencyInjectionBase
    {
        public void InjectDependencies()
        {
            Resolver.InjectTransient<ILoginView, LoginView>();
        }
    }
}
