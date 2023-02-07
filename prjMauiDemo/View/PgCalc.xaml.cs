

namespace prjMauiDemo.View;

public partial class PgCalc : ContentPage
{
	int n1 = 0;
	int n2 = 0;
	int n3 = 0;
	string op=string.Empty;
	public PgCalc()
	{
		InitializeComponent();
	}

	private void btnNum_click(object sender, EventArgs e)
	{
		if (op == "=") 
		{
			labelans.Text = "0";
			n3 = 0;
			op = string.Empty;
		}
		int t = int.Parse(labelans.Text);
		Button b =sender as Button;
		if (t == 0)
			labelans.Text = b.Text;
		else
			labelans.Text += b.Text;


		int n1 = int.Parse(labelans.Text);
		if (op == "+")
			n3 = (n2 + n1);
		else if (op == "-")
			n3 = (n2 - n1);
		else if (op == "*")
			n3 = (n2 * n1);
		else if (op == "/")
			n3 = (n2 / n1);

		n2 = n3;
	}

	private void btnOperator_click(object sender, EventArgs e)
	{
		if(string.IsNullOrEmpty(op)) { n2 = int.Parse(labelans.Text); }

		labelans.Text = "0";
		Button b =sender as Button;
		op= b.Text;
	}

	private void btnAns_click(object sender, EventArgs e)
	{ 
		labelans.Text = n3.ToString();
		op = "=";	
	}
}