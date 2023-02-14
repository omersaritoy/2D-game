namespace _2D_Araba_oyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSolSerit5 = new System.Windows.Forms.Label();
            this.labelSagSerit5 = new System.Windows.Forms.Label();
            this.labelSagSerit4 = new System.Windows.Forms.Label();
            this.labelSolSerit4 = new System.Windows.Forms.Label();
            this.labelSagSerit3 = new System.Windows.Forms.Label();
            this.labelSolSerit3 = new System.Windows.Forms.Label();
            this.labelSagSerit2 = new System.Windows.Forms.Label();
            this.labelSolSerit2 = new System.Windows.Forms.Label();
            this.labelSagSerit1 = new System.Windows.Forms.Label();
            this.labelSolSerit1 = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelRoad = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelHighScore = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CoolCar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerSerit = new System.Windows.Forms.Timer(this.components);
            this.timerRandomCar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoolCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(-1, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 702);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(650, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 702);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(35, 641);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(615, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // labelSolSerit5
            // 
            this.labelSolSerit5.BackColor = System.Drawing.Color.White;
            this.labelSolSerit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelSolSerit5.Location = new System.Drawing.Point(214, 9);
            this.labelSolSerit5.Name = "labelSolSerit5";
            this.labelSolSerit5.Size = new System.Drawing.Size(14, 119);
            this.labelSolSerit5.TabIndex = 3;
            this.labelSolSerit5.Text = "label4";
            this.labelSolSerit5.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // labelSagSerit5
            // 
            this.labelSagSerit5.BackColor = System.Drawing.Color.White;
            this.labelSagSerit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelSagSerit5.Location = new System.Drawing.Point(417, 9);
            this.labelSagSerit5.Name = "labelSagSerit5";
            this.labelSagSerit5.Size = new System.Drawing.Size(14, 119);
            this.labelSagSerit5.TabIndex = 4;
            this.labelSagSerit5.Text = "label5";
            // 
            // labelSagSerit4
            // 
            this.labelSagSerit4.BackColor = System.Drawing.Color.White;
            this.labelSagSerit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelSagSerit4.Location = new System.Drawing.Point(417, 140);
            this.labelSagSerit4.Name = "labelSagSerit4";
            this.labelSagSerit4.Size = new System.Drawing.Size(14, 119);
            this.labelSagSerit4.TabIndex = 6;
            this.labelSagSerit4.Text = "label6";
            // 
            // labelSolSerit4
            // 
            this.labelSolSerit4.BackColor = System.Drawing.Color.White;
            this.labelSolSerit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelSolSerit4.Location = new System.Drawing.Point(214, 140);
            this.labelSolSerit4.Name = "labelSolSerit4";
            this.labelSolSerit4.Size = new System.Drawing.Size(14, 119);
            this.labelSolSerit4.TabIndex = 5;
            this.labelSolSerit4.Text = "label7";
            // 
            // labelSagSerit3
            // 
            this.labelSagSerit3.BackColor = System.Drawing.Color.White;
            this.labelSagSerit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelSagSerit3.Location = new System.Drawing.Point(417, 274);
            this.labelSagSerit3.Name = "labelSagSerit3";
            this.labelSagSerit3.Size = new System.Drawing.Size(14, 119);
            this.labelSagSerit3.TabIndex = 8;
            this.labelSagSerit3.Text = "label8";
            // 
            // labelSolSerit3
            // 
            this.labelSolSerit3.BackColor = System.Drawing.Color.White;
            this.labelSolSerit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelSolSerit3.Location = new System.Drawing.Point(214, 274);
            this.labelSolSerit3.Name = "labelSolSerit3";
            this.labelSolSerit3.Size = new System.Drawing.Size(14, 119);
            this.labelSolSerit3.TabIndex = 7;
            this.labelSolSerit3.Text = "label9";
            // 
            // labelSagSerit2
            // 
            this.labelSagSerit2.BackColor = System.Drawing.Color.White;
            this.labelSagSerit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelSagSerit2.Location = new System.Drawing.Point(417, 418);
            this.labelSagSerit2.Name = "labelSagSerit2";
            this.labelSagSerit2.Size = new System.Drawing.Size(14, 119);
            this.labelSagSerit2.TabIndex = 10;
            this.labelSagSerit2.Text = "label10";
            // 
            // labelSolSerit2
            // 
            this.labelSolSerit2.BackColor = System.Drawing.Color.White;
            this.labelSolSerit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelSolSerit2.Location = new System.Drawing.Point(214, 418);
            this.labelSolSerit2.Name = "labelSolSerit2";
            this.labelSolSerit2.Size = new System.Drawing.Size(14, 119);
            this.labelSolSerit2.TabIndex = 9;
            this.labelSolSerit2.Text = "label11";
            // 
            // labelSagSerit1
            // 
            this.labelSagSerit1.BackColor = System.Drawing.Color.White;
            this.labelSagSerit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelSagSerit1.Location = new System.Drawing.Point(417, 551);
            this.labelSagSerit1.Name = "labelSagSerit1";
            this.labelSagSerit1.Size = new System.Drawing.Size(14, 91);
            this.labelSagSerit1.TabIndex = 12;
            this.labelSagSerit1.Text = "label12";
            // 
            // labelSolSerit1
            // 
            this.labelSolSerit1.BackColor = System.Drawing.Color.White;
            this.labelSolSerit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelSolSerit1.Location = new System.Drawing.Point(214, 551);
            this.labelSolSerit1.Name = "labelSolSerit1";
            this.labelSolSerit1.Size = new System.Drawing.Size(14, 91);
            this.labelSolSerit1.TabIndex = 11;
            this.labelSolSerit1.Text = "label13";
            // 
            // labelSpeed
            // 
            this.labelSpeed.BackColor = System.Drawing.Color.Black;
            this.labelSpeed.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.ForeColor = System.Drawing.Color.Transparent;
            this.labelSpeed.Location = new System.Drawing.Point(37, 649);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(158, 39);
            this.labelSpeed.TabIndex = 14;
            this.labelSpeed.Text = "Speed:0 km/H";
            this.labelSpeed.Click += new System.EventHandler(this.labelSpeed_Click);
            // 
            // labelRoad
            // 
            this.labelRoad.BackColor = System.Drawing.Color.Black;
            this.labelRoad.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoad.ForeColor = System.Drawing.Color.Transparent;
            this.labelRoad.Location = new System.Drawing.Point(211, 649);
            this.labelRoad.Name = "labelRoad";
            this.labelRoad.Size = new System.Drawing.Size(72, 23);
            this.labelRoad.TabIndex = 15;
            this.labelRoad.Text = "Road:";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(275, 649);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 23);
            this.label16.TabIndex = 16;
            this.label16.Text = "0 m";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Black;
            this.label18.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(417, 649);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 23);
            this.label18.TabIndex = 19;
            this.label18.Text = "High Score:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // labelHighScore
            // 
            this.labelHighScore.BackColor = System.Drawing.Color.Black;
            this.labelHighScore.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighScore.ForeColor = System.Drawing.Color.Transparent;
            this.labelHighScore.Location = new System.Drawing.Point(550, 649);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(114, 23);
            this.labelHighScore.TabIndex = 18;
            this.labelHighScore.Text = "0 m";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(104, 567);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(49, 33);
            this.axWindowsMediaPlayer1.TabIndex = 20;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CoolCar
            // 
            this.CoolCar.Image = global::_2D_Araba_oyunu.Properties.Resources.car0;
            this.CoolCar.Location = new System.Drawing.Point(264, 455);
            this.CoolCar.Name = "CoolCar";
            this.CoolCar.Size = new System.Drawing.Size(107, 173);
            this.CoolCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CoolCar.TabIndex = 13;
            this.CoolCar.TabStop = false;
            this.CoolCar.Click += new System.EventHandler(this.CoolCar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_2D_Araba_oyunu.Properties.Resources.volumeON;
            this.pictureBox2.Location = new System.Drawing.Point(606, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timerSerit
            // 
            this.timerSerit.Enabled = true;
            this.timerSerit.Interval = 150;
            this.timerSerit.Tick += new System.EventHandler(this.timerSerit_Tick);
            // 
            // timerRandomCar
            // 
            this.timerRandomCar.Enabled = true;
            this.timerRandomCar.Interval = 150;
            this.timerRandomCar.Tick += new System.EventHandler(this.timerRandomCar_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(687, 697);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.labelHighScore);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.labelRoad);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.CoolCar);
            this.Controls.Add(this.labelSagSerit1);
            this.Controls.Add(this.labelSolSerit1);
            this.Controls.Add(this.labelSagSerit2);
            this.Controls.Add(this.labelSolSerit2);
            this.Controls.Add(this.labelSagSerit3);
            this.Controls.Add(this.labelSolSerit3);
            this.Controls.Add(this.labelSagSerit4);
            this.Controls.Add(this.labelSolSerit4);
            this.Controls.Add(this.labelSagSerit5);
            this.Controls.Add(this.labelSolSerit5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoolCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSolSerit5;
        private System.Windows.Forms.Label labelSagSerit5;
        private System.Windows.Forms.Label labelSagSerit4;
        private System.Windows.Forms.Label labelSolSerit4;
        private System.Windows.Forms.Label labelSagSerit3;
        private System.Windows.Forms.Label labelSolSerit3;
        private System.Windows.Forms.Label labelSagSerit2;
        private System.Windows.Forms.Label labelSolSerit2;
        private System.Windows.Forms.Label labelSagSerit1;
        private System.Windows.Forms.Label labelSolSerit1;
        private System.Windows.Forms.PictureBox CoolCar;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelRoad;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelHighScore;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerSerit;
        private System.Windows.Forms.Timer timerRandomCar;
    }
}

