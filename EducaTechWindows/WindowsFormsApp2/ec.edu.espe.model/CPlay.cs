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
    class CPlay
    {
        int correct=8;
        ec.edu.espe.model.CScores ObjScores = new ec.edu.espe.model.CScores();
        private string[] picture1 = new string[] { "TC1.jpg", "TC2.jpg", "TC3.jpg", "TC4.jpg", "TC5.jpg", "TC6.jpg",
            "TC7.jpg", "TC8.jpg", "HG9.jpg", "HG10.jpg", "HG11.jpg", "HG12.jpg", "HG13.jpg", "HG14.jpg", "HG15.jpg",
            "HG16.jpg", "TCTitle.png", "HGTitle.png" };

        

        //contar aciertos
        public void  play(PictureBox RImage1, PictureBox RImage2, PictureBox RImage3, PictureBox RImage4, PictureBox RImage5, PictureBox RImage6, PictureBox RImage7, PictureBox RImage8,
                       PictureBox image1, PictureBox image2 , PictureBox image3, PictureBox image4, PictureBox image5, PictureBox Image6, PictureBox image7, PictureBox image8,PictureBox picScores, PictureBox picTryAgain, int position )
        {
           
                if (RImage1.ImageLocation != Application.StartupPath + @"/images/" + picture1[0+position])
                {
                   image1.BackColor = Color.Red;
                    correct--;
                  
                }
                if (RImage2.ImageLocation != Application.StartupPath + @"/images/" + picture1[1 + position])
                {
                    image2.BackColor = Color.Red;
                     correct--;
                }
                if (RImage3.ImageLocation != Application.StartupPath + @"/images/" + picture1[2 + position])
                {
                    image3.BackColor = Color.Red;
                    correct--;
                }
                if (RImage4.ImageLocation != Application.StartupPath + @"/images/" + picture1[3 + position])
                {
                    image4.BackColor = Color.Red;
                    correct--;
                }
                if (RImage5.ImageLocation != Application.StartupPath + @"/images/" + picture1[4 + position])
                {
                    image5.BackColor = Color.Red;
                    correct--;
                }
                if (RImage6.ImageLocation != Application.StartupPath + @"/images/" + picture1[5 + position])
                {
                    Image6.BackColor = Color.Red;
                    correct--;
                }
                if (RImage7.ImageLocation != Application.StartupPath + @"/images/" + picture1[6 + position])
                {
                    image7.BackColor = Color.Red;
                    correct--;
                }
                if (RImage8.ImageLocation != Application.StartupPath + @"/images/" + picture1[7 + position])
                {
                    image8.BackColor = Color.Red;
                    correct++;
                }

            result(picScores, picTryAgain);
            

        }

        private void result(PictureBox picScores, PictureBox picTryAgain)
        {
            if (correct == 8)
            {
                ObjScores.loadEmoji(picScores, 2);

            }
            if (correct > 4 && correct < 8)
            {

                ObjScores.loadEmoji(picScores, 1);
                picTryAgain.Visible = true;
            }
            if (correct <= 4)
            {
                ObjScores.loadEmoji(picScores, 0);
                picTryAgain.Visible = true;
            }
        }

    }
}
