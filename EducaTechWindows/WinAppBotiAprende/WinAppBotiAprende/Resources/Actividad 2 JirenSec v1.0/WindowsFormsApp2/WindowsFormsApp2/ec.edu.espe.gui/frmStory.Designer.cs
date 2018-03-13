namespace WindowsFormsApp2
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
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.picImage4 = new System.Windows.Forms.PictureBox();
            this.picImage3 = new System.Windows.Forms.PictureBox();
            this.picImage1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.picImage2 = new System.Windows.Forms.PictureBox();
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.Location = new System.Drawing.Point(9, 62);
            this.picTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(728, 126);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitle.TabIndex = 20;
            this.picTitle.TabStop = false;
            // 
            // picImage4
            // 
            this.picImage4.Location = new System.Drawing.Point(399, 448);
            this.picImage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picImage4.Name = "picImage4";
            this.picImage4.Size = new System.Drawing.Size(300, 200);
            this.picImage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage4.TabIndex = 19;
            this.picImage4.TabStop = false;
            this.picImage4.Click += new System.EventHandler(this.picImage4_Click);
            // 
            // picImage3
            // 
            this.picImage3.Location = new System.Drawing.Point(33, 448);
            this.picImage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picImage3.Name = "picImage3";
            this.picImage3.Size = new System.Drawing.Size(300, 200);
            this.picImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage3.TabIndex = 18;
            this.picImage3.TabStop = false;
            this.picImage3.Click += new System.EventHandler(this.picImage3_Click);
            // 
            // picImage1
            // 
            this.picImage1.Location = new System.Drawing.Point(33, 215);
            this.picImage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picImage1.Name = "picImage1";
            this.picImage1.Size = new System.Drawing.Size(300, 200);
            this.picImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage1.TabIndex = 17;
            this.picImage1.TabStop = false;
            this.picImage1.Click += new System.EventHandler(this.picImage1_Click);
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
            // picImage2
            // 
            this.picImage2.Location = new System.Drawing.Point(399, 215);
            this.picImage2.Name = "picImage2";
            this.picImage2.Size = new System.Drawing.Size(300, 200);
            this.picImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage2.TabIndex = 21;
            this.picImage2.TabStop = false;
            this.picImage2.Click += new System.EventHandler(this.picImage2_Click);
            // 
            // timer8
            // 
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick_1);
            // 
            // frmStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.fondo_2;
            this.ClientSize = new System.Drawing.Size(746, 603);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.picImage4);
            this.Controls.Add(this.picImage3);
            this.Controls.Add(this.picImage1);
            this.Controls.Add(this.picImage2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JirenSec";
            this.Load += new System.EventHandler(this.frmStory_Load);
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
    }
}