namespace WinAppEducaTech
{
    partial class frmMenuPrincipal
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
            this.btnExitApplication = new System.Windows.Forms.PictureBox();
            this.picBotiAprende = new System.Windows.Forms.PictureBox();
            this.picJirenSec = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBotiAprende)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJirenSec)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.BackColor = System.Drawing.Color.Transparent;
            this.btnExitApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitApplication.Image = global::WindowsFormsApp2.Properties.Resources.btnExitProgram_M1;
            this.btnExitApplication.Location = new System.Drawing.Point(1164, 13);
            this.btnExitApplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(150, 150);
            this.btnExitApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExitApplication.TabIndex = 39;
            this.btnExitApplication.TabStop = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            this.btnExitApplication.MouseEnter += new System.EventHandler(this.btnExitApplication_MouseEnter);
            this.btnExitApplication.MouseLeave += new System.EventHandler(this.btnExitApplication_MouseLeave);
            // 
            // picBotiAprende
            // 
            this.picBotiAprende.BackColor = System.Drawing.Color.Transparent;
            this.picBotiAprende.Image = global::WindowsFormsApp2.Properties.Resources.btnGame_M1;
            this.picBotiAprende.Location = new System.Drawing.Point(190, 548);
            this.picBotiAprende.Name = "picBotiAprende";
            this.picBotiAprende.Size = new System.Drawing.Size(237, 213);
            this.picBotiAprende.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBotiAprende.TabIndex = 40;
            this.picBotiAprende.TabStop = false;
            this.picBotiAprende.Click += new System.EventHandler(this.picBotiAprende_Click);
            this.picBotiAprende.MouseEnter += new System.EventHandler(this.picBotiAprende_MouseEnter);
            this.picBotiAprende.MouseLeave += new System.EventHandler(this.picBotiAprende_MouseLeave);
            // 
            // picJirenSec
            // 
            this.picJirenSec.BackColor = System.Drawing.Color.Transparent;
            this.picJirenSec.Image = global::WindowsFormsApp2.Properties.Resources.btnGame_M1;
            this.picJirenSec.Location = new System.Drawing.Point(894, 551);
            this.picJirenSec.Name = "picJirenSec";
            this.picJirenSec.Size = new System.Drawing.Size(237, 213);
            this.picJirenSec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJirenSec.TabIndex = 41;
            this.picJirenSec.TabStop = false;
            this.picJirenSec.Click += new System.EventHandler(this.picJirenSec_Click);
            this.picJirenSec.MouseEnter += new System.EventHandler(this.picJirenSec_MouseEnter);
            this.picJirenSec.MouseLeave += new System.EventHandler(this.picJirenSec_MouseLeave);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.WALL2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 874);
            this.Controls.Add(this.picJirenSec);
            this.Controls.Add(this.picBotiAprende);
            this.Controls.Add(this.btnExitApplication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExitApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBotiAprende)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJirenSec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnExitApplication;
        private System.Windows.Forms.PictureBox picBotiAprende;
        private System.Windows.Forms.PictureBox picJirenSec;
    }
}

