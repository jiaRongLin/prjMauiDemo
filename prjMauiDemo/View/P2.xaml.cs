namespace prjMauiDemo.View;

public partial class P2 : ContentPage
{
	public P2()
	{
		InitializeComponent();
		App a = Application.Current as App;

		labelP2.Text = a.User;
	}

	private void backP1_Clicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}