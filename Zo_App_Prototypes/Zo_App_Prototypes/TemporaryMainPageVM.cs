using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using CommunityToolkit.Mvvm.Input;
using Zo_App_Prototypes.Common;

namespace Zo_App_Prototypes
{
   public partial class TemporaryMainPageVM : ViewModelBase
   {

      [RelayCommand]
      private async Task NavigateToJoinPage()
      {
         //Dictionary<string, object> parameters = new Dictionary<string, object>
         //{
         //   { "new", true },
         //   { "profile", new Entities.Profile(Name, Desc) }
         //};

         await Shell.Current.GoToAsync("//join");
      }

      [RelayCommand]
      private async Task NavigateToDashboardOnePage()
      {
         await Shell.Current.GoToAsync("//dashboard");
      }
      public TemporaryMainPageVM()
      {
         

      }
   }
}
