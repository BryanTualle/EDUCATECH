using System.Windows.Forms;

namespace WinAppBotiAprende
{
    partial class frmBotiAprendeNivel2
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
            this.PanelJuego = new System.Windows.Forms.Panel();
            this.picScores = new System.Windows.Forms.PictureBox();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.lblScores = new System.Windows.Forms.Label();
            this.esconderCartas = new System.Windows.Forms.Timer(this.components);
            this.AbrirCartas = new System.Windows.Forms.Timer(this.components);
            this.btnRestart = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.ScoreTime = new System.Windows.Forms.Timer(this.components);
            this.timerGrades = new System.Windows.Forms.Label();
            this.PanelJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelJuego
            // 
            this.PanelJuego.BackColor = System.Drawing.Color.Transparent;
            this.PanelJuego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelJuego.Controls.Add(this.picScores);
            this.PanelJuego.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelJuego.Location = new System.Drawing.Point(74, 110);
            this.PanelJuego.Name = "PanelJuego";
            this.PanelJuego.Size = new System.Drawing.Size(868, 587);
            this.PanelJuego.TabIndex = 0;
            // 
            // picScores
            // 
            this.picScores.BackColor = System.Drawing.Color.Transparent;
            this.picScores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picScores.Location = new System.Drawing.Point(130, 52);
            this.picScores.Name = "picScores";
            this.picScores.Size = new System.Drawing.Size(625, 522);
            this.picScores.TabIndex = 24;
            this.picScores.TabStop = false;
            this.picScores.Visible = false;
            // 
            // picHelp
            // 
            this.picHelp.BackColor = System.Drawing.Color.Transparent;
            this.picHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHelp.Image = global::WinAppBotiAprende.Properties.Resources.botiAprende;
            this.picHelp.Location = new System.Drawing.Point(278, 4);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(122, 100);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelp.TabIndex = 12;
            this.picHelp.TabStop = false;
            this.picHelp.Visible = false;
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.BackColor = System.Drawing.Color.Transparent;
            this.lblScores.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.ForeColor = System.Drawing.Color.Black;
            this.lblScores.Location = new System.Drawing.Point(32, 644);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(36, 40);
            this.lblScores.TabIndex = 2;
            this.lblScores.Text = "0";
            // 
            // esconderCartas
            // 
            this.esconderCartas.Interval = 500;
            this.esconderCartas.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // AbrirCartas
            // 
            this.AbrirCartas.Interval = 8000;
            this.AbrirCartas.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // btnRestart
            // 
            this.btnRestart.AutoSize = true;
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Transparent;
            this.btnRestart.Image = global::WinAppBotiAprende.Properties.Resources.r;
            this.btnRestart.Location = new System.Drawing.Point(948, 640);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(69, 76);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "  ";
            this.btnRestart.Click += new System.EventHandler(this.lab_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::WinAppBotiAprende.Properties.Resources.t;
            this.btnExit.Location = new System.Drawing.Point(30, 37);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 76);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "  ";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImage = global::WinAppBotiAprende.Properties.Resources.h;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnHelp.ErrorImage = null;
            this.btnHelp.Location = new System.Drawing.Point(922, 37);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(73, 71);
            this.btnHelp.TabIndex = 21;
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // ScoreTime
            // 
            this.ScoreTime.Tick += new System.EventHandler(this.ScoreTime_Tick);
            // 
            // timerGrades
            // 
            this.timerGrades.AutoSize = true;
            this.timerGrades.BackColor = System.Drawing.Color.Transparent;
            this.timerGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerGrades.ForeColor = System.Drawing.Color.Transparent;
            this.timerGrades.Location = new System.Drawing.Point(958, 67);
            this.timerGrades.Name = "timerGrades";
            this.timerGrades.Size = new System.Drawing.Size(0, 13);
            this.timerGrades.TabIndex = 22;
            // 
            // frmBotiAprendeNivel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::WinAppBotiAprende.Properties.Resources.med3;
            this.ClientSize = new System.Drawing.Size(1024, 749);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.timerGrades);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picHelp);
            this.Controls.Add(this.PanelJuego);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBotiAprendeNivel2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boti Aprende";
            this.Load += new System.EventHandler(this.frmBotiAprendeNivel2_Load);
            this.PanelJuego.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelJuego;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Timer esconderCartas;
        private System.Windows.Forms.Timer AbrirCartas;
        private System.Windows.Forms.Label btnRestart;
        private System.Windows.Forms.Label btnExit;
        private PictureBox btnHelp;
        private PictureBox picHelp;
        private PictureBox picScores;
        private Timer ScoreTime;
        private Label timerGrades;
    }
}

