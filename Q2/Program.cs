using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int target = 103;
			int target2 = 3003;
			for (int i = target; i <=target2;  i++)
			{
					var root2=Math.Sqrt(i);
					if (i % root2 == 0)  //(root2==Math.Floor(Math.Sqrt(number))
						{
						Console.WriteLine($"{i}是質數");
						}
			}
			
		}
	}
}
