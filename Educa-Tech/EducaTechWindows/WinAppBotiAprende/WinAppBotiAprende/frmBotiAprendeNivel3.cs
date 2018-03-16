using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppBotiAprende
{

    public partial class frmBotiAprendeNivel3 : Form
    {
        CBotiAprendeNivelIII nivel3 = new CBotiAprendeNivelIII();
        bool flagSound = true;
        CSound soundGame = new CSound();
        CSound Ayuda = new CSound();
        frmMenuBoti boti;
        int i = 0;

        public frmBotiAprendeNivel3()
        {

            InitializeComponent();
            boti = new frmMenuBoti();
            soundGame.SoundGame(flagSound);
            nivel3.juego(PanelJuego, esconderCartas, abrirCartas, lblScores,picScores, picHelp, ScoreTime);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMenuBoti menuBotiAprende = new frmMenuBoti();
            menuBotiAprende.Show();
            this.Hide();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            soundGame.SoundGame(flagSound);
            nivel3.juego(PanelJuego, esconderCartas, abrirCartas, lblScores, picScores, picHelp, ScoreTime);
            picHelp.Hide();
            PanelJuego.Hide();
            PanelJuego.Show();
        }

        private void frmBotiAprendeNivel3_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if (TiempoVirarCarta == 1)
            {
                nivel3.CartaTemporal11.Image = Properties.Resources.botiquin;
                nivel3.CartaTemporal21.Image = Properties.Resources.botiquin;
                nivel3.CartasSeleccionadas1.Clear();
                TiempoVirarCarta = 0;
                esconderCartas.Stop();

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if (TiempoVirarCarta == 1)
            {
                for (int i = 0; i < 20; i++)
                {
                    nivel3.CartaTemporal3[i].Image = Properties.Resources.botiquin;

                }
                nivel3.CartasSeleccionadas1.Clear();
                TiempoVirarCarta = 0;
                abrirCartas.Stop();

            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            CSound Ayuda = new CSound();
            Ayuda.HelpSound(picHelp);
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

            if (i == 40)
            {
                frmMenuBoti menu = new frmMenuBoti();
                menu.Show();
                this.Hide();
            }
        }
    }
}
