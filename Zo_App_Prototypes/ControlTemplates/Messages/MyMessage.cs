using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ControlTemplates.Messages
{

   //TODO Messenger from Toolkit
   //  Inherit from ValueChangedMessage<T>
   //  In ViewModel, register
   /*
    *          WeakReferenceMessenger.Default.Register<MyMessage>(this, (r, m) =>
         {
            //r is object,  m is message
            MainThread.BeginInvokeOnMainThread(() =>
            {
               Shell.Current.DisplayAlert("Messaage", m.Value, "ok");
            });
         });
    */


   public class MyMessage : ValueChangedMessage<string>
   {
      public MyMessage(string value) : base(value)
      {

      }
   }
}
