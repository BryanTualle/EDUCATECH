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
    public partial class frmMenuBoti : Form
    {
        private CInitializeImage objImage = new CInitializeImage();

        static bool flag = false;
        static bool flag2 = false;
        static bool flag3 = false;
        CSound HelpFalse = new CSound();


        public frmMenuBoti()
        {

            //CSound Ayuda = new CSound();


            InitializeComponent();
            if (flag == false)
            {
                btnLevel2.Hide();
                picBlock1.Show();
            }
            else
            {
                btnLevel2.Show();
                picBlock1.Hide();
            }
            if (flag2 == false)
            {
                btnLevel3.Hide();
                picBlock2.Show();
            }
            else if (flag3 == false)
            {
                btnLevel3.Show();
                picBlock2.Hide();
            }
            //Ayuda.HelpSound(picHelp);
            picHelp.Show();
        }

        public bool Flag2 { get => flag2; set => flag2 = value; }
        public bool Flag { get => flag; set => flag = value; }
        public bool Flag3 { get => flag3; set => flag3 = value; }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            HelpFalse.HelpOffSound(picHelp);
            //bool flagSoundGame = true;
            //CSound soundGame = new CSound();
            //reproductor.URL = Application.StartupPath + @"/images/" + "Help.wav";
            //soundGame.SoundGame(flagSoundGame);
            frmMenuPrincipal principalMenu = new frmMenuPrincipal();
            principalMenu.Show();
           // this.Hide();
        }

        private void frmMenuBoti_Load(object sender, EventArgs e)
        {
            reproductor.URL = Application.StartupPath + @"/images/" + "Help.wav";
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            frmBotiAprendeNivel1 primerNivel = new frmBotiAprendeNivel1();
            HelpFalse.HelpOffSound(picHelp);
            this.Close();
            primerNivel.Show();
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            frmBotiAprendeNivel2 segundoNivel = new frmBotiAprendeNivel2();
            this.Close();
            segundoNivel.Show();
        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {
            frmBotiAprendeNivel3 tercerNivel = new frmBotiAprendeNivel3();
            this.Close();
            tercerNivel.Show();
        }

        private void btnReturnPrincipalMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            HelpFalse.HelpOffSound(picHelp);
            bool flagSoundGame = true;
            CSound soundGame = new CSound();
            soundGame.SoundGame(flagSoundGame);
            frmMenuPrincipal principalMenu = new frmMenuPrincipal();
            principalMenu.Show();
            // this.Hide();
        }

        private void btnReturnPrincipalMenu_MouseEnter(object sender, EventArgs e)
        {
            objImage.effectEnter(btnReturnPrincipalMenu, 15);
        }

        private void btnReturnPrincipalMenu_MouseLeave(object sender, EventArgs e)
        {
            objImage.effectNormal(btnReturnPrincipalMenu, 14);
        }
    }
}
