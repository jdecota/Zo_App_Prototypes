using Microsoft.Maui.Controls;

using Zo_App_Prototypes.Pages;

namespace Zo_App_Prototypes
{
   public partial class AppShell : Shell
   {
      public AppShell()
      {
         InitializeComponent();


         Routing.RegisterRoute("index/description", typeof(DescriptionPage));

         //Routing.RegisterRoute("description", typeof(DescriptionPage));
         //Routing.RegisterRoute("index", typeof(IndexPage));
         //Routing.RegisterRoute("join", typeof(JoinPage));
         //Routing.RegisterRoute("temporaryMain", typeof(TemporaryMainPage));


         //TODO: Shell Nav- register routing-  if want hierarchy, need to do here so can have "back" navigation
         //Routing.RegisterRoute("description", typeof(DescriptionPage));
         //Routing.RegisterRoute("index", typeof(IndexPage));
         //Routing.RegisterRoute("join", typeof(JoinPage));
         //Routing.RegisterRoute("temporaryMain", typeof(TemporaryMainPage));
         ////TODO: once remove temporary main page, remove from hierarchy
         //Routing.RegisterRoute("main", typeof(MainPage));

         // TODO - attempted Relative routing;  appears only works with back routing  "../../"
         //Routing.RegisterRoute("join/index/description", typeof(DescriptionPage));
         //Routing.RegisterRoute("join/index", typeof(IndexPage));
         //Routing.RegisterRoute("join", typeof(JoinPage));
         //Routing.RegisterRoute("temporaryMain", typeof(TemporaryMainPage));
      }
   }
}
