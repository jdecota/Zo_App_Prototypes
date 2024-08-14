using ControlTemplates.TestTwo;

namespace ControlTemplates
{
   public partial class AppShell : Shell
   {
      public AppShell()
      {

         InitializeComponent();



         Routing.RegisterRoute("TestOne", typeof(TestOnePage));
         Routing.RegisterRoute("TestTwo", typeof(TestTwoPage));
         Routing.RegisterRoute("PageOne", typeof(Page1));
         Routing.RegisterRoute("PageTwo", typeof(Page2));
         Routing.RegisterRoute("PageThree", typeof(Page3));

      }
   }
}
