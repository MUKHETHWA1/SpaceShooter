﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SpaceShooter
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootMedia;


        PictureBox[] stars;
        int backgroundspeed;
        int playerSpeed;

        PictureBox[] munitions;
        int MunitionSpeed;
        Random rnd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundspeed = 4;
            playerSpeed = 4;

            MunitionSpeed = 20;
            munitions = new PictureBox[3];

            //load images
          Image munition = Image.FromFile(@"asserts\munition.png");
           

            for (int i = 0; i < munitions.Length; i++)
            {
                munitions[i] = new PictureBox();
                munitions[i].Size = new Size(8,8);
                munitions[i].Image = munition;
                munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                munitions[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(munitions[i]);
            }

            //Create mp3
            gameMedia = new WindowsMediaPlayer();
            shootMedia = new WindowsMediaPlayer();

            //load all songs
            gameMedia.URL = "songs\\GameSong.mp3";
            shootMedia.URL = "songs\\shoot.mp3";

            //setup song settings
            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 5;
            shootMedia.settings.volume = 1;



            stars = new PictureBox[15];
            rnd = new Random();

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 500), rnd.Next(-10, 400));
                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.Wheat;
                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(stars[i]);
            }

            gameMedia.controls.play();
        }

        private void MoveBackground_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length / 2; i++)
            {
                stars[i].Top += backgroundspeed;

                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }

            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundspeed - 2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }

            }
        }

        private void leftmovetimer_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 10)
            {
                Player.Left -= playerSpeed;
            }
        }

        private void rightmovetimer_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 580)
            {
                Player.Left += playerSpeed;
            }
        }

        private void downmovetimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top < 400)
            {
                Player.Top += playerSpeed;
            }
        }

        private void upmovetimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 10)
            {
                Player.Top -= playerSpeed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                rightmovetimer.Start();
            }
            if(e.KeyCode == Keys.Left)
            {
                leftmovetimer.Start();
            }
            if (e.KeyCode == Keys.Down)
            {
                downmovetimer.Start();
            }
            if(e.KeyCode == Keys.Up)
            {
                upmovetimer.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            rightmovetimer.Stop();
            leftmovetimer.Stop();
            downmovetimer.Stop();
            upmovetimer.Stop();
        }

        private void movemunitiontimer_Tick(object sender, EventArgs e)
        {
            shootMedia.controls.play();
            for(int i = 0;i<munitions.Length;i++)
            {
                if (munitions[i].Top > 0)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top -= MunitionSpeed;
                }
                else
                {
                    munitions[i].Visible = false;
                    munitions[i].Location = new Point(Player.Location.X + 20,Player.Location.Y - i * 30);
                }
            }
        }
    }
}
