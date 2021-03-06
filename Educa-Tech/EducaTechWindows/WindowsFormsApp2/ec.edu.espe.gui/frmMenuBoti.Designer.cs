﻿using System.Windows.Forms;

namespace WindowsFormsApp2.ec.edu.espe.gui
{
    partial class frmMenuBoti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuBoti));
            this.picBlock2 = new System.Windows.Forms.PictureBox();
            this.picBlock1 = new System.Windows.Forms.PictureBox();
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.btnLevel3 = new System.Windows.Forms.Button();
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.picTittle = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnReturnPrincipalMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTittle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnPrincipalMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // picBlock2
            // 
            this.picBlock2.BackColor = System.Drawing.Color.Transparent;
            this.picBlock2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBlock2.Image = global::WindowsFormsApp2.Properties.Resources.nivel3lock;
            this.picBlock2.Location = new System.Drawing.Point(681, 496);
            this.picBlock2.Name = "picBlock2";
            this.picBlock2.Size = new System.Drawing.Size(153, 63);
            this.picBlock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlock2.TabIndex = 37;
            this.picBlock2.TabStop = false;
            // 
            // picBlock1
            // 
            this.picBlock1.BackColor = System.Drawing.Color.Transparent;
            this.picBlock1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBlock1.Image = global::WindowsFormsApp2.Properties.Resources.nivel2lock;
            this.picBlock1.Location = new System.Drawing.Point(441, 496);
            this.picBlock1.Name = "picBlock1";
            this.picBlock1.Size = new System.Drawing.Size(153, 63);
            this.picBlock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlock1.TabIndex = 36;
            this.picBlock1.TabStop = false;
            // 
            // btnLevel1
            // 
            this.btnLevel1.BackColor = System.Drawing.Color.Transparent;
            this.btnLevel1.Image = ((System.Drawing.Image)(resources.GetObject("btnLevel1.Image")));
            this.btnLevel1.Location = new System.Drawing.Point(204, 496);
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Size = new System.Drawing.Size(153, 63);
            this.btnLevel1.TabIndex = 30;
            this.btnLevel1.UseVisualStyleBackColor = false;
            this.btnLevel1.Click += new System.EventHandler(this.btnLevel1_Click);
            // 
            // btnLevel3
            // 
            this.btnLevel3.Image = ((System.Drawing.Image)(resources.GetObject("btnLevel3.Image")));
            this.btnLevel3.Location = new System.Drawing.Point(681, 496);
            this.btnLevel3.Name = "btnLevel3";
            this.btnLevel3.Size = new System.Drawing.Size(153, 63);
            this.btnLevel3.TabIndex = 32;
            this.btnLevel3.UseVisualStyleBackColor = true;
            this.btnLevel3.Visible = false;
            this.btnLevel3.Click += new System.EventHandler(this.btnLevel3_Click);
            // 
            // btnLevel2
            // 
            this.btnLevel2.Image = ((System.Drawing.Image)(resources.GetObject("btnLevel2.Image")));
            this.btnLevel2.Location = new System.Drawing.Point(441, 496);
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Size = new System.Drawing.Size(153, 63);
            this.btnLevel2.TabIndex = 31;
            this.btnLevel2.UseVisualStyleBackColor = true;
            this.btnLevel2.Visible = false;
            this.btnLevel2.Click += new System.EventHandler(this.btnLevel2_Click);
            // 
            // picHelp
            // 
            this.picHelp.BackColor = System.Drawing.Color.Transparent;
            this.picHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHelp.Image = global::WindowsFormsApp2.Properties.Resources.botiAprende;
            this.picHelp.Location = new System.Drawing.Point(344, 182);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(268, 217);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelp.TabIndex = 35;
            this.picHelp.TabStop = false;
            this.picHelp.Visible = false;
            // 
            // picTittle
            // 
            this.picTittle.BackColor = System.Drawing.Color.Transparent;
            this.picTittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTittle.Image = global::WindowsFormsApp2.Properties.Resources.Titulo1;
            this.picTittle.Location = new System.Drawing.Point(325, 31);
            this.picTittle.Name = "picTittle";
            this.picTittle.Size = new System.Drawing.Size(407, 217);
            this.picTittle.TabIndex = 33;
            this.picTittle.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(873, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "                                          ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(876, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 9);
            this.label3.TabIndex = 41;
            this.label3.Text = "                                                               ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(995, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 37);
            this.label2.TabIndex = 40;
            this.label2.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(781, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 37);
            this.label1.TabIndex = 39;
            this.label1.Text = "           ";
            // 
            // reproductor
            // 
            this.reproductor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reproductor.Enabled = true;
            this.reproductor.Location = new System.Drawing.Point(785, 3);
            this.reproductor.Name = "reproductor";
            this.reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reproductor.OcxState")));
            this.reproductor.Size = new System.Drawing.Size(236, 35);
            this.reproductor.TabIndex = 38;
            // 
            // btnReturnPrincipalMenu
            // 
            this.btnReturnPrincipalMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnPrincipalMenu.Image = global::WindowsFormsApp2.Properties.Resources.btnHomePrincipal_M1;
            this.btnReturnPrincipalMenu.Location = new System.Drawing.Point(871, 496);
            this.btnReturnPrincipalMenu.Name = "btnReturnPrincipalMenu";
            this.btnReturnPrincipalMenu.Size = new System.Drawing.Size(150, 142);
            this.btnReturnPrincipalMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReturnPrincipalMenu.TabIndex = 43;
            this.btnReturnPrincipalMenu.TabStop = false;
            this.btnReturnPrincipalMenu.Click += new System.EventHandler(this.btnReturnPrincipalMenu_Click);
            this.btnReturnPrincipalMenu.MouseEnter += new System.EventHandler(this.btnReturnPrincipalMenu_MouseEnter);
            this.btnReturnPrincipalMenu.MouseLeave += new System.EventHandler(this.btnReturnPrincipalMenu_MouseLeave);
            // 
            // frmMenuBoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.por;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.btnReturnPrincipalMenu);
            this.Controls.Add(this.picHelp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reproductor);
            this.Controls.Add(this.picBlock2);
            this.Controls.Add(this.picBlock1);
            this.Controls.Add(this.btnLevel1);
            this.Controls.Add(this.btnLevel3);
            this.Controls.Add(this.btnLevel2);
            this.Controls.Add(this.picTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuBoti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuBoti";
            this.Load += new System.EventHandler(this.frmMenuBoti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBlock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTittle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnPrincipalMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBlock2;
        private System.Windows.Forms.PictureBox picBlock1;
        private System.Windows.Forms.Button btnLevel1;
        private System.Windows.Forms.Button btnLevel3;
        private System.Windows.Forms.Button btnLevel2;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.PictureBox picTittle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer reproductor;
        private PictureBox btnReturnPrincipalMenu;

        public Button BtnLevel2 { get => btnLevel2; set => btnLevel2 = value; }
        public Button BtnLevel3 { get => btnLevel3; set => btnLevel3 = value; }
        public PictureBox PicBlock1 { get => picBlock1; set => picBlock1 = value; }
        public PictureBox PicBlock2 { get => picBlock2; set => picBlock2 = value; }
    }
}