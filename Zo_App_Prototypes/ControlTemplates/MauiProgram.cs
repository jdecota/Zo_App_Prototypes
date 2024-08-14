using ControlTemplates.TestTwo;

using Microsoft.Extensions.Logging;

namespace ControlTemplates
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

         ////TODO REGISTER VIEWS
         //builder.Services.AddTransient<View2>();
         //builder.Services.AddTransient<View1>();
         //builder.Services.AddTransient<View3>();

         ////TODO REGISTER VIEWMODELS
         //builder.Services.AddTransient<View2VM>();
         //builder.Services.AddTransient<MainPageVM>();



         //TODO REGISTER PAGES
         builder.Services.AddTransient<MainPage>();
         builder.Services.AddTransient<TestOnePage>();
         builder.Services.AddTransient<TestTwoPage>();
         builder.Services.AddTransient<Page1>();
         builder.Services.AddTransient<Page2>();
         builder.Services.AddTransient<Page3>();

#if DEBUG
         builder.Logging.AddDebug();
#endif

         return builder.Build();
      }
   }
}
