using TeveApp.Shared.Base;

namespace TeveApp.Shared.DependencyInjection
{
    public class Resolver
    {
        public static T Get<T>()
        {
            return TeveAppBase.Instance.Builder.Services.BuildServiceProvider().GetService<T>();
        }

        public static void InjectTransient<TI, TA>()
        {
            TeveAppBase.Instance.Builder.Services.AddTransient(typeof(TI), typeof(TA));
        }

        public static void InjectSigleton<TI, TA>()
        {
            TeveAppBase.Instance.Builder.Services.AddSingleton(typeof(TI), typeof(TA));
        }
    }
}
