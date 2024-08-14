namespace ControlTemplates.TestTwo;

public partial class View1 : ContentView
{
	public View1()
	{
		InitializeComponent();
	}

   void Handle_Master_Clicked(object sender, System.EventArgs e)
   {
      this.ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeMaster"];

   }

   void Handle_Blue_Clicked(object sender, System.EventArgs e)
   {
      //this.ControlTemplate = (ControlTemplate)this.Resources["ThemeBlue"];
      this.ControlTemplate = (ControlTemplate)Application.Current.Resources["ThemeBlue"];
   }
}