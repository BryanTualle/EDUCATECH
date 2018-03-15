using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppEducaTech;
using System.Media;


namespace WindowsFormsApp2
{
    public partial class frmEvaluation : Form
    {
        #region attributes
        private CDragAndDrop dragAndDrop = new CDragAndDrop();
        private CInitializeImage initializa = new CInitializeImage();
        private SoundPlayer player;
        private frmMenuPrincipal menu;
        private CRandom random;
        private frmStory tresCerditos;
        private int position;
        

        #endregion

        #region constructor
        public frmEvaluation(int num)
        {
            position = num;
             random = new CRandom();
            InitializeComponent();
            initializa.uploadImage(Image1, Image2, Image3, Image4, Image5, Image6, Image7, Image8,position);
            random.Position(Image1, Image2, Image3, Image4, Image5, Image6, Image7, Image8);
            
        }
        #endregion

        #region methods
        private void frmDosChanchitos_Load(object sender, EventArgs e)
        {
            
            player = new SoundPlayer(Application.StartupPath + @"/images/" + "soundGame.wav");
            player.Play();
            picHelpEvaluation.Visible = false;
            // Obtiene o establece un valor que indica si el 
            //control puede aceptar los datos que el usuario arrastra al mismo.
            RImage1.AllowDrop = true;
            RImage2.AllowDrop = true;
            RImage3.AllowDrop = true;
            RImage4.AllowDrop = true;
            RImage5.AllowDrop = true;
            RImage6.AllowDrop = true;
            RImage7.AllowDrop = true;
            RImage8.AllowDrop = true;
            Image1.AllowDrop = true;
            Image2.AllowDrop = true;
            Image3.AllowDrop = true;
            Image4.AllowDrop = true;
            Image5.AllowDrop = true;
            Image6.AllowDrop = true;
            Image7.AllowDrop = true;
            Image8.AllowDrop = true;

        }
        //eventos drag and drop
        #region eventos drag and drop
        private void RImage1_MouseDown(object sender, MouseEventArgs e)
        {
            dragAndDrop.controlMousePressing(sender, e);
        }


        private void RImage2_MouseDown(object sender, MouseEventArgs e)
        {
            dragAndDrop.controlMousePressing(sender, e);
        }
        private void RImage3_MouseDown(object sender, MouseEventArgs e)
        {
            dragAndDrop.controlMousePressing(sender, e);
        }


        private void RImage4_MouseDown(object sender, MouseEventArgs e)
        {
            dragAndDrop.controlMousePressing(sender, e);
        }
        private void RImage5_MouseDown(object sender, MouseEventArgs e)
        {
            dragAndDrop.controlMousePressing(sender, e);
        }


        private void RImage6_MouseDown(object sender, MouseEventArgs e)
        {
            dragAndDrop.controlMousePressing(sender, e);
        }
        private void RImage7_MouseDown(object sender, MouseEventArgs e)
        {
            dragAndDrop.controlMousePressing(sender, e);

        }


        private void RImage8_MouseDown(object sender, MouseEventArgs e)
        {
            dragAndDrop.controlMousePressing(sender, e);

        }
        private void Image1_MouseDown(object sender, MouseEventArgs e)
        {
            dragAndDrop.controlMousePressing(sender, e);
        }


        private void Image2_MouseDown(object sender, MouseEventArgs e)
        {
            dragAndDrop.controlMousePressing(sender, e);
        }
        private void Image3_MouseDown(object sender, MouseEventArgs e)
        {
            dragAndDrop.controlMousePressing(sender, e);
        }
        private void Image4_MouseDown(object sender, MouseEventArgs e)
        {
            dragAndDrop.controlMousePressing(sender, e);
        }

        private void Image5_MouseDown(object sender, MouseEventArgs e)
        {
            dragAndDrop.controlMousePressing(sender, e);
        }
        private void Image6_MouseDown(object sender, MouseEventArgs e)
        {
            dragAndDrop.controlMousePressing(sender, e);
        }
        private void Image7_MouseDown(object sender, MouseEventArgs e)
        {
            dragAndDrop.controlMousePressing(sender, e);
        }
        private void Image8_MouseDown(object sender, MouseEventArgs e)
        {
            dragAndDrop.controlMousePressing(sender, e);
        }

        private void RImage1_DragEnter(object sender, DragEventArgs e)
        {

            dragAndDrop.DragAction(sender, e);
        }

