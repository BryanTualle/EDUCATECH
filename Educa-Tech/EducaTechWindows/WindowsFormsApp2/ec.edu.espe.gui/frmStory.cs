using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmStory : Form
    {
        #region attributes
        private CInitializeImage imag = new CInitializeImage();
        private  CTimer time = new CTimer();
        private frmEvaluation ObjForm;
        private int positionImage;
        private int orig;
        private Boolean control;
        private int controlPlayer;
       
        private string[] filePaths = new string[] { "TC1.mp3", "TC2.mp3", "TC3.mp3", "TC4.mp3", "TC5.mp3", "TC6.mp3", "TC7.mp3", "TC8.mp3" };
        #endregion
        #region constructor
        public frmStory(int num)
        {
            
            InitializeComponent();
         
            controlPlayer = num;
            positionImage = num;
            orig = num;
            control = false;

        }

        public frmStory()
        {
        }
        #endregion
        #region methods
        private void frmStory_Load(object sender, EventArgs e)
        { //inicializa pictureBox
            picPlay_Click(sender, e);
            picImage2.BackColor = Color.Transparent;
            picImage3.BackColor = Color.Transparent;
            picImage4.BackColor = Color.Transparent;
        }
        

        private void picImage1_Click(object sender, EventArgs e)
        {

        }

        private void picImage2_Click(object sender, EventArgs e)
        {

        }

        private void picImage3_Click(object sender, EventArgs e)
        {

        }

        private void picImage4_Click(object sender, EventArgs e)
        {

        }
        //control de tiempos
        #region time

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            imag.loadPictureBox(picImage2, positionImage);
            
            imag.loadNumbers(picNumber2, 1);
            positionImage++;
            controlPlayer++;
            timer1.Stop();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
           
            imag.loadPictureBox(picImage3, positionImage);
            imag.loadNumbers(picNumber3, 2);
            positionImage++;
            controlPlayer++;
            timer2.Stop();

        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            imag.loadPictureBox(picImage4, positionImage);
            imag.loadNumbers(picNumber4, 3);
            positionImage++;
            controlPlayer++;
            timer3.Stop();
           
        }

        private void timer4_Tick_1(object sender, EventArgs e)
        {
            picNumber1.Image = null;
            picNumber2.Image = null;
            picNumber3.Image = null;
            picNumber4.Image = null;
            imag.loadNumbers(picNumber1, 4);
            picImage2.Image = null;
            picImage3.Image = null;
            picImage4.Image = null;
            imag.loadPictureBox(picImage1, positionImage);
            positionImage++;
            controlPlayer++;
            timer4.Stop();


        }

        private void timer5_Tick_1(object sender, EventArgs e)
        {
            imag.loadNumbers(picNumber2, 5);
            picImage2.Image = null;
            imag.loadPictureBox(picImage2, positionImage);
            positionImage++;
            controlPlayer++;
            timer5.Stop();
        }

        private void timer6_Tick_1(object sender, EventArgs e)
        {
            imag.loadNumbers(picNumber3, 6);
            imag.loadPictureBox(picImage3, positionImage);
            positionImage++;
            controlPlayer++;
            timer6.Stop();

        }

        private void timer7_Tick_1(object sender, EventArgs e)
        {
            imag.loadNumbers(picNumber4, 7);
            imag.loadPictureBox(picImage4, positionImage);
            controlPlayer++;
            timer7.Stop();
            
        }

        private void timer8_Tick_1(object sender, EventArgs e)
        {
           
            timer8.Stop();
            ObjForm = new frmEvaluation(orig);
            ObjForm.Show();
            Close();


        }
        #endregion

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        //boton comenzar a jugar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            player.close();
            frmEvaluation evaluation = new frmEvaluation(orig);
            evaluation.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void reproductor_Enter(object sender, EventArgs e)
        {
            
        }

       

        private void picNextPage_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void picNextPage_DragLeave(object sender, EventArgs e)
        {
            
        }
        // efectos de botones
        private void picNextPage_MouseEnter(object sender, EventArgs e)
        {
            imag.effectEnter(picNextPage, 7);
        }

        private void picNextPage_MouseLeave(object sender, EventArgs e)
        {
            imag.effectNormal(picNextPage, 7);
        }

        private void picBegin_MouseEnter(object sender, EventArgs e)
        {
            imag.effectEnter(picPlay, 9);
        }

        private void picBegin_MouseLeave(object sender, EventArgs e)
        {
            imag.effectNormal(picPlay, 9);
        }

        private void picBack_MouseEnter(object sender, EventArgs e)
        {
            imag.effectEnter(picBack, 6);
        }

        private void picBack_MouseLeave(object sender, EventArgs e)
        {
            imag.effectNormal(picBack, 6);
        }

        private void picNext_MouseEnter(object sender, EventArgs e)
        {
            imag.effectEnter(picNext, 5);
        }

        private void picNext_MouseLeave(object sender, EventArgs e)
        {
            imag.effectNormal(picNext, 5);
        }
        //movimientos de reproductor del cuento
        private void picBack_Click(object sender, EventArgs e)
        {
            player.close();
            //control retroceso cuento Tres cerditos
            if (orig == 0)
            {
                picNext.Visible = true;
                
                if (control == false)
                {
                    positionImage = controlPlayer + 1;
                }

                if (controlPlayer != 0 && controlPlayer <= 8)
                {
                    controlPlayer--;

                    imag.loadPictureBox(picImage1, positionImage);
                    imag.loadTitle(picTitle, 16);
                    positionImage--;
                    control = true;
                    time.timerTresChanchitos(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8, player, controlPlayer, picImage1, picImage2, picImage3, picImage4, picNumber1, picNumber2, picNumber3, picNumber4);
                }
            }
            //control retroceso cuento Hansel y Gretel
            else
            {
                if (control == false)
                {
                    positionImage = controlPlayer + 1;
                }
                if (controlPlayer != 8 && controlPlayer <= 16)
                {
                    controlPlayer--;
                    imag.loadPictureBox(picImage1, positionImage);
                    imag.loadTitle(picTitle, 17);
                    positionImage--;
                    control = true;
                    time.timerHanselGretel(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8, player, controlPlayer, picImage1, picImage2, picImage3, picImage4, picNumber1, picNumber2, picNumber3, picNumber4);
                }


            }


        }

        private void picPlay_Click(object sender, EventArgs e)
        {
            positionImage = orig;
            controlPlayer = orig;
            picImage2.Image = null;
            picImage3.Image = null;
            picImage4.Image = null;
            picNumber2.Image = null;
            picNumber3.Image = null;
            picNumber4.Image = null;
            //Empezar cuento Tres cerditos
            if (orig == 0)
            {

                controlPlayer = 1;
                imag.loadNumbers(picNumber1, 0);
                imag.loadPictureBox(picImage1, positionImage);
                //carga título
                imag.loadTitle(picTitle, 16);
                positionImage++;
                //carga cuento por tiempo
                time.timerTresChanchitos(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8, player, 0, picImage1, picImage2, picImage3, picImage4, picNumber1, picNumber2, picNumber3, picNumber4);
            }
            //Empezar cuento Hansel y Gretel
            else
            {
                controlPlayer = 9;
                imag.loadPictureBox(picImage1, positionImage);
                //carga titulo
                imag.loadTitle(picTitle, 17);
                positionImage++;
                //carga cuento por tiempo
                time.timerHanselGretel(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8, player, 8, picImage1, picImage2, picImage3, picImage4, picNumber1, picNumber2, picNumber3, picNumber4);
            }
        }


        private void picNext_Click(object sender, EventArgs e)
        {
            player.close();
            //control avance cuento Tres cerditos
            if (orig == 0)
            {
                if (control == true)
                {
                    positionImage = controlPlayer;
                }
                if(controlPlayer==7||controlPlayer==15)
                {
                    picNext.Visible=false;
                }
                else
                {
                    picNext.Visible = true;
                }
                if (controlPlayer >= 0 && controlPlayer < 8)
                {
                    imag.loadPictureBox(picImage1, positionImage);
                    imag.loadTitle(picTitle, 16);
                    positionImage++;
                    control = false;
                    time.timerTresChanchitos(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8, player, controlPlayer, picImage1, picImage2, picImage3, picImage4, picNumber1, picNumber2, picNumber3, picNumber4);
                    controlPlayer++;
                }
            }
            //control avance cuento Hansel y Gretel
            else
            {
                if (control == true)
                {
                    positionImage = controlPlayer;
                }
                if (controlPlayer >= 8 && controlPlayer < 16)
                {
                    imag.loadPictureBox(picImage1, positionImage);
                    imag.loadTitle(picTitle, 17);
                    positionImage++;
                    control = false;
                    time.timerHanselGretel(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8, player, controlPlayer, picImage1, picImage2, picImage3, picImage4, picNumber1, picNumber2, picNumber3, picNumber4);
                    controlPlayer++;
                }
            }

        }
        #endregion

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenuJirenSec_Click(object sender, EventArgs e)
        {
            frmMenuJirenSec menu = new frmMenuJirenSec();
            menu.Show();
            this.Close();
        }

        private void btnMenuJirenSec_MouseEnter(object sender, EventArgs e)
        {
            imag.effectEnter(btnMenuJirenSec, 4);
        }

        private void btnMenuJirenSec_MouseLeave(object sender, EventArgs e)
        {
            imag.effectNormal(btnMenuJirenSec, 4);
        }
    }
}
