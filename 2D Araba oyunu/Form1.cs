using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_Araba_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void CoolCar_Click(object sender, EventArgs e)
        {

        }

        int serit_sayisi = 1, Road = 0, Speed = 70;
        Random R = new Random();

        class Random_CAR
        {
            public bool FakeHaveCar = false;
            public PictureBox FakeCar;
            public bool vakit = false;
        }
        Random_CAR[] rndCar = new Random_CAR[2];

        void BringRandomCar(PictureBox pb)
        {
            int rnd = R.Next(0, 4);

            switch (rnd)
            {
                case 0:
                    pb.Image = Properties.Resources.car0;
                    break;
                case 1:
                    pb.Image = Properties.Resources.car1;
                    break;
                case 2:
                    pb.Image = Properties.Resources.car2;
                    break;
                case 3:
                    pb.Image = Properties.Resources.car3;
                    break;
            }
            pb.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void AracYerine()
        {
            if (serit_sayisi == 1)
            {
                CoolCar.Location = new Point(270, 448);

            }
            else if (serit_sayisi == 0)
            {
                CoolCar.Location = new Point(55, 448);

            }
            if (serit_sayisi == 2)
            {
                CoolCar.Location = new Point(470, 448);

            }
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (serit_sayisi < 2)
                    serit_sayisi++;
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (serit_sayisi > 0)
                    serit_sayisi--;
            }

            AracYerine();
        }
        private void RandomMusic()
        {
            int MusicDeger = R.Next(1, 4);
            axWindowsMediaPlayer1.URL = @"music/track" + MusicDeger.ToString() + ".mp3";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (var i = 0; i < rndCar.Length; i++)
            {
                rndCar[i] = new Random_CAR();
            }
            rndCar[0].vakit = true;
            AracYerine();
            RandomMusic();
            labelHighScore.Text = Settings1.Default.HighScore.ToString();
        }
        bool SesKontrol = true;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (SesKontrol == true)
            {
                SesKontrol = false;
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                pictureBox2.Image = Properties.Resources.volumeOff;
            }
            else if (SesKontrol == false)
            {
                SesKontrol = true;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pictureBox2.Image = Properties.Resources.volumeON;
            }

        }

        private void timerRandomCar_Tick(object sender, EventArgs e)
        {


            for (int i = 0; i < rndCar.Length; i++)
            {
                if (!rndCar[i].FakeHaveCar && rndCar[i].vakit)
                {
                    rndCar[i].FakeCar = new PictureBox();
                    BringRandomCar(rndCar[i].FakeCar);
                    rndCar[i].FakeCar.Size = new Size(90, 150);
                    rndCar[i].FakeCar.Top = -rndCar[i].FakeCar.Height;

                    int sol_Yerles = R.Next(0, 3);

                    if (sol_Yerles == 0)
                    {

                        rndCar[i].FakeCar.Left = 55;

                    }
                    else if (sol_Yerles == 1)
                    {
                        rndCar[i].FakeCar.Left = 270;
                    }

                    else if (sol_Yerles == 2)
                    {
                        rndCar[i].FakeCar.Left = 470;
                    }


                    this.Controls.Add(rndCar[i].FakeCar);
                    rndCar[i].FakeHaveCar = true;

                }

                else
                {
                    if (rndCar[i].vakit)
                    {
                        rndCar[i].FakeCar.Top += 20;
                        if (rndCar[i].FakeCar.Top >= 154)
                        {
                            for (int j = 0; j < rndCar.Length; j++)
                            {
                                if (!rndCar[j].vakit)
                                {
                                    rndCar[j].vakit = true;
                                    break;
                                }
                            }
                        }
                        if (rndCar[i].FakeCar.Top >= this.Height - 20)
                        {
                            rndCar[i].FakeCar.Dispose();
                            rndCar[i].FakeHaveCar = false;
                            rndCar[i].vakit = false;
                        }
                    }

                }

                //kaza durumu

                if (rndCar[i].vakit)
                {
                    float MutlakX = Math.Abs(((CoolCar.Left + (CoolCar.Width / 2)) - (rndCar[i].FakeCar.Left + (rndCar[i].FakeCar.Width / 2))));
                    float MutlakY = Math.Abs((CoolCar.Top + (CoolCar.Height / 2)) - (rndCar[i].FakeCar.Top + (rndCar[i].FakeCar.Height / 2)));
                    float FarkGenislik = (CoolCar.Width / 2) + (rndCar[i].FakeCar.Width / 2);
                    float FarkYukseklik = (CoolCar.Height / 2) + (rndCar[i].FakeCar.Height / 2);

                    if ((FarkGenislik > MutlakX) && (FarkYukseklik > MutlakY))
                    {
                        timerRandomCar.Enabled = false;
                        timerSerit.Enabled = false;
                        axWindowsMediaPlayer1.Ctlcontrols.pause();
                        axWindowsMediaPlayer1.URL = @"music/crash.mp3";
                        axWindowsMediaPlayer1.Ctlcontrols.play();

                        if (Road > Settings1.Default.HighScore)
                        {
                            MessageBox.Show("New High score==>" + Road.ToString() + "m", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Settings1.Default.HighScore = Road;
                            Settings1.Default.Save();
                        }


                        DialogResult dr =MessageBox.Show("Game Over! wanna try again?","warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {

                            AracYerine();
                            for(int j = 0; j < rndCar.Length; j++)
                            {
                                rndCar[j].FakeCar.Dispose();
                                rndCar[j].FakeHaveCar = false;
                                rndCar[j].vakit = false;

                            }

                            Road = 0;
                            Speed = 70;
                            rndCar[0].vakit = true;
                            timerRandomCar.Enabled = true;
                            timerRandomCar.Interval = 200;

                            timerSerit.Enabled = true;
                            timerSerit.Interval = 200;

                            RandomMusic();
                            axWindowsMediaPlayer1.Ctlcontrols.play();

                            labelHighScore.Text = Settings1.Default.HighScore.ToString();
                        }

                        else
                        {
                            this.Close();
                        }

                    }



                }



            }

        }

        private void labelSpeed_Click(object sender, EventArgs e)
        {

        }

        bool SeritHareket = false;

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        void HizLevel()
        {
            //2.seviye
            if (Road > 150&& Road<300)
            {
                Speed = 100;
                timerSerit.Interval = 125;
                timerRandomCar.Interval = 100;
            }
            //3.seviye
            else if (Road > 300 && Road < 550)
            {
                Speed = 130;
                timerSerit.Interval = 100;
                timerRandomCar.Interval = 80;
            }
            //4.seviye
            else if (Road > 550)
            {
                Speed = 170;
                timerSerit.Interval = 80;
                timerRandomCar.Interval = 20;
            }

        }


        private void timerSerit_Tick(object sender, EventArgs e)
        {

            Road++;



            if (SeritHareket == false)
            {
                for (int i = 1; i < 6; i++)
                {
                    this.Controls.Find("labelSolSerit" + i.ToString(), true)[0].Top -= 25;
                    this.Controls.Find("labelSagSerit" + i.ToString(), true)[0].Top -= 25;
                    SeritHareket = true;
                }
            }
            else
            {
                for (int i = 1; i < 6; i++)
                {
                    this.Controls.Find("labelSolSerit" + i.ToString(), true)[0].Top += 25;
                    this.Controls.Find("labelSagSerit" + i.ToString(), true)[0].Top += 25;
                    SeritHareket = false;
                }
            }

            labelRoad.Text = Road.ToString() + "m";
            labelSpeed.Text = "Speed:"+Speed.ToString() + "km/h";
        }
    }
}
