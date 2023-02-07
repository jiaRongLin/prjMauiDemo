

namespace prjMauiDemo.View;

public partial class PgCalc : ContentPage
{
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
			n2 = 0;
			op = string.Empty;
		}
		int t = int.Parse(labelans.Text);
		Button b =sender as Button;
		if (t == 0)
			labelans.Text = b.Text;
		else
			labelans.Text += b.Text;
	}

	private void btnOperator_click(object sender, EventArgs e)
	{
		n2 = int.Parse(labelans.Text);
		//todo³s¥[

		labelans.Text = "0";
		Button b =sender as Button;
		op= b.Text;

		

	}

	private void btnAns_click(object sender, EventArgs e)
	{
		int n1= int.Parse(labelans.Text);
		if (op == "+") 
			labelans.Text = (n2 + n1).ToString(); 
		else if (op == "-") 
			labelans.Text = (n2 - n1).ToString();
		else if (op == "*") 
			labelans.Text = (n2 * n1).ToString(); 
		else if(op == "/") 
			labelans.Text = (n2 / n1).ToString(); 
		op = "=";	
	}
}