using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Zo_App_Prototypes.Common;
using Zo_App_Prototypes.Entities;

namespace Zo_App_Prototypes.Pages
{
   [QueryProperty(nameof(IsNew), "new")]
   [QueryProperty(nameof(Profile), "profile")]

   public partial class IndexPageVM : ViewModelBase
   {
      [ObservableProperty]
      private bool _isNew;

      [ObservableProperty]
      private Entities.Profile _profile;

      public string Greeting => IsNew
         ? $"Welcome, {Profile?.Name}!" : $"Hello, {Profile?.Name}!";

      [RelayCommand]
      private async Task ToDescriptionPage()
      {
         //await Shell.Current.GoToAsync($"//description");
         //TODO- Relative Nav- No //
         await Shell.Current.GoToAsync($"description?desc={Profile.Desc}");
      }

      partial void OnIsNewChanged(bool value)
      {
         OnPropertyChanged(nameof(Greeting));
      }

      partial void OnProfileChanged(Entities.Profile value)
      {
         OnPropertyChanged(nameof(Greeting));
      }
   }
}
