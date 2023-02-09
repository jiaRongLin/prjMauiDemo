using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMauiDemo.Model
{
	public class CToDoItem
	{
		public string Tkey { get; set; }
		public string Dkey { get; set; }
		public string todo { get; set; }
		public string date { get; set; }

		public override string ToString()
		{
			return todo + " " + date;

		}
	}
}
