using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Zo_App_Prototypes.Common;
using Zo_App_Prototypes.Entities;
using Zo_App_Prototypes.Pages.Dashboard.DisplayOneContainers;
using Zo_App_Prototypes.Pages.FormTypes;
using Zo_UI.Services;
using Zo_UI.Stores;
using ControlTemplate = Microsoft.Maui.Controls.ControlTemplate;

namespace Zo_App_Prototypes.Pages.Dashboard
{

   //public class SelectionInfoEventArgs : EventArgs
   //{
   //   public SelectionInfo SelectionInfo { get; set; }

   //}


   public partial class HeaderCompVM : ViewModelBase
   {
      //public delegate void SelectionInfoChangedEventHandler(object source, SelectionInfoEventArgs e);

      //public event SelectionInfoChangedEventHandler SelectionInfo;

      private readonly TemplateStore _templateStore;


      [ObservableProperty] private ControlTemplate controlTemplateName;

      public ControlTemplate CurrentControlTemplate => _templateStore.CurrentControlTemplate;

      public ICommand SetControlTemplateCommand { get; }

      //[RelayCommand]
      //public void ControlTemplateChanged(string controlTemplateName)
      //{
      //   //   //var selection = new SelectionInfo();
      //   //   //selection.Name = (nameof(SelectionInfo));

      //   OnControlTemplateChanged(controlTemplateName);


      //}




      [RelayCommand]
      public async Task NavigateHome()
      {
         await Shell.Current.GoToAsync("temporaryMain");
      }

      public HeaderCompVM(TemplateStore templateStore)
      {

         _templateStore = templateStore;


         _templateStore.CurrentTemplateChanged += OnControlTemplateChanged;
      }




      protected virtual void OnControlTemplateChanged()
      {
         OnPropertyChanged(nameof(CurrentControlTemplate));

         //if (controlTemplateName != null)
         //{
         //   if (controlTemplateName == "FormContainer")
         //   {

         //      //displayOne.Content = new ControlTemplate(typeof(FormStylesContainer));
         //      //displayOne.Content = new ControlTemplate(typeof(FormStylesContainer));
         //   }

         //   if (controlTemplateName == "CalendarContainer")
         //   {
         //      //displayOne.Content = new ControlTemplate(typeof(CalendarContainer));
         //   }

         //   if (controlTemplateName == "DataGridContainer")
         //   {
         //      //displayOne.Content = new ControlTemplate(typeof(DataGridContainer));
         //   }
         //   else
         //   {
         //      return;
         //   }
         }
      }


      //protected virtual void OnSelectionChanged(SelectionInfo selectionInfo)
      // {
      //    var displayOne = new DisplayOne();

      //    if (selectionInfo != null)
      //    {
      //       if (selectionInfo.Name == "ItemForm")
      //       {

      //          displayOne.ControlTemplate = new ControlTemplate(typeof(ItemForm));
      //       }

      //       if (selectionInfo.Name == "ContactForm")
      //       {
      //          displayOne.ControlTemplate = new ControlTemplate(typeof(ContactForm));
      //       }

      //       if (selectionInfo.Name == "TaskForm")
      //       {
      //          displayOne.ControlTemplate = new ControlTemplate(typeof(TaskForm));
      //       }
      //       else
      //       {
      //          return;
      //       }
      //    }
      // }
      //protected virtual void OnSelectionChanged(SelectionInfo selectionInfo)
      // {
      //    var displayOne = new DisplayOne();

      //    if (selectionInfo != null)
      //    {
      //       if (selectionInfo.Name == "ItemForm")
      //       {

      //          displayOne.ControlTemplate = new ControlTemplate(typeof(ItemForm));
      //       }

      //       if (selectionInfo.Name == "ContactForm")
      //       {
      //          displayOne.ControlTemplate = new ControlTemplate(typeof(ContactForm));
      //       }

      //       if (selectionInfo.Name == "TaskForm")
      //       {
      //          displayOne.ControlTemplate = new ControlTemplate(typeof(TaskForm));
      //       }
      //       else
      //       {
      //          return;
      //       }
      //    }
      // }

      //protected virtual void OnDisplayOneChanged(object sender, DisplayOneEventArgs e)
      //{
      //   if (DisplayOneChanged != null)
      //      DisplayOneChanged(this, new DisplayOneEventArgs(){DisplayOne = (DisplayOne.ControlTemplateProperty)});
      //}

   }


