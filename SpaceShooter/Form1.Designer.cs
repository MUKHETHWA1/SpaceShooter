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
            this.exitBtn = new System.Windows.Forms.Button();
            this.replayBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.levellb1 = new System.Windows.Forms.Label();
            this.scorelb1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(167, 240);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(240, 69);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Visible = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // replayBtn
            // 
            this.replayBtn.Location = new System.Drawing.Point(167, 156);
            this.replayBtn.Name = "replayBtn";
            this.replayBtn.Size = new System.Drawing.Size(240, 69);
            this.replayBtn.TabIndex = 2;
            this.replayBtn.Text = "Replay";
            this.replayBtn.UseVisualStyleBackColor = true;
            this.replayBtn.Visible = false;
            this.replayBtn.Click += new System.EventHandler(this.replayBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // levellb1
            // 
            this.levellb1.AutoSize = true;
            this.levellb1.Location = new System.Drawing.Point(473, 45);
            this.levellb1.Name = "levellb1";
            this.levellb1.Size = new System.Drawing.Size(0, 13);
            this.levellb1.TabIndex = 4;
            // 
            // scorelb1
            // 
            this.scorelb1.AutoSize = true;
            this.scorelb1.Location = new System.Drawing.Point(82, 45);
            this.scorelb1.Name = "scorelb1";
            this.scorelb1.Size = new System.Drawing.Size(0, 13);
            this.scorelb1.TabIndex = 5;
            this.scorelb1.Click += new System.EventHandler(this.scorelb1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "level: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scorelb1);
            this.Controls.Add(this.levellb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.replayBtn);
            this.Controls.Add(this.exitBtn);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button replayBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label levellb1;
        private System.Windows.Forms.Label scorelb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

