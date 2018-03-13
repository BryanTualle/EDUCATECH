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

        private CInitializeImage imag = new CInitializeImage();
       private  CTimer time = new CTimer();
       private frmEvaluation ObjForm;
        private int position;
        

        public frmStory(int num)
        {
            
            if (num == 0)
            {
                position = num;
                InitializeComponent();
                imag.loadPictureBox(picImage1, position);
                //carga título
                imag.loadTitle(picTitle, 16);
                position++;
                //carga cuento por tirmpo
                time.timerTresChanchitos(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8);
            }
            else
            {
                position = num;
                InitializeComponent();
                imag.loadPictureBox(picImage1, position);
                //carga titulo
                imag.loadTitle(picTitle, 17);
                position++;
                //carga cuento por tirmpo
                time.timerHanselGretel(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8);
            }
        }

        private void frmStory_Load(object sender, EventArgs e)
        {
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            imag.loadPictureBox(picImage2, position);
            position++;

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            imag.loadPictureBox(picImage3, position);
            position++;
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            imag.loadPictureBox(picImage4, position);
            position++;
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
        }

        private void timer4_Tick_1(object sender, EventArgs e)
        {
            picImage2.Image = null;
            picImage3.Image = null;
            picImage4.Image = null;
            imag.loadPictureBox(picImage1, position);
            position++;

        }

        private void timer5_Tick_1(object sender, EventArgs e)
        {
            picImage2.Image = null;
            imag.loadPictureBox(picImage2, position);
            position++;
        }

        private void timer6_Tick_1(object sender, EventArgs e)
        {
            imag.loadPictureBox(picImage3, position);
            position++;

        }

        private void timer7_Tick_1(object sender, EventArgs e)
        {

            imag.loadPictureBox(picImage4, position);
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
            timer7.Stop();
        }

        private void timer8_Tick_1(object sender, EventArgs e)
        {
           
            timer8.Stop();
            ObjForm = new frmEvaluation(position - 7);
            ObjForm.Show();
            this.Hide();


        }
    }
}
