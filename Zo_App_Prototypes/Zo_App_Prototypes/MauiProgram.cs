using Microsoft.Extensions.Logging;
using Zo_App_Prototypes.Pages;
using Zo_App_Prototypes.Pages.Dashboard;

namespace Zo_App_Prototypes
{
   public static class MauiProgram
   {
      public static MauiApp CreateMauiApp()
      {
         var builder = MauiApp.CreateBuilder();
         builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
               fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
               fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
   		builder.Logging.AddDebug();
#endif


         //Add ViewModels
         builder.Services.AddTransient<HeaderCompVM>();
         builder.Services.AddTransient<DisplayOneVM>();
         builder.Services.AddTransient<MenuDisplayVM>();




         builder.Services.AddViewModel<JoinPageVM, JoinPage>();

         builder.Services.AddViewModel<TemporaryMainPageVM, TemporaryMainPage>();
         //builder.Services.AddViewModel<MainPageVM, MainPage>();
         builder.Services.AddViewModel<JoinPageVM, JoinPage>();
         builder.Services.AddViewModel<IndexPageVM, IndexPage>();
         builder.Services.AddViewModel<DescriptionPageVM, DescriptionPage>();
         builder.Services.AddViewModel<ProfilePageVM, ProfilePage>();
         builder.Services.AddViewModel<DashboardPageVM, DashboardPage>();






         return builder.Build();
      }
      private static void AddViewModel<TViewModel, TView>(this IServiceCollection services)
         where TView : ContentPage, new()
         where TViewModel : class
      {
         services.AddTransient<TViewModel>();
         services.AddTransient<TView>(s => new TView() { BindingContext = s.GetRequiredService<TViewModel>() });
      }
   }
}
