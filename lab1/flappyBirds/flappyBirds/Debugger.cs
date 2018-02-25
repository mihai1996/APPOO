using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flappyBirds
{
	class Debug:Logger
	{
		public  override void Log(string s)
		{
			System.Diagnostics.Debug.WriteLine(s);
			this.printedRows++;
		}
	}
}
