using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
	public class ClassForStaticTest
	{
		public static int a;

		public ClassForStaticTest()
		{
			a = 5;
		}

		public int IncreaseA()
		{
			a++;
			return a;
		}
	}
}
