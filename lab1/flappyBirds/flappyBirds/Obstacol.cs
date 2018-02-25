using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappyBirds
{
	//mostenire
	public class Obstacol : PictureBox
	{
		public static Obstacol ObstacolJos(WindowsForm f)
		{
			f.pipeBottom = new Obstacol();
			((System.ComponentModel.ISupportInitialize)(f.pipeBottom)).BeginInit();
			f.pipeBottom.Image = global::flappyBirds.Properties.Resources.pipe;
			f.pipeBottom.Location = new System.Drawing.Point(409, 205);
			f.pipeBottom.Name = "pipeBottom";
			f.pipeBottom.Size = new System.Drawing.Size(73, 236);
			f.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			f.pipeBottom.TabIndex = 2;
			f.pipeBottom.TabStop = false;
			f.Controls.Add(f.pipeBottom);
			((System.ComponentModel.ISupportInitialize)(f.pipeBottom)).EndInit();

			return f.pipeBottom;
		}

		public static Obstacol ObstacolSus(WindowsForm f)
		{
			f.pipeTop = new Obstacol();
			((System.ComponentModel.ISupportInitialize)(f.pipeTop)).BeginInit();
			f.pipeTop.Image = global::flappyBirds.Properties.Resources.pipedown;
			f.pipeTop.Location = new System.Drawing.Point(207, -86);
			f.pipeTop.Name = "pipeTop";
			f.pipeTop.Size = new System.Drawing.Size(73, 236);
			f.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			f.pipeTop.TabIndex = 1;
			f.pipeTop.TabStop = false;
			f.Controls.Add(f.pipeTop);
			((System.ComponentModel.ISupportInitialize)(f.pipeTop)).EndInit();

			return f.pipeTop;
		}
	}
}
