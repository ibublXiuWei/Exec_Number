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
			const int n= 6653;
			int root=(int)Math.Ceiling(Math.Sqrt(n));
			for(int i=2; i<root; i++)
			{
				if(n%i==0)
				{
					Console.WriteLine($"{n}不是質數");
					return;
				}
			}
			Console.WriteLine($"{n}是質數"); 
		}
	}
}
