namespace MusicAppV1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.songTitleLabel2 = new CustomControllerMusic.SongTitleLabel();
            this.subtitleLabel2 = new CustomControllerMusic.SubtitleLabel();
            this.fileButton1 = new CustomControllerMusic.FileButton();
            this.closeButton1 = new CustomControllerMusic.CloseButton();
            this.rewindButton1 = new CustomControllerMusic.RewindButton();
            this.playNextOrRewindButton1 = new CustomControllerMusic.PlayNextOrRewindButton();
            this.playButton1 = new CustomControllerMusic.PlayButton();
            this.circularPictureBox1 = new CustomControllerMusic.CircularPictureBox();
            this.musicPlayerBackground1 = new CustomControllerMusic.MusicPlayerBackground();
            this.musicProgressBar1 = new CustomControllerMusic.MusicProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // songTitleLabel2
            // 
            this.songTitleLabel2.AutoSize = true;
            this.songTitleLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.songTitleLabel2.CustomForeColor = System.Drawing.Color.White;
            this.songTitleLabel2.CustomText = "Song name";
            this.songTitleLabel2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.songTitleLabel2.ForeColor = System.Drawing.Color.White;
            this.songTitleLabel2.Location = new System.Drawing.Point(357, 330);
            this.songTitleLabel2.Name = "songTitleLabel2";
            this.songTitleLabel2.Size = new System.Drawing.Size(142, 32);
            this.songTitleLabel2.TabIndex = 25;
            this.songTitleLabel2.Text = "Song name";
            this.songTitleLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtitleLabel2
            // 
            this.subtitleLabel2.AutoSize = true;
            this.subtitleLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.subtitleLabel2.CustomForeColor = System.Drawing.Color.LightGray;
            this.subtitleLabel2.CustomText = "C# F Mp3 Music Player";
            this.subtitleLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.subtitleLabel2.ForeColor = System.Drawing.Color.LightGray;
            this.subtitleLabel2.Location = new System.Drawing.Point(336, 384);
            this.subtitleLabel2.Name = "subtitleLabel2";
            this.subtitleLabel2.Size = new System.Drawing.Size(183, 23);
            this.subtitleLabel2.TabIndex = 24;
            this.subtitleLabel2.Text = "C# F Mp3 Music Player";
            this.subtitleLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.subtitleLabel2.Click += new System.EventHandler(this.subtitleLabel2_Click);
            // 
            // fileButton1
            // 
            this.fileButton1.BackColor = System.Drawing.Color.Maroon;
            this.fileButton1.ButtonColor = System.Drawing.Color.Maroon;
            this.fileButton1.ForeColor = System.Drawing.Color.White;
            this.fileButton1.Location = new System.Drawing.Point(274, 69);
            this.fileButton1.Name = "fileButton1";
            this.fileButton1.Size = new System.Drawing.Size(50, 50);
            this.fileButton1.TabIndex = 22;
            // 
            // closeButton1
            // 
            this.closeButton1.BackColor = System.Drawing.Color.Maroon;
            this.closeButton1.ButtonColor = System.Drawing.Color.Maroon;
            this.closeButton1.Location = new System.Drawing.Point(531, 69);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(50, 50);
            this.closeButton1.TabIndex = 21;
            // 
            // rewindButton1
            // 
            this.rewindButton1.BackColor = System.Drawing.Color.Maroon;
            this.rewindButton1.ButtonColor = System.Drawing.Color.Maroon;
            this.rewindButton1.Location = new System.Drawing.Point(465, 543);
            this.rewindButton1.Name = "rewindButton1";
            this.rewindButton1.RotateLeft = false;
            this.rewindButton1.Size = new System.Drawing.Size(50, 50);
            this.rewindButton1.TabIndex = 20;
            // 
            // playNextOrRewindButton1
            // 
            this.playNextOrRewindButton1.BackColor = System.Drawing.Color.Maroon;
            this.playNextOrRewindButton1.ButtonColor = System.Drawing.Color.Maroon;
            this.playNextOrRewindButton1.Location = new System.Drawing.Point(320, 543);
            this.playNextOrRewindButton1.Name = "playNextOrRewindButton1";
            this.playNextOrRewindButton1.RotateLeft = false;
            this.playNextOrRewindButton1.Size = new System.Drawing.Size(50, 50);
            this.playNextOrRewindButton1.TabIndex = 19;
            // 
            // playButton1
            // 
            this.playButton1.BackColor = System.Drawing.Color.Maroon;
            this.playButton1.ButtonColor = System.Drawing.Color.Maroon;
            this.playButton1.Location = new System.Drawing.Point(392, 543);
            this.playButton1.Name = "playButton1";
            this.playButton1.Size = new System.Drawing.Size(50, 50);
            this.playButton1.TabIndex = 18;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.circularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.circularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.circularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.circularPictureBox1.BorderSize = 2;
            this.circularPictureBox1.GradientAngle = 50F;
            this.circularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.Image")));
            this.circularPictureBox1.Location = new System.Drawing.Point(330, 113);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(185, 185);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 4;
            this.circularPictureBox1.TabStop = false;
            // 
            // musicPlayerBackground1
            // 
            this.musicPlayerBackground1.BackColor = System.Drawing.Color.Black;
            this.musicPlayerBackground1.BackgroundColor = System.Drawing.Color.Black;
            this.musicPlayerBackground1.Location = new System.Drawing.Point(252, 48);
            this.musicPlayerBackground1.Name = "musicPlayerBackground1";
            this.musicPlayerBackground1.Size = new System.Drawing.Size(345, 567);
            this.musicPlayerBackground1.TabIndex = 0;
            this.musicPlayerBackground1.Load += new System.EventHandler(this.musicPlayerBackground1_Load);
            // 
            // musicProgressBar1
            // 
            this.musicProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.musicProgressBar1.BarColor = System.Drawing.Color.Gray;
            this.musicProgressBar1.CircleColor = System.Drawing.Color.DarkRed;
            this.musicProgressBar1.Location = new System.Drawing.Point(274, 495);
            this.musicProgressBar1.Name = "musicProgressBar1";
            this.musicProgressBar1.Progress = 0;
            this.musicProgressBar1.ProgressColor = System.Drawing.Color.Red;
            this.musicProgressBar1.Size = new System.Drawing.Size(307, 30);
            this.musicProgressBar1.TabIndex = 26;
            this.musicProgressBar1.TotalTime = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1053, 670);
            this.Controls.Add(this.musicProgressBar1);
            this.Controls.Add(this.songTitleLabel2);
            this.Controls.Add(this.subtitleLabel2);
            this.Controls.Add(this.fileButton1);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.rewindButton1);
            this.Controls.Add(this.playNextOrRewindButton1);
            this.Controls.Add(this.playButton1);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.musicPlayerBackground1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControllerMusic.MusicPlayerBackground musicPlayerBackground1;
        private CustomControllerMusic.CircularPictureBox circularPictureBox1;
        private CustomControllerMusic.PlayButton playButton1;
        private CustomControllerMusic.PlayNextOrRewindButton playNextOrRewindButton1;
        private CustomControllerMusic.RewindButton rewindButton1;
        private CustomControllerMusic.CloseButton closeButton1;
        private CustomControllerMusic.FileButton fileButton1;
        private CustomControllerMusic.SubtitleLabel subtitleLabel2;
        private CustomControllerMusic.SongTitleLabel songTitleLabel2;
        private CustomControllerMusic.MusicProgressBar musicProgressBar1;
    }
}

