using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Zo_App_Prototypes.Common;

namespace Zo_App_Prototypes.Pages
{
   [QueryProperty(nameof(Desc), "desc")]
   public partial class DescriptionPageVM : ViewModelBase
   {
      [ObservableProperty]
      private string _desc;

      [RelayCommand]
      private async Task Back()
      {
         //TODO- if create hierachial nav  (in AppShell.cs), use Current.Navigation....
         await Shell.Current.Navigation.PopAsync();
      }
   }
}
