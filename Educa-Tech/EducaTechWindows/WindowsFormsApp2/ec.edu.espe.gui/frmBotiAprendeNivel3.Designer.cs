namespace WindowsFormsApp2.ec.edu.espe.gui
{
    partial class frmBotiAprendeNivel3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBotiAprendeNivel3));
            this.lblScores = new System.Windows.Forms.Label();
            this.PanelJuego = new System.Windows.Forms.Panel();
            this.picScores = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Label();
            this.esconderCartas = new System.Windows.Forms.Timer(this.components);
            this.abrirCartas = new System.Windows.Forms.Timer(this.components);
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.ScoreTime = new System.Windows.Forms.Timer(this.components);
            this.timerGrades = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.helpTimer = new System.Windows.Forms.Timer(this.components);
            this.PanelJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.BackColor = System.Drawing.Color.Transparent;
            this.lblScores.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.ForeColor = System.Drawing.Color.Black;
            this.lblScores.Location = new System.Drawing.Point(39, 754);
            this.lblScores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(46, 50);
            this.lblScores.TabIndex = 24;
            this.lblScores.Text = "0";
            // 
            // PanelJuego
            // 
            this.PanelJuego.BackColor = System.Drawing.Color.Transparent;
            this.PanelJuego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelJuego.Controls.Add(this.picScores);
            this.PanelJuego.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelJuego.Location = new System.Drawing.Point(132, 15);
            this.PanelJuego.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelJuego.Name = "PanelJuego";
            this.PanelJuego.Size = new System.Drawing.Size(1083, 844);
            this.PanelJuego.TabIndex = 23;
            // 
            // picScores
            // 
            this.picScores.BackColor = System.Drawing.Color.Transparent;
            this.picScores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picScores.Location = new System.Drawing.Point(163, 107);
            this.picScores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picScores.Name = "picScores";
            this.picScores.Size = new System.Drawing.Size(833, 642);
            this.picScores.TabIndex = 24;
            this.picScores.TabStop = false;
            this.picScores.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.AutoSize = true;
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Transparent;
            this.btnRestart.Image = global::WindowsFormsApp2.Properties.Resources.r;
            this.btnRestart.Location = new System.Drawing.Point(1223, 754);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(84, 95);
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
            this.btnExit.Location = new System.Drawing.Point(16, 23);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 95);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "  ";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // esconderCartas
            // 
            this.esconderCartas.Interval = 500;
            this.esconderCartas.Tick += new System.EventHandler(this.esconderCartas_Tick);
            // 
            // abrirCartas
            // 
            this.abrirCartas.Interval = 15000;
            this.abrirCartas.Tick += new System.EventHandler(this.abrirCartas_Tick);
            // 
            // picHelp
            // 
            this.picHelp.BackColor = System.Drawing.Color.Transparent;
            this.picHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHelp.Image = global::WindowsFormsApp2.Properties.Resources.botiAprende;
            this.picHelp.Location = new System.Drawing.Point(1204, 257);
            this.picHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(145, 101);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelp.TabIndex = 28;
            this.picHelp.TabStop = false;
            this.picHelp.Visible = false;
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
            this.timerGrades.Location = new System.Drawing.Point(1267, 106);
            this.timerGrades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerGrades.Name = "timerGrades";
            this.timerGrades.Size = new System.Drawing.Size(0, 17);
            this.timerGrades.TabIndex = 29;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnHelp.ErrorImage = null;
            this.btnHelp.Image = global::WindowsFormsApp2.Properties.Resources.h;
            this.btnHelp.Location = new System.Drawing.Point(1208, 0);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(141, 102);
            this.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHelp.TabIndex = 53;
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click_1);
            // 
            // reproductor
            // 
            this.reproductor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reproductor.Enabled = true;
            this.reproductor.Location = new System.Drawing.Point(801, 94);
            this.reproductor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reproductor.Name = "reproductor";
            this.reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reproductor.OcxState")));
            this.reproductor.Size = new System.Drawing.Size(211, 35);
            this.reproductor.TabIndex = 54;
            // 
            // helpTimer
            // 
            this.helpTimer.Interval = 10500;
            this.helpTimer.Tick += new System.EventHandler(this.helpTimer_Tick);
            // 
            // frmBotiAprendeNivel3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.med3;
            this.ClientSize = new System.Drawing.Size(1344, 874);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.PanelJuego);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picHelp);
            this.Controls.Add(this.timerGrades);
            this.Controls.Add(this.reproductor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBotiAprendeNivel3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBotiAprendeNivel3";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmBotiAprendeNivel3_MouseClick);
            this.PanelJuego.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Panel PanelJuego;
        private System.Windows.Forms.PictureBox picScores;
        private System.Windows.Forms.Label btnRestart;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Timer esconderCartas;
        private System.Windows.Forms.Timer abrirCartas;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.Timer ScoreTime;
        private System.Windows.Forms.Label timerGrades;
        private System.Windows.Forms.PictureBox btnHelp;
        private AxWMPLib.AxWindowsMediaPlayer reproductor;
        private System.Windows.Forms.Timer helpTimer;
    }
}