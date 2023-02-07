using Android.Views.InputMethods;
using prjMauiDemo.Model;
using System;
using System.Runtime.ConstrainedExecution;

namespace prjMauiDemo.View;

public partial class PgEditor : ContentPage
{
	int index = 0;
	List<CCustomer> list = new List<CCustomer>();
	public PgEditor()
	{
		InitializeComponent();
		list.Add(new CCustomer() { id = 1, name = "Jia", phone = "0909215565", address = "Kaohsiung", email = "jialin@gmail.com" });
		list.Add(new CCustomer() { id = 3, name = "Verna", phone = "0985123654", address = "Tainan", email = "verna@gmail.com" });
		list.Add(new CCustomer() { id = 9, name = "Zoe", phone = "0945863146", address = "Kaohsiung", email = "zoe@gmail.com" });
	}

	private void btnFirst_Clicked(object sender, EventArgs e)
	{
		index =0;
		txtId.Text = list[index].id.ToString();
		txtName.Text = list[index].name;
		txtPhone.Text = list[index].phone;
		txtAddress.Text = list[index].address;
		txtEmail.Text = list[index].email;
	}

	private void btnPrevious_Clicked(object sender, EventArgs e)
	{
		index--;
		index = index > 0 ? index : 0;
		txtId.Text = list[index].id.ToString();
		txtName.Text = list[index].name;
		txtPhone.Text = list[index].phone;
		txtAddress.Text = list[index].address;
		txtEmail.Text = list[index].email;
	}

	private void btnNext_Clicked(object sender, EventArgs e)
	{
		index++; //todo第一次顯示0
		index = index < list.Count()-1 ? index : list.Count()-1;
		txtId.Text = list[index].id.ToString();
		txtName.Text = list[index].name;
		txtPhone.Text = list[index].phone;
		txtAddress.Text = list[index].address;
		txtEmail.Text = list[index].email;
	}

	private void btnLast_Clicked(object sender, EventArgs e)
	{
		index = list.Count()-1;

		txtId.Text = list[index].id.ToString();
		txtName.Text = list[index].name;
		txtPhone.Text = list[index].phone;
		txtAddress.Text = list[index].address;
		txtEmail.Text = list[index].email;
	}

	private void btnQuery_Clicked(object sender, EventArgs e)
	{

	}

	private void btnList_Clicked(object sender, EventArgs e)
	{

	}
}