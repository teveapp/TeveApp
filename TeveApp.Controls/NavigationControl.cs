using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeveApp.Shared.Base.Interfaces;
using TeveApp.Shared.DependencyInjection;

namespace TeveApp.Controls
{
    public static class NavigationControl
    {
        public static async Task PushAsync<TPage, TViewModel>(Action<TViewModel> parameters, bool animation = false)
        {
            await InnerPushAsync<TPage, TViewModel>(parameters, animation);
        }

        private static async Task InnerPushAsync<TPage, TViewModel>(Action<TViewModel> parameters, bool animation)
        {
            TPage view = GetView<TPage>();
            TViewModel viewModel = GetViewModel<TViewModel>();

            parameters?.Invoke(viewModel);

            SetBindingContext(view, viewModel);

            await Application.Current.MainPage.Navigation.PushAsync(view as Page, animation);
        }

        private static void SetBindingContext<TPage, TViewModel>(TPage view, TViewModel viewModel)
        {
            ((IViewContext)view).SetBinding((IViewModelBase)viewModel);
        }

        private static TPage GetView<TPage>()
        {
            return Resolver.Get<TPage>();
        }

        private static TViewModel GetViewModel<TViewModel>()
        {
            return Resolver.Get<TViewModel>();
        }

        public static Page GetPage<TPage, TViewModel>()
        {
            TPage view = GetView<TPage>();
            TViewModel viewModel = GetViewModel<TViewModel>();
            SetBindingContext(view, viewModel);
            return view as Page;
        }
    }
}
