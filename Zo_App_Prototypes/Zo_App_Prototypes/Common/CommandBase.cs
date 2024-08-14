﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace Zo_App_Prototypes.Common
{
   public class CommandBase : IRelayCommand
   {
      public event EventHandler? CanExecuteChanged;

      public bool CanExecute(object? parameter)
      {
         throw new NotImplementedException();
      }

      public void Execute(object? parameter)
      {
         throw new NotImplementedException();
      }

      public void NotifyCanExecuteChanged()
      {
         throw new NotImplementedException();
      }
   }
}
