using TeveApp.Controls;
using TeveApp.View;
using TeveApp.View.Interfaces;
using TeveApp.ViewModel.Interfaces;

namespace TeveApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = NavigationControl.GetPage<ILoginView, ILoginViewModel>();
	}
}
