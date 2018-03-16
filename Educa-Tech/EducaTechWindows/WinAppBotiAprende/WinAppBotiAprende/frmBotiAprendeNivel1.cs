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
            nivel1.juego(PanelJuego, esconderCartas, abrirCartas, lblScores, picScores, picHelp, boti.BtnLevel2,ScoreTime);

        }

        private void frmBotiAprendeNivelII_Load(object sender, EventArgs e)
        {
            soundGame.SoundGame(flagSound);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

            soundGame.SoundGame(flagSound);
            nivel1.juego(PanelJuego, esconderCartas, abrirCartas, lblScores, picScores, picHelp, boti.BtnLevel2, ScoreTime);
            picHelp.Hide();
            PanelJuego.Hide();
            PanelJuego.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMenuBoti menu = new frmMenuBoti();          
            menu.Show();
            this.Hide();

        }

        //esta funcion sirve para esconder las cartas en primera instancia
        private void timer1_Tick(object sender, EventArgs e)
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

        //esta funcion sirve para abrir las cartas en segunda instancia
        private void timer2_Tick(object sender, EventArgs e)
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

        private void lab_Click(object sender, EventArgs e)
        {
            boti = new frmMenuBoti();
            nivel1.juego(PanelJuego, esconderCartas, abrirCartas, lblScores, picScores, picHelp, boti.BtnLevel2, ScoreTime);
            PanelJuego.Hide();
            PanelJuego.Show();

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            CSound Ayuda = new CSound();
            Ayuda.HelpSound(picHelp);
        }

        private void ScoreTime_Tick(object sender, EventArgs e)
        {
        
            i++;
            if(i>0 && i < 9)
            {
                timerGrades.Text ="0"+ i.ToString();           
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
    }
}
