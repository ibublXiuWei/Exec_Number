using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int count = new int();
			for(int cock = 0; cock <= 100/5; cock++)
			{
				for(int hen = 0; hen <=(100-5*cock)/3 ; hen++)
					{
						count++;
					int chicken = 100 - cock - hen;
					double sum = 5*cock +3* hen + (double)chicken / 3.0;
					if(sum==100)
					{
						Console.WriteLine($"共有{cock}隻公雞，{hen}隻母雞，{chicken}隻小雞");
					}
					}
			}
			//Console.WriteLine(count);
		}
	}
}
