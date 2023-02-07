using prjMauiDemo.View;

namespace prjMauiDemo;

public partial class App : Application
{
	public string User { get; set; }
	public App()
	{
		InitializeComponent();

		MainPage =new NavigationPage( new PgEditor());

	}
}
