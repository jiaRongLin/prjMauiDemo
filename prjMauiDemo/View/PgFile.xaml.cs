namespace prjMauiDemo.View;

public partial class PgFile : ContentPage
{
	public PgFile()
	{
		InitializeComponent();
	}

	private void BtnSave_click(object sender, EventArgs e)
	{
		string folder =Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		string path = Path.Combine(folder, "text.txt");
		File.WriteAllText(path, TxtSet.Text);
		TxtSet.Text = string.Empty;
	}

	private void BtnRead_click(object sender, EventArgs e)
	{
		string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		string path = Path.Combine(folder, "text.txt");
		lableget.Text = File.ReadAllText(path);
	}
}