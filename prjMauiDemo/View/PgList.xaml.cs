namespace prjMauiDemo.View;

public partial class PgList : ContentPage
{
	public PgList()
	{
		InitializeComponent();

		App app = Application.Current as App;
		ListviewCustomer.ItemsSource = app.list;
	}

	private void ListviewCustomer_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		if (e.SelectedItemIndex >= 0)
		{
			App app = Application.Current as App;
			app.selectCustomerIndex = e.SelectedItemIndex;

			Navigation.PopAsync();
		}
	}
}