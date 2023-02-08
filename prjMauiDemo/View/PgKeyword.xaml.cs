namespace prjMauiDemo.View;

public partial class PgKeyword : ContentPage
{
	public PgKeyword()
	{
		InitializeComponent();
	}

	private void BtnSearch_click(object sender, EventArgs e)
	{
		App app = Application.Current as App;
		app.Keyword = entryKeyword.Text;

		Navigation.PopAsync();
	}
}