using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTemplates.TestTwo
{
   public interface IViewService
   {

      Task <View> GetViewAsync(ControlTemplate controlTemplate);
      Task<bool> DisplayAlert(string title, string message, string ok, string cancel);
   }
}
