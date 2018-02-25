using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flappyBirds
{
	abstract class Logger
	{
		protected int printedRows;

		abstract public void Log(string s);
	}
}
