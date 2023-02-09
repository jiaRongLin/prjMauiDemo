namespace prjMauiDemo.View;

public partial class PgPreferenceDemo : ContentPage
{
	public PgPreferenceDemo()
	{
		InitializeComponent();
	}

	private void BtnSave_click(object sender, EventArgs e)
	{
		Preferences.Default.Set("KK", TxtSet.Text);
	}

	private void BtnRead_click(object sender, EventArgs e)
	{
		lableget.Text = Preferences.Default.Get("KK", "沒有資料");
	}
}