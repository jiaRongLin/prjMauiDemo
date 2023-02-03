using prjMauiDemo.Model;

namespace prjMauiDemo;

public partial class PageLotto : ContentPage
{
	public PageLotto()
	{
		InitializeComponent();
		LottoGet L = new LottoGet();

		L1.Text = L.GetNumber(1,50) ;
	}

	private void B1_Clicked(object sender, EventArgs e)
	{
		LottoGet L = new LottoGet();

		L1.Text = L.GetNumber(1, 50);
	}
}