        private void RImage2_DragEnter(object sender, DragEventArgs e)
        {
            dragAndDrop.DragAction(sender, e);
        }
        private void RImage3_DragEnter(object sender, DragEventArgs e)
        {
            dragAndDrop.DragAction(sender, e);
        }
        private void RImage4_DragEnter(object sender, DragEventArgs e)
        {
            dragAndDrop.DragAction(sender, e);
        }
        private void RImage5_DragEnter(object sender, DragEventArgs e)
        {
            dragAndDrop.DragAction(sender, e);
        }
        private void RImage6_DragEnter(object sender, DragEventArgs e)
        {
            dragAndDrop.DragAction(sender, e);
        }
        private void RImage7_DragEnter(object sender, DragEventArgs e)
        {
            dragAndDrop.DragAction(sender, e);
        }
        private void RImage8_DragEnter(object sender, DragEventArgs e)
        {
            dragAndDrop.DragAction(sender, e);
        }
        private void Image1_DragEnter(object sender, DragEventArgs e)
        {
            dragAndDrop.DragAction(sender, e);

        }

        private void Image2_DragEnter(object sender, DragEventArgs e)
        {
            dragAndDrop.DragAction(sender, e);
        }
        private void Image3_DragEnter(object sender, DragEventArgs e)
        {
            dragAndDrop.DragAction(sender, e);
        }
        private void Image4_DragEnter(object sender, DragEventArgs e)
        {
            dragAndDrop.DragAction(sender, e);
        }
        private void Image5_DragEnter(object sender, DragEventArgs e)
        {
            dragAndDrop.DragAction(sender, e);
        }
        private void Image6_DragEnter(object sender, DragEventArgs e)
        {
            dragAndDrop.DragAction(sender, e);
        }
        private void Image7_DragEnter(object sender, DragEventArgs e)
        {
            dragAndDrop.DragAction(sender, e);
        }
        private void Image8_DragEnter(object sender, DragEventArgs e)
        {
            dragAndDrop.DragAction(sender, e);
        }

        private void RImage1_DragDrop(object sender, DragEventArgs e)
        {
            dragAndDrop.dropAction(sender, e,VImage1, picScores);
        }

        private void RImage2_DragDrop(object sender, DragEventArgs e)
        {
            dragAndDrop.dropAction(sender, e, VImage2, picScores);
        }
        private void RImage3_DragDrop(object sender, DragEventArgs e)
        {
            dragAndDrop.dropAction(sender, e, VImage3, picScores);
        }
        private void RImage4_DragDrop(object sender, DragEventArgs e)
        {
            dragAndDrop.dropAction(sender, e, VImage4, picScores);

        }
        private void RImage5_DragDrop(object sender, DragEventArgs e)
        {
            dragAndDrop.dropAction(sender, e, VImage5, picScores);
        }
        private void RImage6_DragDrop(object sender, DragEventArgs e)
        {
            dragAndDrop.dropAction(sender, e, VImage6, picScores);
        }
        private void RImage7_DragDrop(object sender, DragEventArgs e)
        {
            dragAndDrop.dropAction(sender, e, VImage7, picScores);
        }
        private void RImage8_DragDrop(object sender, DragEventArgs e)
        {
            dragAndDrop.dropAction(sender, e, VImage8, picScores);
        }
        private void Image1_DragDrop(object sender, DragEventArgs e)
        {
            dragAndDrop.dropAction(sender, e, VImage1, picScores);
        }

        private void Image2_DragDrop(object sender, DragEventArgs e)
        {
            dragAndDrop.dropAction(sender, e, VImage1, picScores);
        }
        private void Image3_DragDrop(object sender, DragEventArgs e)
        {
            dragAndDrop.dropAction(sender, e, VImage1, picScores);
        }
        private void Image4_DragDrop(object sender, DragEventArgs e)
        {
            dragAndDrop.dropAction(sender, e, VImage1, picScores);

        }
        private void Image5_DragDrop(object sender, DragEventArgs e)
        {
            dragAndDrop.dropAction(sender, e, VImage1, picScores);
        }
        private void Image6_DragDrop(object sender, DragEventArgs e)
        {
            dragAndDrop.dropAction(sender, e, VImage1, picScores);
        }
        private void Image7_DragDrop(object sender, DragEventArgs e)
        {
            dragAndDrop.dropAction(sender, e, VImage1, picScores);
        }
        private void Image8_DragDrop(object sender, DragEventArgs e)
        {
            dragAndDrop.dropAction(sender, e, VImage1, picScores);
        }
        #endregion

        private void RImage3_Click(object sender, EventArgs e)
        {

        }

        private void RImage4_Click(object sender, EventArgs e)
        {

        }

        private void RImage5_Click(object sender, EventArgs e)
        {

        }

        private void RImage6_Click(object sender, EventArgs e)
        {

        }

