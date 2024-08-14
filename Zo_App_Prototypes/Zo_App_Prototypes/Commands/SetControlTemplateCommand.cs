using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zo_App_Prototypes.Common;
using Zo_UI.Services;

namespace Zo_App_Prototypes.Commands
{
   public class SetControlTemplateCommand<TControlTemplate> : CommandBase
      where TControlTemplate : ControlTemplate
   {
      private readonly ViewTemplateService<TControlTemplate> _templateService;

      public SetControlTemplateCommand(ViewTemplateService<TControlTemplate> templateService)
      {
         _templateService = templateService;
      }

      public void Execute(object parameter)
      {
         _templateService.SetControlTemplate();
      }

   }
}
