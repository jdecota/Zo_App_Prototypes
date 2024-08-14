namespace ControlTemplates;

public partial class TestOnePage : ContentPage
{
	public TestOnePage()
	{
		InitializeComponent();
	}


   public void OnSetCustomTemplateClicked(object sender, EventArgs eventArgs)
   {
      this.ContentView3.ControlTemplate = (ControlTemplate)this.Resources["CustomTemplate"];
   }

   public void OnSetCustomStyleClicked(object sender, EventArgs eventArgs)
   {
      this.ContentView4.Style = (Style)this.Resources["CustomStyle"];
   }

}