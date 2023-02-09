using prjMauiDemo.Model;
namespace prjMauiDemo.View;

public partial class PgRead : ContentPage
{
	public PgRead()
	{
		InitializeComponent();
		List<CToDoItem> list = (Application.Current as App).todo;
		lvshow.ItemsSource = list;
	}

	private void lvshow_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		if (e.SelectedItemIndex >= 0)
		{
			App app =  Application.Current as App;
			app.selectTodoIndex = e.SelectedItemIndex;

			Navigation.PopAsync();
		}
	}
}