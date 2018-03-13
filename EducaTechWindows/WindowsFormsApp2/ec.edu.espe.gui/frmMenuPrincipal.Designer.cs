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
            this.btnJirenSec = new System.Windows.Forms.Label();
            this.btnBotiAprende = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.BackColor = System.Drawing.Color.Transparent;
            this.btnExitApplication.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.exit;
            this.btnExitApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitApplication.Location = new System.Drawing.Point(872, 2);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(133, 119);
            this.btnExitApplication.TabIndex = 39;
            this.btnExitApplication.TabStop = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // btnJirenSec
            // 
            this.btnJirenSec.AutoSize = true;
            this.btnJirenSec.BackColor = System.Drawing.Color.Transparent;
            this.btnJirenSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJirenSec.Font = new System.Drawing.Font("Segoe Script", 81.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJirenSec.ForeColor = System.Drawing.Color.Transparent;
            this.btnJirenSec.Location = new System.Drawing.Point(674, 445);
            this.btnJirenSec.Name = "btnJirenSec";
            this.btnJirenSec.Size = new System.Drawing.Size(165, 181);
            this.btnJirenSec.TabIndex = 38;
            this.btnJirenSec.Text = "  ";
            this.btnJirenSec.Click += new System.EventHandler(this.btnJirenSec_Click);
            // 
            // btnBotiAprende
            // 
            this.btnBotiAprende.AutoSize = true;
            this.btnBotiAprende.BackColor = System.Drawing.Color.Transparent;
            this.btnBotiAprende.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBotiAprende.Font = new System.Drawing.Font("Segoe Script", 81.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotiAprende.ForeColor = System.Drawing.Color.Transparent;
            this.btnBotiAprende.Location = new System.Drawing.Point(147, 445);
            this.btnBotiAprende.Name = "btnBotiAprende";
            this.btnBotiAprende.Size = new System.Drawing.Size(165, 181);
            this.btnBotiAprende.TabIndex = 37;
            this.btnBotiAprende.Text = "  ";
            this.btnBotiAprende.Click += new System.EventHandler(this.btnBotiAprende_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.WALL2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 710);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.btnJirenSec);
            this.Controls.Add(this.btnBotiAprende);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExitApplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnExitApplication;
        private System.Windows.Forms.Label btnJirenSec;
        private System.Windows.Forms.Label btnBotiAprende;
    }
}

