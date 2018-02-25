namespace flappyBirds
{
	partial class WindowsForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.flappyModel = new System.Windows.Forms.PictureBox();
			this.ground = new System.Windows.Forms.PictureBox();
			this.ground1 = new System.Windows.Forms.PictureBox();
			this.scoreText = new System.Windows.Forms.Label();
			this.endText1 = new System.Windows.Forms.Label();
			this.endText2 = new System.Windows.Forms.Label();
			this.gameDesigner = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.flappyModel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ground1)).BeginInit();
			this.SuspendLayout();
			// 
			// flappyModel
			// 
			this.flappyModel.Image = global::flappyBirds.Properties.Resources.bird;
			this.flappyModel.Location = new System.Drawing.Point(55, 151);
			this.flappyModel.Name = "flappyModel";
			this.flappyModel.Size = new System.Drawing.Size(47, 36);
			this.flappyModel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.flappyModel.TabIndex = 0;
			this.flappyModel.TabStop = false;
			// 
			// ground
			// 
			this.ground.Image = global::flappyBirds.Properties.Resources.ground;
			this.ground.Location = new System.Drawing.Point(0, 372);
			this.ground.Name = "ground";
			this.ground.Size = new System.Drawing.Size(338, 50);
			this.ground.TabIndex = 3;
			this.ground.TabStop = false;
			// 
			// ground1
			// 
			this.ground1.Image = global::flappyBirds.Properties.Resources.ground;
			this.ground1.Location = new System.Drawing.Point(334, 372);
			this.ground1.Name = "ground1";
			this.ground1.Size = new System.Drawing.Size(338, 50);
			this.ground1.TabIndex = 4;
			this.ground1.TabStop = false;
			// 
			// scoreText
			// 
			this.scoreText.AutoSize = true;
			this.scoreText.Location = new System.Drawing.Point(12, 9);
			this.scoreText.Name = "scoreText";
			this.scoreText.Size = new System.Drawing.Size(54, 13);
			this.scoreText.TabIndex = 5;
			this.scoreText.Text = "scoreText";
			// 
			// endText1
			// 
			this.endText1.AutoSize = true;
			this.endText1.Location = new System.Drawing.Point(52, 257);
			this.endText1.Name = "endText1";
			this.endText1.Size = new System.Drawing.Size(52, 13);
			this.endText1.TabIndex = 6;
			this.endText1.Text = "endText1";
			// 
			// endText2
			// 
			this.endText2.AutoSize = true;
			this.endText2.Location = new System.Drawing.Point(52, 282);
			this.endText2.Name = "endText2";
			this.endText2.Size = new System.Drawing.Size(52, 13);
			this.endText2.TabIndex = 7;
			this.endText2.Text = "endText2";
			// 
			// gameDesigner
			// 
			this.gameDesigner.AutoSize = true;
			this.gameDesigner.Location = new System.Drawing.Point(52, 307);
			this.gameDesigner.Name = "gameDesigner";
			this.gameDesigner.Size = new System.Drawing.Size(75, 13);
			this.gameDesigner.TabIndex = 8;
			this.gameDesigner.Text = "gameDesigner";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 15;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// WindowsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(669, 421);
			this.Controls.Add(this.gameDesigner);
			this.Controls.Add(this.endText2);
			this.Controls.Add(this.endText1);
			this.Controls.Add(this.scoreText);
			this.Controls.Add(this.ground1);
			this.Controls.Add(this.ground);
			this.Controls.Add(this.flappyModel);
			this.MaximumSize = new System.Drawing.Size(685, 460);
			this.MinimumSize = new System.Drawing.Size(685, 460);
			this.Name = "WindowsForm";
			this.Text = "FlappyBirds";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WindowsGame_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WindowsGame_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.flappyModel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ground1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.PictureBox flappyModel;
		public Obstacol pipeTop;
		public Obstacol pipeBottom;
		public System.Windows.Forms.PictureBox ground;
		public System.Windows.Forms.PictureBox ground1;
		public System.Windows.Forms.Label scoreText;
		public System.Windows.Forms.Label endText1;
		public System.Windows.Forms.Label endText2;
		public System.Windows.Forms.Label gameDesigner;
		public System.Windows.Forms.Timer timer1;
	}
}

