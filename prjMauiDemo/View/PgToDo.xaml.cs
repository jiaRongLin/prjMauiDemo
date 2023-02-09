
using prjMauiDemo.Model;
using System.Diagnostics.Contracts;
using System.Linq;


namespace prjMauiDemo.View;

public partial class PgToDo : ContentPage
{
	public PgToDo()
	{
		InitializeComponent();
		App app = Application.Current as App;
		app.selectTodoIndex = -1;
	}
	List<CToDoItem> _list ;
	private void BtnSave_click(object sender, EventArgs e)
	{
		int count = 0;
		if (Preferences.Default.ContainsKey("COUNT"))
			count = Preferences.Default.Get("COUNT", 0);
		count++;
		int a = count;
		Preferences.Default.Set("COUNT", count);
		Preferences.Default.Set("T" + count.ToString(), TxtToDo.Text);
		Preferences.Default.Set("D" + count.ToString(), TxtDate.Text);

		TxtToDo.Text = string.Empty;
		TxtDate.Text = string.Empty;

	}

	private void BtnRead_click(object sender, EventArgs e)
	{
		_list = new List<CToDoItem>();
		int count = 0;
		if (Preferences.Default.ContainsKey("COUNT"))
			count = Preferences.Default.Get("COUNT", 0);
		if (count == 0)
			return;

		for(int i = 0; i <= count; i++)
		{
			string keyT = "T" + i.ToString();
			if (Preferences.Default.ContainsKey(keyT))
			{
				string keyD = "D" + i.ToString();
				CToDoItem  x= new CToDoItem()
				{
					Tkey = keyT,
					Dkey = keyD,
					todo = Preferences.Default.Get(keyT, ""),
					date = Preferences.Default.Get(keyD, "")
				};
				_list.Add(x);
			}

		}
		if (_list.Count == 0)
			return;
		App app = Application.Current as App;
		app.todo = _list;
		app.selectTodoIndex = -1;
		Navigation.PushAsync(new PgRead());
	}

	protected override void OnAppearing()
	{
		
		App app = Application.Current as App;
		base.OnAppearing();
		if (app.selectTodoIndex >= 0)
		{
			//TxtToDo.Text = app.todo[app.selectTodoIndex].todo;
			//TxtDate.Text = app.todo[app.selectTodoIndex].date;

			TxtToDo.Text = _list[app.selectTodoIndex].todo;
			TxtDate.Text = _list[app.selectTodoIndex].date;
		}
	}

	private void BtnRemove_click(object sender, EventArgs e)
	{
		App app = Application.Current as App;
		//Preferences.Remove(app.todo[app.selectTodoIndex].Tkey);
		//Preferences.Remove(app.todo[app.selectTodoIndex].Dkey);
		Preferences.Remove(_list[app.selectTodoIndex].Tkey);
		Preferences.Remove(_list[app.selectTodoIndex].Dkey);
		TxtToDo.Text = string.Empty;
		TxtDate.Text = string.Empty;
	}
}