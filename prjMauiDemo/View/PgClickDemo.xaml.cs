using prjMauiDemo.Model;

namespace prjMauiDemo.View;

public partial class PgClickDemo : ContentPage
{
	public PgClickDemo()
	{
		InitializeComponent();
	}

	private void buttonOK_Clicked(object sender, EventArgs e)
	{
		Unaryquadraticequation uq = new Unaryquadraticequation();
		int a, b, c;

		a=int.Parse(entryA.Text);
		b=int.Parse(entryB.Text);
		c=int.Parse(entryC.Text);

		lableAns.Text = uq.Cal(a,b,c);
	}
}