using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMauiDemo.Model
{
	public class Unaryquadraticequation
	{
		public string Cal(int a,int b,int c)
		{
			double d, f;
			string result =string.Empty;
			
			d = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
			f = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

			result= "解答： x = " + d.ToString("0.0#") +" 或 "+ f.ToString("0.0#");
			return result;
		}
	}
}
