namespace Zo_App_Prototypes
{
   public partial class App : Application
   {
      public App()
      {
         InitializeComponent();

         MainPage = new AppShell();


      }
      //TODO: Nav- CAN override initial start page
      //protected override async void OnStart()
      //{

      //   await Shell.Current.GoToAsync("//join");

      //   base.OnStart();
      //}
   }
}
