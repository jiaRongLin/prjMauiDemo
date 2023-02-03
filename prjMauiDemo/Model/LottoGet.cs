using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMauiDemo.Model
{
	public  class LottoGet
	{
		public string GetNumber(int a,int b)
		{
			int[] intarray = new int[6];
			string result = string.Empty;
			int i = 0;
			Random r = new Random(Guid.NewGuid().GetHashCode());
			
			//取亂數
			while (i < 6)
			{
				int n = r.Next(a, b);
				
				//判斷取道的值是否重複
				if (!intarray.Contains(n))
				{
					intarray[i] = n;
					i++;
				}
			}

			//由小排到大
			var s1 = intarray.OrderBy(s=>s);
			foreach (var item in s1)
			{
				result += item.ToString() + " ";
			}

			return result;
		}
	}
}
