using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeveApp.Shared.Base.Interfaces
{
    public interface IViewModelBase
    {
        void OnAppearing();
        void OnDisappearing();
    }
}
