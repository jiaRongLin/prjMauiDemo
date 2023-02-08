using prjMauiDemo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMauiDemo.ViewModel
{
	public class CCustomerViewModel:INotifyPropertyChanged
	{
		List<CCustomer> _list = new List<CCustomer>();
		int index = 0;

		public event PropertyChangedEventHandler PropertyChanged;

		public CCustomerViewModel()
		{
			LoadData();
		}

		public void LoadData()
		{
			_list.Add(new CCustomer() { id = 1, name = "Jia", phone = "0909215565", address = "Kaohsiung", email = "jialin@gmail.com" });
			_list.Add(new CCustomer() { id = 3, name = "Verna", phone = "0985123654", address = "Tainan", email = "verna@gmail.com" });
			_list.Add(new CCustomer() { id = 9, name = "Zoe", phone = "0945863146", address = "Kaohsiung", email = "zoe@gmail.com" });
		}

		public void First()
		{
			index = 0;
			PropertyChanged(this, new PropertyChangedEventArgs("current"));
		}
		public void Next()
		{
			index++;
			index = index < _list.Count - 1 ? index : _list.Count - 1;
			PropertyChanged(this, new PropertyChangedEventArgs("current"));

		}
		public void Previos()
		{
			index--;
			index = index > 0 ? index : 0;
			PropertyChanged(this, new PropertyChangedEventArgs("current"));
		}
		public void Last()
		{
			index = _list.Count - 1;
			PropertyChanged(this, new PropertyChangedEventArgs("current"));
		}
		public void Moveto(int id)
		{
			index = id;
			PropertyChanged(this, new PropertyChangedEventArgs("current"));
		}

		public CCustomer QueryByKeyword(string keyword)
		{
			int count = 0;
			foreach(var item in _list)
			{
				if (_list[count].name.Contains(keyword) ||
					_list[count].phone.Contains(keyword) ||
					_list[count].address.Contains(keyword)||
					_list[count].email.Contains(keyword) )
				{
					index = count;
					PropertyChanged(this, new PropertyChangedEventArgs("current"));
					return item;
				}
					count++;	
			}
			return null;
		}

		public CCustomer current
		{
			get { return _list[index]; }
			set { _list[index] = value; }
		}

		public List<CCustomer> All
		{
			get { return _list; }
			set { _list = value; }
		}
	}
}
