

using CommonLib.Bases;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

using ControlTemplates.Messages;

namespace ControlTemplates.TestTwo
{


   public partial class View2VM : ViewModelBase
   {
      //private string _selectedView;
      //properties that represent state of this page
      // databinding only works with public properties
      //methods that represent behavior of the page

      [ObservableProperty] 
      private string _templateName;


      [RelayCommand]
      private void TemplateSelected(string templateName)
      {
         OnTemplateUpdated(templateName);
      }



      public event EventHandler TemplateUpdated;   
      //[RelayCommand]
      //private void UpdateTemplate(string templateName)
      //{
      //   //UpdateTemplate?.Invoke(templateName, EventArgs.Empty);

      //   //_templateName = templateName;
      //   // OnTemplateUpdated(templateName);

      //   _templateName = templateName;

      //   //TODO PubSub SEND Message
      //   //WeakReferenceMessenger.Default.Send(new MyMessage(templateName));

      //}

      protected virtual void OnTemplateUpdated(string templateName)
      {
            TemplateUpdated?.Invoke(templateName, EventArgs.Empty);

         //var template = new View2();
         //if (templateName == "ThemeMaster")
         //   //template.ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeMaster"];
         //   template.View2CT = (ControlTemplate)Application.Current.Resources["ThemeMaster"];
         //if (templateName == "ThemeBlue")
         //   //template.ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeMaster"];
         //   template.View2CT = (ControlTemplate)Application.Current.Resources["ThemeBlue"];
      }


      public View2VM()
      {

      }


      //[RelayCommand]
      //private void UpdateTemplate(string templateName)
      //{

      //   _templateName = templateName;
      //   OnUpdateTemplate(templateName);

      //   //selected = selectedView;

      //   //var template = new View2();
      //   //if (selected != null)
      //   //{
      //   //   if (selected == "ThemeMaster")
      //   //      //template.ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeMaster"];
      //   //      template.View2ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeMaster"];
      //   //      //View2.ControlTemplateProperty = (ControlTemplate).Application.Current.Resources["ThemeMaster"];

      //   //   if (selected == "ThemeBlue")

      //   //      //template.ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeBlue"];
      //   //      template.View2ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeBlue"];
      //   //}
      //   //else
      //   //{
      //   //   return;
      //   //}
      //}

      //[RelayCommand]
      //private void SelectView(string? selection)
      //{
      //   selection = nameof(selectedView);
      //}


      //if (selectedView != null)
      //{
      //   if (selectedView == "ThemeMaster")
      //      //this.ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeMaster"];
      //      //View2.ControlTemplateProperty = (ControlTemplate)Application.Current.Resources["ThemeMaster"];
      //     // View2.Handle_Master_Clicked()

      //      if (selectedView == "ThemeBlue")
      //      {
      //         //View2.ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeBlue"];
      //         //View2.ControlTemplateProperty = (ControlTemplate)Application.Current.Resources["ThemeBlue"];

      //      }
      //}
      //else
      //{
      //   return;
      //}




      //enum SelectedViewName
      //{
      //   ThemeBlue,
      //   ThemeMaster
      //}

      //[RelayCommand]
      //public void Task SelectBlueTheme(string selectedView)
      //{
      //   if (selectedView != null)
      //   {
      //      var 
      //      //this.ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeBlue"];

      //      //View2.ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeBlue"];
      //      //View2.ControlTemplateProperty = (ControlTemplate)Application.Current.Resources["ThemeBlue"];

      //   }
      //   else
      //   {
      //      return;
      //   }
      //}

   }
}
