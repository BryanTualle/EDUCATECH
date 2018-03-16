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

namespace WindowsFormsApp2
{
    public partial class frmMenuJirenSec : Form
    {
        #region attribustes
        private frmStory ObjForm;
        private CInitializeImage objImage = new CInitializeImage();
        #endregion

        #region constructor
        public frmMenuJirenSec()
        {
            InitializeComponent();
        }
        #endregion

        #region methods
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMenuJirenSec.ActiveForm.Visible = false;
             ObjForm = new frmStory(0);
            ObjForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // frmMenuJirenSec.ActiveForm.Visible = false;
            bool flagSoundGame = false;
            CSound soundGame = new CSound();
            soundGame.SoundGame(flagSoundGame);
            ObjForm = new frmStory(8);
            ObjForm.Show();
            this.Hide();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            //pictureBox2.Visible = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox2.Visible = true;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            frmMenuJirenSec.ActiveForm.Visible = false;
            ObjForm = new frmStory(0);
            ObjForm.Show();
            //pictureBox6.Enabled = false;
            picTresCerditos.Visible = false;
            
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox6.Enabled = true;
            picTresCerditos.Visible = true;
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            bool flagSoundGame = false;
            CSound soundGame = new CSound();
            soundGame.SoundGame(flagSoundGame);
            ObjForm = new frmStory(0);
            ObjForm.Show();
            this.Hide();
        }

        private void picTresCerditos_MouseLeave(object sender, EventArgs e)
        {
            objImage.effectNormal(picTresCerditos, 0);
        }

        private void btnTresCerditos_MouseEnter(object sender, EventArgs e)
        {
            objImage.effectEnter(picTresCerditos, 0);
        }

        private void picHanselGretel_MouseLeave(object sender, EventArgs e)
        {
            objImage.effectNormal(picHanselGretel, 1);
        }

        private void picHanselGretel_MouseEnter(object sender, EventArgs e)
        {
            objImage.effectEnter(picHanselGretel, 1);
        }

        private void frmMenuJirenSec_Load(object sender, EventArgs e)
        {
            bool flagSoundGame = true;
            CSound soundGame = new CSound();
            soundGame.SoundGame(flagSoundGame);

        }

        #endregion


        private void btnReturnPrincipalMenu_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal principalMenu = new frmMenuPrincipal();
            principalMenu.Show();
            this.Hide();
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
