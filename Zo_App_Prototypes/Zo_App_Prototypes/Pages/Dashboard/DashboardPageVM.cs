

using Zo_App_Prototypes.Common;

namespace Zo_App_Prototypes.Pages.Dashboard
{
   public class DashboardPageVM : ViewModelBase
   {
      //public HeaderVM HeaderVM { get;}
     // public HeaderComponentVM HeaderComponentVM { get; }
      public HeaderCompVM HeaderCompVM { get;}
      public MenuDisplayVM MenuDisplayVM { get;}
      public DisplayOneVM DisplayOneVM { get;}




      public DashboardPageVM(
        // HeaderVm headerVm,
        //HeaderComponentVM headerComponentVM,
        HeaderCompVM headerCompVM,
         MenuDisplayVM menuDisplayVM,
         DisplayOneVM displayOneVM)
      {
         //HeaderVm = headerVm;
         //HeaderComponentVM = headerComponentVM;
         HeaderCompVM = headerCompVM;
         MenuDisplayVM = menuDisplayVM;
         DisplayOneVM = displayOneVM;
      }
   }
}
