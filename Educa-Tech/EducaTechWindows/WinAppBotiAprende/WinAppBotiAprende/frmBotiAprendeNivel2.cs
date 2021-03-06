﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace WinAppBotiAprende
{

    public partial class frmBotiAprendeNivel2 : Form
    {
        CBotiAprendeNivelII nivel2 = new CBotiAprendeNivelII();
        bool flagSound = true;
        CSound soundGame = new CSound();
        CSound Ayuda = new CSound();
        frmMenuBoti boti;
        int i = 0;

        public frmBotiAprendeNivel2()
        {
            InitializeComponent();
            boti = new frmMenuBoti();
            soundGame.SoundGame(flagSound);
            nivel2.juego(PanelJuego, esconderCartas, AbrirCartas, lblScores,picScores,picHelp, boti.BtnLevel3, ScoreTime);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if (TiempoVirarCarta == 1)
            {
                nivel2.CartaTemporal11.Image = Properties.Resources.botiquin;
                nivel2.CartaTemporal21.Image = Properties.Resources.botiquin;
                nivel2.CartasSeleccionadas1.Clear();
                TiempoVirarCarta = 0;
                esconderCartas.Stop();

            }
        }

        private void frmBotiAprendeNivel2_Load(object sender, EventArgs e)
        {

        }


        private void timer2_Tick_1(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if (TiempoVirarCarta == 1)
            {
                for (int i = 0; i < 16; i++)
                {
                    nivel2.CartaTemporal3[i].Image = Properties.Resources.botiquin;

                }
                nivel2.CartasSeleccionadas1.Clear();
                TiempoVirarCarta = 0;
                AbrirCartas.Stop();

            }

        }

        private void lab_Click(object sender, EventArgs e)
        {
            soundGame.SoundGame(flagSound);
            frmBotiAprendeNivel2 nivel = new frmBotiAprendeNivel2();
            nivel2.juego(PanelJuego, esconderCartas, AbrirCartas, lblScores,picScores,picHelp, boti.BtnLevel3, ScoreTime);
            picHelp.Hide();
            PanelJuego.Hide();
            PanelJuego.Show();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMenuBoti menuBotiAprende = new frmMenuBoti();
            menuBotiAprende.Show();
            this.Hide();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
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
