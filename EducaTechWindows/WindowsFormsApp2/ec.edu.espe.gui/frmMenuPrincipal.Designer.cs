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
            this.picGameBotiAprende = new System.Windows.Forms.PictureBox();
            this.picGameJirenSec = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameBotiAprende)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameJirenSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.BackColor = System.Drawing.Color.Transparent;
            this.btnExitApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitApplication.Image = global::WindowsFormsApp2.Properties.Resources.btnExitProgram_M1;
            this.btnExitApplication.Location = new System.Drawing.Point(1214, 13);
            this.btnExitApplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(100, 100);
            this.btnExitApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExitApplication.TabIndex = 39;
            this.btnExitApplication.TabStop = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            this.btnExitApplication.MouseEnter += new System.EventHandler(this.btnExitApplication_MouseEnter);
            this.btnExitApplication.MouseLeave += new System.EventHandler(this.btnExitApplication_MouseLeave);
            // 
            // picGameBotiAprende
            // 
            this.picGameBotiAprende.BackColor = System.Drawing.Color.Transparent;
            this.picGameBotiAprende.Image = global::WindowsFormsApp2.Properties.Resources.btnGameBotiAprende_M1;
            this.picGameBotiAprende.Location = new System.Drawing.Point(79, 360);
            this.picGameBotiAprende.Margin = new System.Windows.Forms.Padding(4);
            this.picGameBotiAprende.Name = "picGameBotiAprende";
            this.picGameBotiAprende.Size = new System.Drawing.Size(465, 325);
            this.picGameBotiAprende.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGameBotiAprende.TabIndex = 42;
            this.picGameBotiAprende.TabStop = false;
            this.picGameBotiAprende.Click += new System.EventHandler(this.picGameBotiAprende_Click);
            this.picGameBotiAprende.MouseEnter += new System.EventHandler(this.picGameBotiAprende_MouseEnter);
            this.picGameBotiAprende.MouseLeave += new System.EventHandler(this.picGameBotiAprende_MouseLeave);
            // 
            // picGameJirenSec
            // 
            this.picGameJirenSec.BackColor = System.Drawing.Color.Transparent;
            this.picGameJirenSec.Image = global::WindowsFormsApp2.Properties.Resources.btnGameJirenSec_M1;
            this.picGameJirenSec.Location = new System.Drawing.Point(894, 365);
            this.picGameJirenSec.Margin = new System.Windows.Forms.Padding(4);
            this.picGameJirenSec.Name = "picGameJirenSec";
            this.picGameJirenSec.Size = new System.Drawing.Size(420, 320);
            this.picGameJirenSec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGameJirenSec.TabIndex = 43;
            this.picGameJirenSec.TabStop = false;
            this.picGameJirenSec.Click += new System.EventHandler(this.picGameJirenSec_Click);
            this.picGameJirenSec.MouseEnter += new System.EventHandler(this.picGameJirenSec_MouseEnter);
            this.picGameJirenSec.MouseLeave += new System.EventHandler(this.picGameJirenSec_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::WindowsFormsApp2.Properties.Resources.LOGO;
            this.pictureBox3.Location = new System.Drawing.Point(198, 59);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(885, 157);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 788);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.picGameJirenSec);
            this.Controls.Add(this.picGameBotiAprende);
            this.Controls.Add(this.btnExitApplication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExitApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameBotiAprende)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameJirenSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnExitApplication;
        private System.Windows.Forms.PictureBox picGameBotiAprende;
        private System.Windows.Forms.PictureBox picGameJirenSec;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

