using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Zo_App_Prototypes.Common;

namespace Zo_App_Prototypes.Pages
{
   public partial class JoinPageVM : ViewModelBase
   {
      [ObservableProperty] private string _name = "SingletonSean";

      [ObservableProperty] private string _address = "123 Main St";

      [RelayCommand]
      private async Task Submit()
      {
         Dictionary<string, object> parameters = new Dictionary<string, object>
         {
            { "new", true },
            { "profile", new Entities.Profile(Name, Address) }
         };

         await Shell.Current.GoToAsync("//profile", parameters);
      }
   }
}
