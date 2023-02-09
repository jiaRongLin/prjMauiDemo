using prjMauiDemo.Model;
using prjMauiDemo.ViewModel;
using System;
using System.Runtime.ConstrainedExecution;

namespace prjMauiDemo.View;

public partial class PgEditor : ContentPage
{
	CCustomerViewModel vm ;
	public PgEditor()
	{
		InitializeComponent();
		vm = this.BindingContext as CCustomerViewModel; 
	}

	

	private void btnFirst_Clicked(object sender, EventArgs e)
	{
		vm.First();  //Bindingªì¤¤ª©
		//Display(); //¤p¾Çª©
	}

	private void btnPrevious_Clicked(object sender, EventArgs e)
	{
		vm.Previos();
		//Display();
	}

	private void btnNext_Clicked(object sender, EventArgs e)
	{
		vm.Next();
		//Display();
	}

	private void btnLast_Clicked(object sender, EventArgs e)
	{
		vm.Last();
		//Display();
	}

	private void btnQuery_Clicked(object sender, EventArgs e)
	{
		App app = Application.Current as App;
		Clear();
		Navigation.PushAsync(new PgKeyword());
	}

	private static void Clear()
	{
		App app = Application.Current as App;
		app.Keyword = String.Empty;
		app.selectCustomerIndex = -1;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		App app = Application.Current as App;
		if (!string.IsNullOrEmpty(app.Keyword))
		{
			vm.QueryByKeyword(app.Keyword);
			//if (vm.QueryByKeyword(app.Keyword) != null)
			//{
			//	Display();
			//}
		}
		else if (app.selectCustomerIndex >= 0)
		{
			vm.Moveto(app.selectCustomerIndex);
			//Display();
		}

	}

	private void btnList_Clicked(object sender, EventArgs e)
	{
		App app = Application.Current as App;
		app.list = vm.All;
		Clear();
		Navigation.PushAsync(new PgList());
	}

	//private void Display()
	//{
	//	txtId.Text = vm.current.id.ToString();
	//	txtName.Text = vm.current.name;
	//	txtPhone.Text = vm.current.phone;
	//	txtAddress.Text = vm.current.address;
	//	txtEmail.Text = vm.current.email;
	//}
}