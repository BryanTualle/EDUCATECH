using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    class CInitializeImage
    {
        #region attributes
        private string[] picture1 = new string[] { "TC1.jpg", "TC2.jpg", "TC3.jpg", "TC4.jpg", "TC5.jpg", "TC6.jpg",
            "TC7.jpg", "TC8.jpg", "HG9.jpg", "HG10.jpg", "HG11.jpg", "HG12.jpg", "HG13.jpg", "HG14.jpg", "HG15.jpg",
            "HG16.jpg", "TCTitle.png", "HGTitle.png" };

        private string[] efectsNormal = new string[] { "btnTresCerditos_M1.png", "btnHanselGrettel_M1.png", "btnHelp_M1.png",
            "btnHome_M1.png", "btnReturn_M1.png", "btnNext_M1.png", "btnPreview_M1.png", "btnContinue_M1.png", "btnTryAgain_M1.png",
            "btnPlay_M1.png", "btnCheck_M1.png", "btnExit_M1.png", "btnGame_M1.png", "btnExitProgram_M1.png", "btnHomePrincipal_M1.png" };

        private string[] efectsEnter = new string[] { "btnTresCerditos_M2.png", "btnHanselGrettel_M2.png", "btnHelp_M2.png",
            "btnHome_M2.png", "btnReturn_M2.png", "btnNext_M2.png", "btnPreview_M2.png", "btnContinue_M2.png", "btnTryAgain_M2.png",
            "btnPlay_M2.png", "btnCheck_M2.png", "btnExit_M2.png","helpEvaluation.gif", "btnGame_M2.png", "btnExitProgram_M2.png",
            "btnHomePrincipal_M2.png" };

        private string[] number = new string[] {"uno.jpg","dos.jpg","tres.jpg","cuatro.jpg","cinco.jpg","seis.jpg","siete.jpg","ocho.jpg" };
        //private string[] efectsPushHold = new string[] { "btnTresCerditos_M3.png", "btnHanselGrettel_M3.png", "btnHelp_M3.png", "btnHome_M3.png", "btnReturn_M3.png" };

        private Bitmap myBitmap;
        #endregion

        #region methods
        //carga imagenes en pictureBox
        public void uploadImage(PictureBox image1, PictureBox image2, PictureBox image3, PictureBox image4, PictureBox image5, PictureBox image6, PictureBox image7, PictureBox image8,int position)
        {
            loadPictureBox(image1, position);
            position++;
            loadPictureBox(image2, position);
            position++;
            loadPictureBox(image3, position);
            position++;
            loadPictureBox(image4, position);
            position++;
            loadPictureBox(image5, position);
            position++;
            loadPictureBox(image6, position);
            position++;
            loadPictureBox(image7, position);
            position++;
            loadPictureBox(image8, position);

        }
        //carga imagenes una a una desde la carpeta Images
        public void loadPictureBox(PictureBox pic1, int position)
        {
            myBitmap = new Bitmap(Application.StartupPath + @"/images/" + picture1[position]);
            pic1.Image=myBitmap;
            pic1.ImageLocation = Application.StartupPath + @"/images/" + picture1[position];
            pic1.BackColor = Color.Transparent;
        }
        //carga Titulos de cuentos

        public void loadTitle(PictureBox pic1, int position)
        {
            if (position == 16)
            {
                 myBitmap = new Bitmap(Application.StartupPath + @"/images/" + picture1[16]);
                pic1.Image = myBitmap;
                pic1.BackColor = Color.Transparent;
            }
            else
            {
                 myBitmap = new Bitmap(Application.StartupPath + @"/images/" + picture1[17]);
                pic1.Image = myBitmap;
                pic1.BackColor = Color.Transparent;
            }
        }

        //carga efectos para botones
        public void effectNormal(PictureBox pic1, int position)
        {
             myBitmap = new Bitmap(Application.StartupPath + @"/images/" + efectsNormal[position]);
            pic1.Image = myBitmap;
            pic1.BackColor = Color.Transparent;
        }

        public void effectEnter(PictureBox pic1, int position)
        {
             myBitmap = new Bitmap(Application.StartupPath + @"/images/" + efectsEnter[position]);
            pic1.Image = myBitmap;
            pic1.BackColor = Color.Transparent;

        }

        //carga los numeros de las imagenes del cuento
        public void loadNumbers(PictureBox pic1, int position)
        {
            myBitmap = new Bitmap(Application.StartupPath + @"/images/" + number[position]);
            pic1.Image = myBitmap;
            pic1.BackColor = Color.Transparent;
        }

        /*
        public void effectPushAndHold(PictureBox pic1, int position)
        {
             myBitmap = new Bitmap(Application.StartupPath + @"/images/" + efectsPushHold[position]);
            pic1.Image = myBitmap;
            pic1.BackColor = Color.Transparent;

        }
        */
        #endregion

    }
}
