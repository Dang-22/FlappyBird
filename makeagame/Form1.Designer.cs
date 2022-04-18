
namespace makeagame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bird = new System.Windows.Forms.PictureBox();
            this.collumTop = new System.Windows.Forms.PictureBox();
            this.collumBottom = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            this.pause_btt = new System.Windows.Forms.Button();
            this.tt_btt = new System.Windows.Forms.Button();
            this.collumTop1 = new System.Windows.Forms.PictureBox();
            this.collumBottom1 = new System.Windows.Forms.PictureBox();
            this.logo_pic = new System.Windows.Forms.PictureBox();
            this.end_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.play_btt = new System.Windows.Forms.Button();
            this.restart_btt = new System.Windows.Forms.Button();
            this.exit_btt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_btt = new System.Windows.Forms.Button();
            this.check3 = new System.Windows.Forms.PictureBox();
            this.check2 = new System.Windows.Forms.PictureBox();
            this.check1 = new System.Windows.Forms.PictureBox();
            this.hard_btt = new System.Windows.Forms.Button();
            this.medium_btt = new System.Windows.Forms.Button();
            this.easy_btt = new System.Windows.Forms.Button();
            this.menu_btt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collumTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collumBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collumTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collumBottom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end_pic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check1)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.BackgroundImage = global::makeagame.Properties.Resources.xanh;
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(218, 196);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(47, 30);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // collumTop
            // 
            this.collumTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.collumTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("collumTop.BackgroundImage")));
            this.collumTop.Image = global::makeagame.Properties.Resources.pipedown;
            this.collumTop.Location = new System.Drawing.Point(597, -3);
            this.collumTop.Name = "collumTop";
            this.collumTop.Size = new System.Drawing.Size(75, 158);
            this.collumTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.collumTop.TabIndex = 1;
            this.collumTop.TabStop = false;
            // 
            // collumBottom
            // 
            this.collumBottom.BackColor = System.Drawing.Color.Green;
            this.collumBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.collumBottom.Image = global::makeagame.Properties.Resources.pipe;
            this.collumBottom.Location = new System.Drawing.Point(541, 313);
            this.collumBottom.Name = "collumBottom";
            this.collumBottom.Size = new System.Drawing.Size(70, 208);
            this.collumBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.collumBottom.TabIndex = 3;
            this.collumBottom.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Image = global::makeagame.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-40, 498);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(805, 146);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 4;
            this.Ground.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 20;
            this.Timer.Tick += new System.EventHandler(this.GameTimeEvent);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Score.Image = global::makeagame.Properties.Resources._46888871_624a3900_ce7f_11e8_808e_99fd90c8a3f4;
            this.Score.Location = new System.Drawing.Point(1, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(16, 16);
            this.Score.TabIndex = 5;
            this.Score.Text = " ";
            // 
            // pause_btt
            // 
            this.pause_btt.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pause_btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pause_btt.BackgroundImage")));
            this.pause_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pause_btt.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pause_btt.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.pause_btt.Location = new System.Drawing.Point(197, 531);
            this.pause_btt.Name = "pause_btt";
            this.pause_btt.Size = new System.Drawing.Size(68, 57);
            this.pause_btt.TabIndex = 6;
            this.pause_btt.UseVisualStyleBackColor = false;
            this.pause_btt.Click += new System.EventHandler(this.pause_btt_Click);
            this.pause_btt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pause_btt_MouseDown);
            // 
            // tt_btt
            // 
            this.tt_btt.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tt_btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tt_btt.BackgroundImage")));
            this.tt_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tt_btt.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tt_btt.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tt_btt.Location = new System.Drawing.Point(196, 531);
            this.tt_btt.Name = "tt_btt";
            this.tt_btt.Size = new System.Drawing.Size(69, 57);
            this.tt_btt.TabIndex = 7;
            this.tt_btt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tt_btt.UseVisualStyleBackColor = false;
            this.tt_btt.Click += new System.EventHandler(this.tt_btt_Click);
            // 
            // collumTop1
            // 
            this.collumTop1.BackColor = System.Drawing.Color.RoyalBlue;
            this.collumTop1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("collumTop1.BackgroundImage")));
            this.collumTop1.Image = global::makeagame.Properties.Resources.pipedown;
            this.collumTop1.Location = new System.Drawing.Point(861, -3);
            this.collumTop1.Name = "collumTop1";
            this.collumTop1.Size = new System.Drawing.Size(75, 114);
            this.collumTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.collumTop1.TabIndex = 1;
            this.collumTop1.TabStop = false;
            // 
            // collumBottom1
            // 
            this.collumBottom1.BackColor = System.Drawing.Color.Green;
            this.collumBottom1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.collumBottom1.Image = global::makeagame.Properties.Resources.pipe;
            this.collumBottom1.Location = new System.Drawing.Point(766, 264);
            this.collumBottom1.Name = "collumBottom1";
            this.collumBottom1.Size = new System.Drawing.Size(75, 257);
            this.collumBottom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.collumBottom1.TabIndex = 3;
            this.collumBottom1.TabStop = false;
            // 
            // logo_pic
            // 
            this.logo_pic.BackgroundImage = global::makeagame.Properties.Resources.xanh;
            this.logo_pic.Image = global::makeagame.Properties.Resources.flappy_bird_logo;
            this.logo_pic.Location = new System.Drawing.Point(23, 12);
            this.logo_pic.Name = "logo_pic";
            this.logo_pic.Size = new System.Drawing.Size(426, 108);
            this.logo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_pic.TabIndex = 8;
            this.logo_pic.TabStop = false;
            // 
            // end_pic
            // 
            this.end_pic.BackgroundImage = global::makeagame.Properties.Resources.xanh;
            this.end_pic.Image = global::makeagame.Properties.Resources.game_over_sprite;
            this.end_pic.Location = new System.Drawing.Point(134, 121);
            this.end_pic.Name = "end_pic";
            this.end_pic.Size = new System.Drawing.Size(196, 69);
            this.end_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.end_pic.TabIndex = 9;
            this.end_pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Image = global::makeagame.Properties.Resources.xanh;
            this.label1.Location = new System.Drawing.Point(158, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Click để bayy !!!";
            // 
            // play_btt
            // 
            this.play_btt.BackgroundImage = global::makeagame.Properties.Resources.Start_button_sprite;
            this.play_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play_btt.Location = new System.Drawing.Point(187, 259);
            this.play_btt.Name = "play_btt";
            this.play_btt.Size = new System.Drawing.Size(91, 35);
            this.play_btt.TabIndex = 11;
            this.play_btt.UseVisualStyleBackColor = true;
            this.play_btt.Click += new System.EventHandler(this.play_btt_Click);
            this.play_btt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.play_btt_KeyDown);
            // 
            // restart_btt
            // 
            this.restart_btt.BackgroundImage = global::makeagame.Properties.Resources.tải_xuống;
            this.restart_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.restart_btt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.restart_btt.Location = new System.Drawing.Point(168, 188);
            this.restart_btt.Name = "restart_btt";
            this.restart_btt.Size = new System.Drawing.Size(138, 50);
            this.restart_btt.TabIndex = 12;
            this.restart_btt.UseVisualStyleBackColor = true;
            this.restart_btt.Click += new System.EventHandler(this.restart_btt_Click);
            // 
            // exit_btt
            // 
            this.exit_btt.BackgroundImage = global::makeagame.Properties.Resources.exit;
            this.exit_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_btt.Location = new System.Drawing.Point(187, 300);
            this.exit_btt.Name = "exit_btt";
            this.exit_btt.Size = new System.Drawing.Size(91, 33);
            this.exit_btt.TabIndex = 13;
            this.exit_btt.UseVisualStyleBackColor = true;
            this.exit_btt.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::makeagame.Properties.Resources.qAjENX9;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.close_btt);
            this.panel1.Controls.Add(this.check3);
            this.panel1.Controls.Add(this.check2);
            this.panel1.Controls.Add(this.check1);
            this.panel1.Controls.Add(this.hard_btt);
            this.panel1.Controls.Add(this.medium_btt);
            this.panel1.Controls.Add(this.easy_btt);
            this.panel1.Location = new System.Drawing.Point(-5, -134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 814);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // close_btt
            // 
            this.close_btt.BackgroundImage = global::makeagame.Properties.Resources.pause1;
            this.close_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_btt.Location = new System.Drawing.Point(201, 416);
            this.close_btt.Name = "close_btt";
            this.close_btt.Size = new System.Drawing.Size(88, 63);
            this.close_btt.TabIndex = 4;
            this.close_btt.UseVisualStyleBackColor = true;
            this.close_btt.Click += new System.EventHandler(this.close_btt_Click);
            // 
            // check3
            // 
            this.check3.BackgroundImage = global::makeagame.Properties.Resources.check;
            this.check3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.check3.Location = new System.Drawing.Point(272, 574);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(30, 26);
            this.check3.TabIndex = 3;
            this.check3.TabStop = false;
            // 
            // check2
            // 
            this.check2.BackgroundImage = global::makeagame.Properties.Resources.check;
            this.check2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.check2.Location = new System.Drawing.Point(399, 515);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(30, 26);
            this.check2.TabIndex = 3;
            this.check2.TabStop = false;
            // 
            // check1
            // 
            this.check1.BackgroundImage = global::makeagame.Properties.Resources.check;
            this.check1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.check1.Location = new System.Drawing.Point(192, 515);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(30, 26);
            this.check1.TabIndex = 3;
            this.check1.TabStop = false;
            // 
            // hard_btt
            // 
            this.hard_btt.BackgroundImage = global::makeagame.Properties.Resources.hard;
            this.hard_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hard_btt.Location = new System.Drawing.Point(173, 564);
            this.hard_btt.Name = "hard_btt";
            this.hard_btt.Size = new System.Drawing.Size(138, 51);
            this.hard_btt.TabIndex = 2;
            this.hard_btt.UseVisualStyleBackColor = true;
            this.hard_btt.Click += new System.EventHandler(this.hard_btt_Click);
            // 
            // medium_btt
            // 
            this.medium_btt.BackgroundImage = global::makeagame.Properties.Resources.medium;
            this.medium_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.medium_btt.Location = new System.Drawing.Point(258, 503);
            this.medium_btt.Name = "medium_btt";
            this.medium_btt.Size = new System.Drawing.Size(181, 55);
            this.medium_btt.TabIndex = 1;
            this.medium_btt.UseVisualStyleBackColor = true;
            this.medium_btt.Click += new System.EventHandler(this.medium_btt_Click);
            // 
            // easy_btt
            // 
            this.easy_btt.BackgroundImage = global::makeagame.Properties.Resources.easy;
            this.easy_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.easy_btt.Location = new System.Drawing.Point(53, 503);
            this.easy_btt.Name = "easy_btt";
            this.easy_btt.Size = new System.Drawing.Size(181, 55);
            this.easy_btt.TabIndex = 0;
            this.easy_btt.UseVisualStyleBackColor = true;
            this.easy_btt.Click += new System.EventHandler(this.easy_btt_Click);
            // 
            // menu_btt
            // 
            this.menu_btt.BackgroundImage = global::makeagame.Properties.Resources.menu;
            this.menu_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_btt.Location = new System.Drawing.Point(187, 340);
            this.menu_btt.Name = "menu_btt";
            this.menu_btt.Size = new System.Drawing.Size(91, 35);
            this.menu_btt.TabIndex = 15;
            this.menu_btt.UseVisualStyleBackColor = true;
            this.menu_btt.Click += new System.EventHandler(this.menu_btt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(474, 586);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit_btt);
            this.Controls.Add(this.end_pic);
            this.Controls.Add(this.restart_btt);
            this.Controls.Add(this.play_btt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo_pic);
            this.Controls.Add(this.tt_btt);
            this.Controls.Add(this.pause_btt);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.collumTop1);
            this.Controls.Add(this.collumTop);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.menu_btt);
            this.Controls.Add(this.collumBottom);
            this.Controls.Add(this.collumBottom1);
            this.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collumTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collumBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collumTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collumBottom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.end_pic)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.check3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox collumTop;
        private System.Windows.Forms.PictureBox collumBottom;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button pause_btt;
        private System.Windows.Forms.Button tt_btt;
        private System.Windows.Forms.PictureBox collumTop1;
        private System.Windows.Forms.PictureBox collumBottom1;
        private System.Windows.Forms.PictureBox logo_pic;
        private System.Windows.Forms.PictureBox end_pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button play_btt;
        private System.Windows.Forms.Button restart_btt;
        private System.Windows.Forms.Button exit_btt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button medium_btt;
        private System.Windows.Forms.Button easy_btt;
        private System.Windows.Forms.Button hard_btt;
        private System.Windows.Forms.PictureBox check3;
        private System.Windows.Forms.PictureBox check2;
        private System.Windows.Forms.PictureBox check1;
        private System.Windows.Forms.Button close_btt;
        private System.Windows.Forms.Button menu_btt;
    }
}

