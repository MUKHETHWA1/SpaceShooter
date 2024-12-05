namespace SpaceShooter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MoveBackground = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.leftmovetimer = new System.Windows.Forms.Timer(this.components);
            this.rightmovetimer = new System.Windows.Forms.Timer(this.components);
            this.downmovetimer = new System.Windows.Forms.Timer(this.components);
            this.upmovetimer = new System.Windows.Forms.Timer(this.components);
            this.movemunitiontimer = new System.Windows.Forms.Timer(this.components);
            this.moveenemiestimer = new System.Windows.Forms.Timer(this.components);
            this.EnemiesMunitionTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBackground
            // 
            this.MoveBackground.Interval = 10;
            this.MoveBackground.Tick += new System.EventHandler(this.MoveBackground_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(205, 400);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // leftmovetimer
            // 
            this.leftmovetimer.Interval = 5;
            this.leftmovetimer.Tick += new System.EventHandler(this.leftmovetimer_Tick);
            // 
            // rightmovetimer
            // 
            this.rightmovetimer.Interval = 5;
            this.rightmovetimer.Tick += new System.EventHandler(this.rightmovetimer_Tick);
            // 
            // downmovetimer
            // 
            this.downmovetimer.Interval = 5;
            this.downmovetimer.Tick += new System.EventHandler(this.downmovetimer_Tick);
            // 
            // upmovetimer
            // 
            this.upmovetimer.Interval = 5;
            this.upmovetimer.Tick += new System.EventHandler(this.upmovetimer_Tick);
            // 
            // movemunitiontimer
            // 
            this.movemunitiontimer.Enabled = true;
            this.movemunitiontimer.Interval = 20;
            this.movemunitiontimer.Tick += new System.EventHandler(this.movemunitiontimer_Tick);
            // 
            // moveenemiestimer
            // 
            this.moveenemiestimer.Enabled = true;
            this.moveenemiestimer.Tick += new System.EventHandler(this.moveenemiestimer_Tick);
            // 
            // EnemiesMunitionTimer
            // 
            this.EnemiesMunitionTimer.Enabled = true;
            this.EnemiesMunitionTimer.Interval = 20;
            this.EnemiesMunitionTimer.Tick += new System.EventHandler(this.EnemiesMunitionTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Mukhethwa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer MoveBackground;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer leftmovetimer;
        private System.Windows.Forms.Timer rightmovetimer;
        private System.Windows.Forms.Timer downmovetimer;
        private System.Windows.Forms.Timer upmovetimer;
        private System.Windows.Forms.Timer movemunitiontimer;
        private System.Windows.Forms.Timer moveenemiestimer;
        private System.Windows.Forms.Timer EnemiesMunitionTimer;
    }
}

