using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zo_App_Prototypes.Common;

namespace Zo_App_Prototypes.Pages.Dashboard
{
   public class MenuDisplayVM : ViewModelBase
   {
      public string TemporaryText = "Menu Display Bound";

      private ControlTemplate _currentControlTemplate = new ControlTemplate();
      public ControlTemplate CurrentControlTemplate { get; private set; }

      public MenuDisplayVM()
      {
         
      }
   }
}
