using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeveApp.Shared.Base.Interfaces;
using TeveApp.View.Interfaces;

namespace TeveApp.View.Base
{
    public class ViewBase : ContentPage, IViewContext
    {
        public ViewBase()
        {
        }

        public void SetBinding(IViewModelBase viewModelBase)
        {
            BindingContext = viewModelBase;
        }

        protected override void OnAppearing()
        {
            ((IViewModelBase)BindingContext).OnAppearing();
        }

        protected override void OnDisappearing()
        {
            ((IViewModelBase)BindingContext).OnDisappearing();
        }
    }
}
