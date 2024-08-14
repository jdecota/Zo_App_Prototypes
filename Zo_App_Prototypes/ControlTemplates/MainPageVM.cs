using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CommonLib.Bases;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

using ControlTemplates.Messages;

namespace ControlTemplates
{
   public partial class MainPageVM : ViewModelBase
   {
      [ObservableProperty] string _message = "Current Message";

      [RelayCommand]
      async Task UpdateMessage(string message)
      {
         _message = message;
         WeakReferenceMessenger.Default.Send(new MyMessage(_message));

         await GoBack();

      }


      //[RelayCommand]
      //private async Task NavigateToJoinPage()
      //{
      //   //Dictionary<string, object> parameters = new Dictionary<string, object>
      //   //{
      //   //   { "new", true },
      //   //   { "profile", new Entities.Profile(Name, Desc) }
      //   //};

      //   await Shell.Current.GoToAsync("//join");
      //}

      [RelayCommand]
      private async Task GoBack()
      {
         await Shell.Current.GoToAsync("..");
      }

      [RelayCommand]
      private async Task NavigateToTestOnePage()
      {
         await Shell.Current.GoToAsync("TestOne");
      }

      [RelayCommand]
      private async Task NavigateToTestTwoPage()
      {
         await Shell.Current.GoToAsync("TestTwo");
      }

      [RelayCommand]
      private async Task NavigateToPage1()
      {
         await Shell.Current.GoToAsync("PageOne");
      }
      [RelayCommand]
      private async Task NavigateToPage2()
      {
         await Shell.Current.GoToAsync("PageTwo");
      }
      [RelayCommand]
      private async Task NavigateToPage3()
      {
         await Shell.Current.GoToAsync("PageThree");
      }


      public MainPageVM()
      {
         //TODO REGISTER for Event

      }
   }
}
