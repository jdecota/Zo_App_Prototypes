using CommunityToolkit.Mvvm.Messaging;

using ControlTemplates.Messages;

namespace ControlTemplates
{
   public partial class MainPage : ContentPage //, //IRecipient<MyMessage>
   {
      int count = 0;

      public MainPage()
      {
         InitializeComponent();

         BindingContext = new MainPageVM();

         //WeakReferenceMessenger.Default.Register<MyMessage>(this);
         //WeakReferenceMessenger.Default.Register<MyMessage>(this, (r, m) =>
         //{
         //   //r is object,  m is message
         //   MainThread.BeginInvokeOnMainThread(() =>
         //   {
         //      Shell.Current.DisplayAlert("Message", m.Value, "ok");
         //   });
         //});
      }

      //public void Receive(MyMessage message)
      //{
      //   MainThread.BeginInvokeOnMainThread(() =>
      //   {
      //      Shell.Current.DisplayAlert("Message Is: ", message.Value, "ok");
      //   });
      //}
   }
}
