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
			int target = 31;
			int target2 = 153;
			for (int i = target; i <=target2;  i++)
			{
				int count = new int();
				for (int k = 1; k <= i; k++)
				{
					if (i%k==0)
						{
						count++;
						}
				}
				if(count==2)
					{
						Console.WriteLine($"{i}是質數");
					}
					
			}
			
		}
	}
}
