namespace prjMauiDemo.View;

public partial class PgHttpDemo : ContentPage
{
	public PgHttpDemo()
	{
		InitializeComponent();
	}

	private async void BtnOk_click(object sender, EventArgs e)
	{
		HttpClient client = new HttpClient();
		Uri uri = new Uri("https://udn.com/invoice");
		HttpResponseMessage response = await client.GetAsync(uri);
		if (response.IsSuccessStatusCode)
		{
			string html=await response.Content.ReadAsStringAsync();
			string key = "last-three";
			int start = html.IndexOf(key)+key.Length+2;
			lblhttp.Text = "¯S§O¸¹" + html.Substring(start, 8);
		}
	}
}