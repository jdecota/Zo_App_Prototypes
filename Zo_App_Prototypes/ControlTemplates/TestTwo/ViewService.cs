using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTemplates.TestTwo
{
   public class ViewService : IViewService
   {


      public Task<bool> DisplayAlert(string title, string message, string ok, string cancel)
      {
         return Application.Current.MainPage.DisplayAlert(title, message, ok, cancel);
      }

      public Task<View> GetViewAsync(ControlTemplate controlTemplate)
      {
         throw new NotImplementedException();
      }
   }
}
