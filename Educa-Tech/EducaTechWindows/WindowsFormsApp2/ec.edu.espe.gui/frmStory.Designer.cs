﻿namespace WindowsFormsApp2
{
    partial class frmStory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStory));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer9 = new System.Windows.Forms.Timer(this.components);
            this.picHide = new System.Windows.Forms.PictureBox();
            this.btnMenuJirenSec = new System.Windows.Forms.PictureBox();
            this.picNumber4 = new System.Windows.Forms.PictureBox();
            this.picNumber3 = new System.Windows.Forms.PictureBox();
            this.picNumber2 = new System.Windows.Forms.PictureBox();
            this.picNumber1 = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.picNextPage = new System.Windows.Forms.PictureBox();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.picImage4 = new System.Windows.Forms.PictureBox();
            this.picImage3 = new System.Windows.Forms.PictureBox();
            this.picImage1 = new System.Windows.Forms.PictureBox();
            this.picImage2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuJirenSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumber4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumber3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumber2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick_1);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick_1);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick_1);
            // 
            // timer7
            // 
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick_1);
            // 
            // timer8
            // 
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick_1);
            // 
            // reproductor
            // 
            this.reproductor.Enabled = true;
            this.reproductor.Location = new System.Drawing.Point(830, 731);
            this.reproductor.Margin = new System.Windows.Forms.Padding(4);
            this.reproductor.Name = "reproductor";
            this.reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reproductor.OcxState")));
            this.reproductor.Size = new System.Drawing.Size(256, 63);
            this.reproductor.TabIndex = 23;
            this.reproductor.Enter += new System.EventHandler(this.reproductor_Enter);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(807, 11);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(211, 34);
            this.player.TabIndex = 32;
            // 
            // picHide
            // 
            this.picHide.BackColor = System.Drawing.Color.Transparent;
            this.picHide.Location = new System.Drawing.Point(1105, 14);
            this.picHide.Margin = new System.Windows.Forms.Padding(4);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(121, 62);
            this.picHide.TabIndex = 42;
            this.picHide.TabStop = false;
            // 
            // btnMenuJirenSec
            // 
            this.btnMenuJirenSec.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuJirenSec.Image = global::WindowsFormsApp2.Properties.Resources.btnReturn_M12;
            this.btnMenuJirenSec.Location = new System.Drawing.Point(16, 11);
            this.btnMenuJirenSec.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuJirenSec.Name = "btnMenuJirenSec";
            this.btnMenuJirenSec.Size = new System.Drawing.Size(100, 100);
            this.btnMenuJirenSec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenuJirenSec.TabIndex = 41;
            this.btnMenuJirenSec.TabStop = false;
            this.btnMenuJirenSec.Click += new System.EventHandler(this.btnMenuJirenSec_Click);
            this.btnMenuJirenSec.MouseEnter += new System.EventHandler(this.btnMenuJirenSec_MouseEnter);
            this.btnMenuJirenSec.MouseLeave += new System.EventHandler(this.btnMenuJirenSec_MouseLeave);
            // 
            // picNumber4
            // 
            this.picNumber4.BackColor = System.Drawing.Color.Transparent;
            this.picNumber4.Location = new System.Drawing.Point(724, 479);
            this.picNumber4.Margin = new System.Windows.Forms.Padding(4);
            this.picNumber4.Name = "picNumber4";
            this.picNumber4.Size = new System.Drawing.Size(77, 118);
            this.picNumber4.TabIndex = 40;
            this.picNumber4.TabStop = false;
            // 
            // picNumber3
            // 
            this.picNumber3.BackColor = System.Drawing.Color.Transparent;
            this.picNumber3.Location = new System.Drawing.Point(113, 479);
            this.picNumber3.Margin = new System.Windows.Forms.Padding(4);
            this.picNumber3.Name = "picNumber3";
            this.picNumber3.Size = new System.Drawing.Size(77, 118);
            this.picNumber3.TabIndex = 39;
            this.picNumber3.TabStop = false;
            // 
            // picNumber2
            // 
            this.picNumber2.BackColor = System.Drawing.Color.Transparent;
            this.picNumber2.Location = new System.Drawing.Point(724, 202);
            this.picNumber2.Margin = new System.Windows.Forms.Padding(4);
            this.picNumber2.Name = "picNumber2";
            this.picNumber2.Size = new System.Drawing.Size(77, 118);
            this.picNumber2.TabIndex = 38;
            this.picNumber2.TabStop = false;
            // 
            // picNumber1
            // 
            this.picNumber1.BackColor = System.Drawing.Color.Transparent;
            this.picNumber1.Location = new System.Drawing.Point(113, 202);
            this.picNumber1.Margin = new System.Windows.Forms.Padding(4);
            this.picNumber1.Name = "picNumber1";
            this.picNumber1.Size = new System.Drawing.Size(77, 118);
            this.picNumber1.TabIndex = 37;
            this.picNumber1.TabStop = false;
            // 
            // picNext
            // 
            this.picNext.BackColor = System.Drawing.Color.Transparent;
            this.picNext.Image = global::WindowsFormsApp2.Properties.Resources.btnNext_M1;
            this.picNext.Location = new System.Drawing.Point(737, 710);
            this.picNext.Margin = new System.Windows.Forms.Padding(4);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(100, 100);
            this.picNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNext.TabIndex = 31;
            this.picNext.TabStop = false;
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            this.picNext.MouseEnter += new System.EventHandler(this.picNext_MouseEnter);
            this.picNext.MouseLeave += new System.EventHandler(this.picNext_MouseLeave);
            // 
            // picBack
            // 
            this.picBack.BackColor = System.Drawing.Color.Transparent;
            this.picBack.Image = global::WindowsFormsApp2.Properties.Resources.btnPreview_M1;
            this.picBack.Location = new System.Drawing.Point(484, 710);
            this.picBack.Margin = new System.Windows.Forms.Padding(4);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(100, 100);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBack.TabIndex = 30;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            this.picBack.MouseEnter += new System.EventHandler(this.picBack_MouseEnter);
            this.picBack.MouseLeave += new System.EventHandler(this.picBack_MouseLeave);
            // 
            // picPlay
            // 
            this.picPlay.BackColor = System.Drawing.Color.Transparent;
            this.picPlay.Image = global::WindowsFormsApp2.Properties.Resources.btnPlay_M1;
            this.picPlay.Location = new System.Drawing.Point(613, 708);
            this.picPlay.Margin = new System.Windows.Forms.Padding(4);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(100, 100);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlay.TabIndex = 29;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            this.picPlay.MouseEnter += new System.EventHandler(this.picBegin_MouseEnter);
            this.picPlay.MouseLeave += new System.EventHandler(this.picBegin_MouseLeave);
            // 
            // picNextPage
            // 
            this.picNextPage.BackColor = System.Drawing.Color.Transparent;
            this.picNextPage.Image = global::WindowsFormsApp2.Properties.Resources.btnContinueGame_M1;
            this.picNextPage.Location = new System.Drawing.Point(888, 708);
            this.picNextPage.Margin = new System.Windows.Forms.Padding(4);
            this.picNextPage.Name = "picNextPage";
            this.picNextPage.Size = new System.Drawing.Size(100, 100);
            this.picNextPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNextPage.TabIndex = 22;
            this.picNextPage.TabStop = false;
            this.picNextPage.Click += new System.EventHandler(this.pictureBox1_Click);
            this.picNextPage.DragEnter += new System.Windows.Forms.DragEventHandler(this.picNextPage_DragEnter);
            this.picNextPage.DragLeave += new System.EventHandler(this.picNextPage_DragLeave);
            this.picNextPage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.picNextPage.MouseEnter += new System.EventHandler(this.picNextPage_MouseEnter);
            this.picNextPage.MouseLeave += new System.EventHandler(this.picNextPage_MouseLeave);
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.Location = new System.Drawing.Point(275, 14);
            this.picTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(832, 118);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitle.TabIndex = 20;
            this.picTitle.TabStop = false;
            // 
            // picImage4
            // 
            this.picImage4.BackColor = System.Drawing.Color.Transparent;
            this.picImage4.Location = new System.Drawing.Point(801, 426);
            this.picImage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picImage4.Name = "picImage4";
            this.picImage4.Size = new System.Drawing.Size(400, 246);
            this.picImage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage4.TabIndex = 19;
            this.picImage4.TabStop = false;
            this.picImage4.Click += new System.EventHandler(this.picImage4_Click);
            // 
            // picImage3
            // 
            this.picImage3.BackColor = System.Drawing.Color.Transparent;
            this.picImage3.Location = new System.Drawing.Point(190, 426);
            this.picImage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picImage3.Name = "picImage3";
            this.picImage3.Size = new System.Drawing.Size(400, 246);
            this.picImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage3.TabIndex = 18;
            this.picImage3.TabStop = false;
            this.picImage3.Click += new System.EventHandler(this.picImage3_Click);
            // 
            // picImage1
            // 
            this.picImage1.BackColor = System.Drawing.Color.Transparent;
            this.picImage1.Location = new System.Drawing.Point(190, 150);
            this.picImage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picImage1.Name = "picImage1";
            this.picImage1.Size = new System.Drawing.Size(400, 246);
            this.picImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage1.TabIndex = 17;
            this.picImage1.TabStop = false;
            this.picImage1.Click += new System.EventHandler(this.picImage1_Click);
            // 
            // picImage2
            // 
            this.picImage2.BackColor = System.Drawing.Color.Transparent;
            this.picImage2.Location = new System.Drawing.Point(801, 150);
            this.picImage2.Margin = new System.Windows.Forms.Padding(4);
            this.picImage2.Name = "picImage2";
            this.picImage2.Size = new System.Drawing.Size(400, 246);
            this.picImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage2.TabIndex = 21;
            this.picImage2.TabStop = false;
            this.picImage2.Click += new System.EventHandler(this.picImage2_Click);
            // 
            // frmStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.fondo_2;
            this.ClientSize = new System.Drawing.Size(1373, 820);
            this.Controls.Add(this.picHide);
            this.Controls.Add(this.btnMenuJirenSec);
            this.Controls.Add(this.picNumber4);
            this.Controls.Add(this.picNumber3);
            this.Controls.Add(this.picNumber2);
            this.Controls.Add(this.picNumber1);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.reproductor);
            this.Controls.Add(this.picNextPage);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.picImage4);
            this.Controls.Add(this.picImage3);
            this.Controls.Add(this.picImage1);
            this.Controls.Add(this.picImage2);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JirenSec";
            this.Load += new System.EventHandler(this.frmStory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuJirenSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumber4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumber3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumber2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.PictureBox picImage4;
        private System.Windows.Forms.PictureBox picImage3;
        private System.Windows.Forms.PictureBox picImage1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.PictureBox picImage2;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.PictureBox picNextPage;
        private AxWMPLib.AxWindowsMediaPlayer reproductor;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.PictureBox picNext;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Timer timer9;
        private System.Windows.Forms.PictureBox picNumber4;
        private System.Windows.Forms.PictureBox picNumber3;
        private System.Windows.Forms.PictureBox picNumber2;
        private System.Windows.Forms.PictureBox picNumber1;
        private System.Windows.Forms.PictureBox btnMenuJirenSec;
        private System.Windows.Forms.PictureBox picHide;
    }
}