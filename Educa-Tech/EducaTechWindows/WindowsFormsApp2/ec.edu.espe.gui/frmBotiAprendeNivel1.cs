using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppBotiAprende;
using WinAppEducaTech;

namespace WindowsFormsApp2.ec.edu.espe.gui
{
    public partial class frmBotiAprendeNivel1 : Form
    {
        CBotiAprendeNivelI nivel1 = new CBotiAprendeNivelI();
        CScore scores = new CScore();
        bool flagSound = true;
        CSound soundGame = new CSound();
        frmMenuBoti boti;
        int i = 0;

        public frmBotiAprendeNivel1()
        {
            InitializeComponent();
            
            boti = new frmMenuBoti();
            nivel1.juego(PanelJuego, esconderCartas, abrirCartas, lblScores, picScores, picHelp, boti.BtnLevel2, ScoreTime, reproductor);
        }

        private void frmBotiAprendeNivel1_Load(object sender, EventArgs e)
        {
            soundGame.SoundGame(flagSound);
            //picControl.SendToBack();
            //picControl.BackColor = Color.Red;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            reproductor.URL = Application.StartupPath + @"/images/" + "Help.wav";
            CSound Ayuda = new CSound();
            Ayuda.HelpSound(picHelp);
            helpTimer.Start();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            abrirCartas.Stop();
            abrirCartas.Start();
            soundGame.SoundGame(flagSound);
            nivel1.juego(PanelJuego, esconderCartas, abrirCartas, lblScores, picScores, picHelp, boti.BtnLevel2, ScoreTime, reproductor);
            picHelp.Hide();
            PanelJuego.Hide();
            PanelJuego.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMenuBoti menu = new frmMenuBoti();
            menu.Show();
            this.Hide();
            reproductor.close();
        }

        private void esconderCartas_Tick(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if (TiempoVirarCarta == 1)
            {
                nivel1.CartaTemporal11.Image = Properties.Resources.botiquin;
                nivel1.CartaTemporal21.Image = Properties.Resources.botiquin;
                nivel1.CartasSeleccionadas1.Clear();
                TiempoVirarCarta = 0;
                esconderCartas.Stop();
            }
        }

        private void abrirCartas_Tick(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if (TiempoVirarCarta == 1)
            {
                for (int i = 0; i < 8; i++)
                {
                    nivel1.CartaTemporal3[i].Image = Properties.Resources.botiquin;

                }
                nivel1.CartasSeleccionadas1.Clear();
                TiempoVirarCarta = 0;
                abrirCartas.Stop();
            }
        }

        private void ScoreTime_Tick(object sender, EventArgs e)
        {
            i++;
            if (i > 0 && i < 9)
            {
                timerGrades.Text = "0" + i.ToString();
            }
            else
            {
                timerGrades.Text = i.ToString();
            }

            if (i == 35)
            {
                frmMenuBoti menu = new frmMenuBoti();
                menu.Show();
                this.Hide();
            }
        }

        private void frmBotiAprendeNivel1_MouseClick(object sender, MouseEventArgs e)
        {
            reproductor.close();
            picHelp.Hide();
            helpTimer.Stop();
        }

        private void PanelJuego_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void picScores_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void picControl_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void picHelp_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void helpTimer_Tick(object sender, EventArgs e)
        {
            picHelp.Hide();
            helpTimer.Stop();
        }
    }
}
