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
      [ObservableProperty] 
      private string _name = "SingletonSean";

      [ObservableProperty] private string _desc = "Description";

      [RelayCommand]
      private async Task Submit()
      {
         Dictionary<string, object> parameters = new Dictionary<string, object>
         {
            { "new", true },
            { "profile", new Entities.Profile(Name, Desc) }
         };

         await Shell.Current.GoToAsync("//index", parameters);
         //await Shell.Current.GoToAsync("//index", parameters);
      }
   }
}
