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

    }
}
