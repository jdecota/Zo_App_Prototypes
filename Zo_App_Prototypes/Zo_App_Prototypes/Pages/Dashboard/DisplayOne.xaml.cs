using Zo_App_Prototypes.Pages.Dashboard.DisplayOneContainers;

namespace Zo_App_Prototypes.Pages.Dashboard;

public partial class DisplayOne : ContentView
{

   //private readonly ControlTemplate DataGridContainer = new DataGridContainer();
   //private readonly ControlTemplate _formContainer = new FormStylesContainer();
   //private readonly ControlTemplate _calendarContainer = new CalendarContainer();




   public DisplayOne(DisplayOneVM vm)
	{
		InitializeComponent();
      BindingContext = vm;
	}
} 