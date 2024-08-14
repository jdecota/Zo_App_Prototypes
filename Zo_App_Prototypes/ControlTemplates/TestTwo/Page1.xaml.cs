namespace ControlTemplates.TestTwo;

public partial class Page1 : ContentPage
{
	public Page1()
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

   //public void OnSetCustomTemplateClicked(object sender, EventArgs eventArgs)
   //{
   //   this.contentView3.ControlTemplate = (ControlTemplate)this.Resources["CustomTemplate"];
   //}

   //public void OnSetCustomStyleClicked(object sender, EventArgs eventArgs)
   //{
   //   this.contentView4.Style = (Style)this.Resources["CustomStyle"];
   //}

}