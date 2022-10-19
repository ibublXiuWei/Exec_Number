using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int a =1 ; a <= 9; a++)
			{
				for (int b = 0; b <= 9; b++)
				{
					int number = 1000 * a + 100 * a + 10 * b + b;
					var root2 = Math.Sqrt(number);
					if (number % root2 == 0)
					{
						Console.WriteLine(number);
					}
				}
			}
		}
	}
}
