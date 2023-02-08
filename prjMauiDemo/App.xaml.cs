using prjMauiDemo.Model;
using prjMauiDemo.View;

namespace prjMauiDemo;

public partial class App : Application
{
	public string User { get; set; }
	public string Keyword { get; set; }
	public int selectCustomerIndex { get; set; }

	public List<CCustomer> list {get;set;}
	public App()
	{
		InitializeComponent();

		MainPage =new NavigationPage( new PgEditor());

	}
}
