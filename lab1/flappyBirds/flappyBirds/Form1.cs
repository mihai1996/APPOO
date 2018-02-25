using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappyBirds
{
	public partial class WindowsForm : Form
	{
		Game game;

		public WindowsForm()
		{
			InitializeComponent();
			
			//se transmite la constructor forma
			game = new Game(this);

			game.debug.Log("S-a pornit joaca");

			endText1.Text = "Game Over!";
			endText2.Text = "Your final score is: " + game.Inscore;
			gameDesigner.Text = "Game Designed By your name here";

			endText1.Visible = false;
			endText2.Visible = false;
			gameDesigner.Visible = false;
		}

		private void endGame()
		{
			timer1.Stop();
			endText1.Visible = true;
			endText2.Visible = true;
			gameDesigner.Visible = true;
			game.debug.Log("joaca s-a terminat");
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			game.debug.Log("S-a pornit timer");

			game.obstacolJos.Left -= game.pipeSpeed;
			game.obstacolSus.Left -= game.pipeSpeed;
			flappyModel.Top += game.gravity;
			scoreText.Text = "" + game.Inscore;

			if (game.obstacolJos.Left < -80)
			{
				game.obstacolJos.Left = 1100;
				game.Inscore += 1;
			}
			else if (game.obstacolSus.Left < -95)
			{
				game.obstacolSus.Left = 1100;
				game.Inscore += 1;
			}

			if (flappyModel.Bounds.IntersectsWith(ground.Bounds))
			{
				endGame();
			}
			else if (flappyModel.Bounds.IntersectsWith(game.obstacolJos.Bounds))
			{
				endGame();
			}
			else if (flappyModel.Bounds.IntersectsWith(game.obstacolSus.Bounds))
			{
				endGame();
			}
			game.debug.Log("S-a terminat timer");

		}

		private void WindowsGame_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				game.jumping = false;
				game.gravity = 2;
			}
		}

		private void WindowsGame_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				game.jumping = true;
				game.gravity = -6;
				game.debug.Log("S-a tastat space");
			}
		}
	}
}
