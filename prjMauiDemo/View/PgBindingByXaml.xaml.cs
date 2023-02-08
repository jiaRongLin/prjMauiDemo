namespace prjMauiDemo.View;

public partial class PgBindingByXaml : ContentPage
{
	public PgBindingByXaml()
	{
		InitializeComponent();

		labletitle.BindingContext = slider;
		labletitle.SetBinding(Label.FontSizeProperty,"Value");
	}
}