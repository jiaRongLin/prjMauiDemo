namespace prjMauiDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		string a = l1.Text;
		string b = l2.Text;
		string c = l3.Text;
		string d = l4.Text;
		do
		{
			List<string> color = new List<string>();
			Random r = new Random(Guid.NewGuid().GetHashCode());
			int x = r.Next(0, 4);
			l1.Text = color[x];
			color.RemoveAt(x);

			x = r.Next(0, 3);
			l2.Text = color[x];
			color.RemoveAt(x);

			x = r.Next(0, 2);
			l3.Text = color[x];
			color.RemoveAt(x);

			x = r.Next(0, 1);
			l4.Text = color[x];
		} while (l1.Text == a || l2.Text == b || l3.Text == c || l4.Text == d);

		//SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

