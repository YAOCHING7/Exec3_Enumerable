using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IEnumerable<int> source = Enumerable.Range(1, 10);
			IEnumerable<string> items = source.Select(x => "Item " + x);
	
			foreach (var item in items)
			{
				Console.WriteLine(item);
			}
		}
	}
}