        private void RImage7_Click(object sender, EventArgs e)
        {

        }

        private void RImage8_Click(object sender, EventArgs e)
        {

        }

        private void Image1_Click(object sender, EventArgs e)
        {

        }

        private void Image2_Click(object sender, EventArgs e)
        {

        }

        private void Image3_Click(object sender, EventArgs e)
        {

        }

        private void Image4_Click(object sender, EventArgs e)
        {

        }

        private void Image5_Click(object sender, EventArgs e)
        {

        }

        private void Image6_Click(object sender, EventArgs e)
        {

        }

        private void Image7_Click(object sender, EventArgs e)
        {

        }

        private void Image8_Click(object sender, EventArgs e)
        {

        }

        private void RImage1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        //Efecto de botones
        private void picHome_MouseLeave(object sender, EventArgs e)
        {

            initializa.effectNormal(picTryAgain, 3);
        }

        private void picHome_MouseEnter(object sender, EventArgs e)
        {
            initializa.effectEnter(picTryAgain, 3);
        }

        private void picBack_MouseEnter(object sender, EventArgs e)
        {
            initializa.effectEnter(picBack, 4);
        }

        private void picBack_MouseLeave(object sender, EventArgs e)
        {
            initializa.effectNormal(picBack, 4);
        }
        //regresar a escuchar el cuento
        private void picBack_Click(object sender, EventArgs e)
        {
            player.Stop();
            this.Hide();
            tresCerditos = new frmStory(position);
            tresCerditos.Show();
        }
        //regreso al menú de cuentos
        private void picHome_Click(object sender, EventArgs e)
        {
            player.Stop();
            menu = new frmMenuPrincipal();
            menu.Show();
            //menu.Visible = true;
            this.Close();

        }
        #endregion

        private void RImage1_Click_2(object sender, EventArgs e)
        {

        }

        private void picScores_Click(object sender, EventArgs e)
        {

        }

        //boton verificar respuestas
        private void picCheck_Click(object sender, EventArgs e)
        {
            CPlay verificar = new CPlay();
            verificar.play(RImage1, RImage2, RImage3, RImage4, RImage5, RImage6, RImage7, RImage8, VImage1, VImage2, VImage3, VImage4, VImage5, VImage6, VImage7, VImage8, picScores, picTryAgain, position);
            pictureBox1.Visible = true;
            
        }

        private void picCheck_MouseEnter(object sender, EventArgs e)
        {
            initializa.effectEnter(picCheck, 10);
        }

        private void picCheck_MouseLeave(object sender, EventArgs e)
        {
            initializa.effectNormal(picCheck, 10);
        }

        private void picTryAgain_MouseEnter(object sender, EventArgs e)
        {
            initializa.effectEnter(picTryAgain, 8);
        }

        private void picTryAgain_MouseLeave(object sender, EventArgs e)
        {
            initializa.effectNormal(picTryAgain, 8);
        }
        //boton volver a jugar
        private void picTryAgain_Click(object sender, EventArgs e)
        {
            frmEvaluation evaluation = new frmEvaluation(position);
            evaluation.Show();
            this.Hide();
        }

        private void picHelp_MouseEnter(object sender, EventArgs e)
        {
            initializa.effectEnter(picHelp, 2);
        }

        private void picHelp_MouseLeave(object sender, EventArgs e)
        {
            initializa.effectNormal(picHelp, 2);
        }

        private void picTryAgain_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJirenSec jiren = new frmMenuJirenSec();
            jiren.Show();
        }

        private void picHelp_Click(object sender, EventArgs e)
        {
            picHelpEvaluation.Visible = true;
            initializa.effectEnter(picHelpEvaluation, 12);
        }

        private void picHelpEvaluation_Click(object sender, EventArgs e)
        {
            picHelpEvaluation.Visible = false;
        }

        private void frmEvaluation_MouseClick(object sender, MouseEventArgs e)
        {
            picHelpEvaluation.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmEvaluation evaluation = new frmEvaluation(position);
            evaluation.Show();
            this.Hide();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            initializa.effectNormal(pictureBox1, 8);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            initializa.effectEnter(pictureBox1, 8);
        }

        private void picCuentos_Click(object sender, EventArgs e)
        {
            player.Stop();
            this.Hide();
            frmMenuJirenSec menuJirenSec = new frmMenuJirenSec();

            menuJirenSec.Show();
        }

        private void picCuentos_MouseEnter(object sender, EventArgs e)
        {
            initializa.effectEnter(picCuentos, 18);
        }

        private void picCuentos_MouseLeave(object sender, EventArgs e)
        {
            initializa.effectNormal(picCuentos, 17);
        }
    }
}
