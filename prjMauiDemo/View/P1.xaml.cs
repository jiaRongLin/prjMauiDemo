namespace prjMauiDemo.View;

public partial class P1 : ContentPage
{
	public P1()
	{
		InitializeComponent();
		
	}

	private void btntopage2_Clicked(object sender, EventArgs e)
	{
		App a = Application.Current as App;
		a.User = "Jia";
		Navigation.PushAsync(new P2());
	}
}