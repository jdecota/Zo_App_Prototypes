using CommunityToolkit.Mvvm.Messaging;
using ControlTemplates.Messages;

namespace ControlTemplates.TestTwo;

public partial class View2 : ContentView    //, IRecipient<MyMessage>
{
   View2VM vm;
   //public ControlTemplate? ControlTemplate;

   //public static readonly BindableProperty ControlTemplateProperty =
   //BindableProperty.Create(nameof(ControlTemplate), typeof(ControlTemplate), typeof(View2), null, BindingMode.TwoWay);

   //public ControlTemplate ControlTemplate
   //{
   //   get => (ControlTemplate)GetValue(ControlTemplateProperty);
   //   set => SetValue(ControlTemplateProperty, value);
   //}

   //private VisualElement? _content;

   public View2()
   {
        vm = new View2VM();
        BindingContext = vm;
        InitializeComponent();
      //vm = BindingContext as View2VM;
      //contentView.SetBinding(ContentView.ControlTemplateProperty, new Binding("TemplateName", source: vm));

      //WeakReferenceMessenger.Default.Register<MyMessage>(this);

      //this.contentView.ControlTemplate = $"(vm.TemplateName)";

      //vm.TemplateUpdated -= Vm_TemplateUpdated;

      vm.TemplateUpdated += Vm_TemplateUpdated;
   }


   

   public void Vm_TemplateUpdated(object? sender, EventArgs e)
   {
      if (sender is null)
         this.ControlTemplate = null;
      else
         this.ControlTemplate = (ControlTemplate)Resources[sender.ToString()];
   }

   //protected override void OnApplyTemplate()
   //{
   //  View2CT = this.ControlTemplate as ControlTemplate;
   //}

   public void Handle_Master_Clicked(object sender, System.EventArgs e)
   {
      this.ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeMaster"];
   }

   public void Handle_Blue_Clicked(object sender, System.EventArgs e)
   {
      //this.ControlTemplate = (ControlTemplate)this.Resources["ThemeBlue"];
      this.ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeBlue"];
   }

   void OnViewSelected(object sender, EventArgs e)
   {
      if (e != null)
      {
      }
      //(BindingContext as View2VM).SelectView(e.ToString());
   }

   public void Receive(MyMessage message)
   {
      MainThread.BeginInvokeOnMainThread(() =>
      {
         if (message.Value != null)
         {
            var template = new View2();
            string m = message.Value;

            if (m == "ThemeMaster")
            {
               //Handle_Master_Clicked(this, EventArgs.Empty);
               //this.ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeMaster"];
               template.ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeMaster"];
            }
            else if (m == "ThemeBlue")
            {
               //Handle_Blue_Clicked(this, EventArgs.Empty);
               //this.ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeBlue"];
               template.ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeMaster"];
            }
            //var template = new View2();
            //if (message == "ThemeMaster")
            //   // 
            //   template.View2CT = (ControlTemplate)Application.Current.Resources["ThemeMaster"];
            //if (templateName == "ThemeBlue")
            //   //
            //   
            else
            {
               return;
            }

         }
      });
   }  
}
