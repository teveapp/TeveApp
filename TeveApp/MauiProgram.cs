using TeveApp.Shared.Base;
using TeveApp.View.DependencyInjection;
using TeveApp.ViewModel.DependencyInjection;

namespace TeveApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        CreateBuilder();
        InjectDependencies();
		return TeveAppBase.Instance.Builder.Build();
	}

    private static void InjectDependencies()
    {
        TeveAppBase.Instance.InjectDependencies(new InjectViewDependencies());
        TeveAppBase.Instance.InjectDependencies(new InjectViewModelDependencies());
    }

    private static void CreateBuilder()
    {
		TeveAppBase.Instance.Builder
			.UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
    }
}
