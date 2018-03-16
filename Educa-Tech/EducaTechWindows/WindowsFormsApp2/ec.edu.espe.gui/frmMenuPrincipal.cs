using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;
using WMPLib;
using WinAppBotiAprende;
using WindowsFormsApp2.ec.edu.espe.gui;

namespace WinAppEducaTech
{
    public partial class frmMenuPrincipal : Form
    {
        public WMPPlayState playState { get; }
        private CInitializeImage image = new CInitializeImage();

        public frmMenuPrincipal()
        {         
            InitializeComponent();
        }


        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBotiAprende_Click(object sender, EventArgs e)
        {
            frmMenuBoti Boti = new frmMenuBoti();
            Boti.Show(); 
            this.Hide();
        }

        private void btnJirenSec_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJirenSec jiren = new frmMenuJirenSec();
            jiren.Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            bool flagSoundGame = true;
            CSound soundGame = new CSound();
            soundGame.SoundGame(flagSoundGame);
        }

        private void btnBotiAprende_MouseEnter(object sender, EventArgs e)
        {
            //btnGame_M1.png
            //image.effectEnter(btnBotiAprende, 7);
        }

        private void btnBotiAprende_MouseLeave(object sender, EventArgs e)
        {
            //image.effectNormal(picNextPage, 7);

        }

        private void picBotiAprende_Click(object sender, EventArgs e)
        {
            frmMenuBoti Boti = new frmMenuBoti();
            Boti.Show();
            this.Hide();
        }

        private void picJirenSec_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJirenSec jiren = new frmMenuJirenSec();
            jiren.Show();
        }

        private void btnExitApplication_MouseEnter(object sender, EventArgs e)
        {
            image.effectEnter(btnExitApplication, 14);
        }

        private void btnExitApplication_MouseLeave(object sender, EventArgs e)
        {
            image.effectNormal(btnExitApplication, 13);
        }

        private void picGameBotiAprende_Click(object sender, EventArgs e)
        {
            frmMenuBoti Boti = new frmMenuBoti();
            Boti.Show();
            this.Hide();
        }

        private void picGameJirenSec_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJirenSec jiren = new frmMenuJirenSec();
            jiren.Show();
        }

        private void picGameBotiAprende_MouseEnter(object sender, EventArgs e)
        {
            image.effectEnter(picGameBotiAprende, 16);
        }

        private void picGameBotiAprende_MouseLeave(object sender, EventArgs e)
        {
            image.effectNormal(picGameBotiAprende, 15);
        }

        private void picGameJirenSec_MouseEnter(object sender, EventArgs e)
        {
            image.effectEnter(picGameJirenSec, 17);
        }

        private void picGameJirenSec_MouseLeave(object sender, EventArgs e)
        {
            image.effectNormal(picGameJirenSec, 16);
        }
    }
}
