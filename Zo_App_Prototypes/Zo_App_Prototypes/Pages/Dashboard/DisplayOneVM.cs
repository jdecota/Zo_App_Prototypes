using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Zo_App_Prototypes.Common;
using Zo_UI.Stores;

namespace Zo_App_Prototypes.Pages.Dashboard
{
   

   public partial class DisplayOneVM : ViewModelBase
   {
      private readonly TemplateStore _templateStore;

      public ControlTemplate CurrentDisplayOneCT => _templateStore.CurrentControlTemplate;



      public decimal Value => 500;

      public bool IsPositive => Value > 0;
      public bool IsNegative => Value < 0;

      public DisplayOneVM(TemplateStore templateStore )
      {
         _templateStore = templateStore;
         _templateStore.CurrentTemplateChanged += OnCurrentDisplayOneCTChanged;
      }

      private void OnCurrentDisplayOneCTChanged()
      {
         OnPropertyChanged(nameof(CurrentDisplayOneCT));


         
            ////this.ControlTemplate = (ControlTemplate)this.Resources["ThemeBlue"];
            //this.ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeBlue"];
         
      }
   }
}
