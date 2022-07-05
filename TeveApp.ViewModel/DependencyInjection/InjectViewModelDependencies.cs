using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeveApp.Shared.Base.Interfaces;
using TeveApp.Shared.DependencyInjection;
using TeveApp.ViewModel.Interfaces;

namespace TeveApp.ViewModel.DependencyInjection
{
    public class InjectViewModelDependencies : IDependencyInjectionBase
    {
        public void InjectDependencies()
        {
            Resolver.InjectTransient<ILoginViewModel, LoginViewModel>();
        }
    }
}
