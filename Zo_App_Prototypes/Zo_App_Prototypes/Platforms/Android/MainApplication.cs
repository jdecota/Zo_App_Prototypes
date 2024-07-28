using Android.App;
using Android.Runtime;

namespace Zo_App_Prototypes
{
   [Application]
   public class MainApplication : MauiApplication
   {
      public MainApplication(IntPtr handle, JniHandleOwnership ownership)
         : base(handle, ownership)
      {
      }

      protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
   }
}
