namespace WindowsFormsApp2.ec.edu.espe.gui
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
            this.lblScores = new System.Windows.Forms.Label();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.esconderCartas = new System.Windows.Forms.Timer(this.components);
            this.AbrirCartas = new System.Windows.Forms.Timer(this.components);
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Label();
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
            this.PanelJuego.Location = new System.Drawing.Point(55, 105);
            this.PanelJuego.Name = "PanelJuego";
            this.PanelJuego.Size = new System.Drawing.Size(868, 587);
            this.PanelJuego.TabIndex = 23;
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
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.BackColor = System.Drawing.Color.Transparent;
            this.lblScores.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.ForeColor = System.Drawing.Color.Black;
            this.lblScores.Location = new System.Drawing.Point(12, 632);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(36, 40);
            this.lblScores.TabIndex = 24;
            this.lblScores.Text = "0";
            // 
            // picHelp
            // 
            this.picHelp.BackColor = System.Drawing.Color.Transparent;
            this.picHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHelp.Image = global::WindowsFormsApp2.Properties.Resources.botiAprende;
            this.picHelp.Location = new System.Drawing.Point(278, 4);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(122, 100);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelp.TabIndex = 27;
            this.picHelp.TabStop = false;
            this.picHelp.Visible = false;
            // 
            // esconderCartas
            // 
            this.esconderCartas.Interval = 500;
            this.esconderCartas.Tick += new System.EventHandler(this.esconderCartas_Tick);
            // 
            // AbrirCartas
            // 
            this.AbrirCartas.Interval = 8000;
            this.AbrirCartas.Tick += new System.EventHandler(this.AbrirCartas_Tick);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnHelp.ErrorImage = null;
            this.btnHelp.Image = global::WindowsFormsApp2.Properties.Resources.h;
            this.btnHelp.Location = new System.Drawing.Point(918, 34);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(78, 76);
            this.btnHelp.TabIndex = 28;
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.AutoSize = true;
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Transparent;
            this.btnRestart.Image = global::WindowsFormsApp2.Properties.Resources.r;
            this.btnRestart.Location = new System.Drawing.Point(929, 603);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(69, 76);
            this.btnRestart.TabIndex = 25;
            this.btnRestart.Text = "  ";
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::WindowsFormsApp2.Properties.Resources.t;
            this.btnExit.Location = new System.Drawing.Point(6, 35);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 76);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "  ";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.timerGrades.Location = new System.Drawing.Point(939, 62);
            this.timerGrades.Name = "timerGrades";
            this.timerGrades.Size = new System.Drawing.Size(0, 13);
            this.timerGrades.TabIndex = 29;
            // 
            // frmBotiAprendeNivel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.med3;
            this.ClientSize = new System.Drawing.Size(1008, 710);
            this.Controls.Add(this.PanelJuego);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.picHelp);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.timerGrades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBotiAprendeNivel2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBotiAprendeNivel2";
            this.PanelJuego.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelJuego;
        private System.Windows.Forms.PictureBox picScores;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.Timer esconderCartas;
        private System.Windows.Forms.Timer AbrirCartas;
        private System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.Label btnRestart;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Timer ScoreTime;
        private System.Windows.Forms.Label timerGrades;
    }
}