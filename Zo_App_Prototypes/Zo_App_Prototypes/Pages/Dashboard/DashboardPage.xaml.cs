namespace Zo_App_Prototypes.Pages.Dashboard;

public partial class DashboardPage : ContentPage
{

   public static readonly BindableProperty SelectedViewTemplateProperty =
      BindableProperty.Create(nameof(SelectedViewTemplateProperty), typeof(ControlTemplate), typeof(DisplayOne), null, propertyChanged: null);

   public ControlTemplate SelectedViewTemplate
   {
      get => (ControlTemplate)GetValue(SelectedViewTemplateProperty);
      set => SetValue(SelectedViewTemplateProperty, value);
   }


   public DashboardPage()
	{
		InitializeComponent();
     
   }
}