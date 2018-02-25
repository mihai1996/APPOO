using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappyBirds
{
	class Game
	{
		public bool jumping = false;
		public int pipeSpeed = 3;
		public int gravity = 5;
		public int Inscore = 0;
		public Obstacol obstacolSus;
		public Obstacol obstacolJos;
		public Debug debug;

		public Game(WindowsForm f)
		{
			obstacolSus = Obstacol.ObstacolSus(f);
			obstacolJos = Obstacol.ObstacolJos(f);
			debug = new Debug();
		}
	}
}
