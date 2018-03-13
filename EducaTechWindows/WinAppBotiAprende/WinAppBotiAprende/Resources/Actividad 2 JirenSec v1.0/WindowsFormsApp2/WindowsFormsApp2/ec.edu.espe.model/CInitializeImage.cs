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
        private string[] picture1 = new string[] { "TC1.jpg", "TC2.jpg", "TC3.jpg", "TC4.jpg", "TC5.jpg", "TC6.jpg",
            "TC7.jpg", "TC8.jpg", "HG9.jpg", "HG10.jpg", "HG11.jpg", "HG12.jpg", "HG13.jpg", "HG14.jpg", "HG15.jpg",
            "HG16.jpg", "TCTitle.png", "HGTitle.png" };

        private string[] efectsNormal = new string[] { "btnTresCerditos_M1.png", "btnHanselGrettel_M1.png", "btnHelp_M1.png",  "btnHome_M1.png", "btnReturn_M1.png"};

        private string[] efectsEnter = new string[] { "btnTresCerditos_M2.png", "btnHanselGrettel_M2.png", "btnHelp_M2.png", "btnHome_M2.png", "btnReturn_M2.png"};

        private string[] efectsPushHold = new string[] { "btnTresCerditos_M3.png", "btnHanselGrettel_M3.png", "btnHelp_M3.png", "btnHome_M3.png", "btnReturn_M3.png" };

        private Bitmap myBitmap;
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
            pic1.Image = myBitmap;
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

        public void effectPushAndHold(PictureBox pic1, int position)
        {
             myBitmap = new Bitmap(Application.StartupPath + @"/images/" + efectsPushHold[position]);
            pic1.Image = myBitmap;
            pic1.BackColor = Color.Transparent;

        }

    }
}
