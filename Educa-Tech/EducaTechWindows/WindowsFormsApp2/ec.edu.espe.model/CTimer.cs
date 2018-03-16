using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace WindowsFormsApp2
{
    class CTimer
    {
        #region attributes

        private CInitializeImage imag = new CInitializeImage();
        private string[] filePathsTC = new string[] { "TC1.mp3", "TC2.mp3", "TC3.mp3", "TC4.mp3", "TC5.mp3", "TC6.mp3", "TC7.mp3", "TC8.mp3" };
        private string[] filePathsHG = new string[] { "HG01.mp3", "HG02.mp3", "HG03.mp3", "HG04.mp3", "HG05.mp3", "HG06.mp3", "HG07.mp3", "HG08.mp3" };
        #endregion

        #region methods
        //función control cuento Tres Chanchitos
        public void timerTresChanchitos(Timer timer1, Timer timer2, Timer timer3, Timer timer4, Timer timer5, Timer timer6, Timer timer7, Timer timer8, AxWMPLib.AxWindowsMediaPlayer player, int pos, PictureBox picImage1, PictureBox picImage2, PictureBox picImage3, PictureBox picImage4, PictureBox picNum1, PictureBox picNum2, PictureBox picNum3, PictureBox picNum4)
        {

            if (pos == 0)
            {
                player.URL = Application.StartupPath + @"/images/" + filePathsTC[0];
                imag.loadNumbers(picNum1, 0);
                imag.loadPictureBox(picImage1, 0);
                picNum2.Image = null;
                picNum3.Image = null;
                picNum4.Image = null;
                picImage2.Image = null;
                picImage3.Image = null;
                picImage4.Image = null;
                timer1.Interval = 7000;
                timer1.Start();
                timer2.Interval = 18000;
                timer2.Start();
                timer3.Interval = 23000;
                timer3.Start();
                timer4.Interval = 33000;
                timer4.Start();
                timer5.Interval = 60000;
                timer5.Start();
                timer6.Interval = 78000;
                timer6.Start();
                timer7.Interval = 95000;
                timer7.Start();
                timer8.Interval = 122000;
                timer8.Start();
            }

            if (pos == 1)
            {
                player.URL = Application.StartupPath + @"/images/" + filePathsTC[1];
                stopTimer(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8);
                picNum3.Image = null;
                picImage2.Image = null;
                picImage3.Image = null;
                picImage4.Image = null;
                imag.loadNumbers(picNum1, 0);
                imag.loadNumbers(picNum2, 1);
                imag.loadPictureBox(picImage1, 0);
                imag.loadPictureBox(picImage2, 1);

                timer2.Interval = 11000;
                timer2.Start();
                timer3.Interval = 16000;
                timer3.Start();
                timer4.Interval = 26000;
                timer4.Start();
                timer5.Interval = 53000;
                timer5.Start();
                timer6.Interval = 71000;
                timer6.Start();
                timer7.Interval = 88000;
                timer7.Start();
                timer8.Interval = 119000;
                timer8.Start();
            }
            if (pos == 2)
            {
                stopTimer(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8);
                player.URL = Application.StartupPath + @"/images/" + filePathsTC[2];
                picNum4.Image = null;
                picImage2.Image = null;
                picImage3.Image = null;
                picImage4.Image = null;
                imag.loadNumbers(picNum1, 0);
                imag.loadNumbers(picNum2, 1);
                imag.loadNumbers(picNum3, 2);
                imag.loadPictureBox(picImage1, 0);
                imag.loadPictureBox(picImage2, 1);
                imag.loadPictureBox(picImage3, 2);

                timer3.Interval = 4000;
                timer3.Start();
                timer4.Interval = 15000;
                timer4.Start();
                timer5.Interval = 42000;
                timer5.Start();
                timer6.Interval = 60000;
                timer6.Start();
                timer7.Interval = 77000;
                timer7.Start();
                timer8.Interval = 108000;
                timer8.Start();
            }
            if (pos == 3)
            {
                stopTimer(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8);
                player.URL = Application.StartupPath + @"/images/" + filePathsTC[3];
                picImage2.Image = null;
                picImage3.Image = null;
                picImage4.Image = null;
                imag.loadNumbers(picNum1, 0);
                imag.loadNumbers(picNum2, 1);
                imag.loadNumbers(picNum3, 2);
                imag.loadNumbers(picNum4, 3);
                imag.loadPictureBox(picImage1, 0);
                imag.loadPictureBox(picImage2, 1);
                imag.loadPictureBox(picImage3, 2);
                imag.loadPictureBox(picImage4, 3);

                timer4.Interval = 11000;
                timer4.Start();
                timer5.Interval = 38000;
                timer5.Start();
                timer6.Interval = 56000;
                timer6.Start();
                timer7.Interval = 73000;
                timer7.Start();
                timer8.Interval = 104000;
                timer8.Start();
            }
            if (pos == 4)
            {
                stopTimer(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8);
                player.URL = Application.StartupPath + @"/images/" + filePathsTC[4];
                imag.loadNumbers(picNum1, 4);
                imag.loadPictureBox(picImage1, 4);

                picImage2.Image = null;
                picImage3.Image = null;
                picImage4.Image = null;
                picNum2.Image = null;
                picNum3.Image = null;
                picNum4.Image = null;
                timer5.Interval = 27000;
                timer5.Start();
                timer6.Interval = 45000;
                timer6.Start();
                timer7.Interval = 62000;
                timer7.Start();
                timer8.Interval = 93000;
                timer8.Start();
            }
            if (pos == 5)
            {
                stopTimer(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8);
                player.URL = Application.StartupPath + @"/images/" + filePathsTC[5];
                picNum3.Image = null;
                picNum4.Image = null;
                picImage2.Image = null;
                picImage3.Image = null;
                picImage4.Image = null;
                imag.loadNumbers(picNum1, 4);
                imag.loadNumbers(picNum2, 5);
                imag.loadPictureBox(picImage1, 4);
                imag.loadPictureBox(picImage2, 5);

                timer6.Interval = 18000;
                timer6.Start();
                timer7.Interval = 35000;
                timer7.Start();
                timer8.Interval = 66000;
                timer8.Start();
            }
            if (pos == 6)
            {
                stopTimer(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8);
                player.URL = Application.StartupPath + @"/images/" + filePathsTC[6];
                picNum4.Image = null;
                picImage2.Image = null;
                picImage3.Image = null;
                picImage4.Image = null;
                imag.loadNumbers(picNum1, 4);
                imag.loadNumbers(picNum2, 5);
                imag.loadNumbers(picNum3, 6);
                imag.loadPictureBox(picImage1, 4);
                imag.loadPictureBox(picImage2, 5);
                imag.loadPictureBox(picImage3, 6);
                timer7.Interval = 17000;
                timer7.Start();
                timer8.Interval = 47000;
                timer8.Start();
            }
            if (pos == 7)
            {
                stopTimer(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8);
                player.URL = Application.StartupPath + @"/images/" + filePathsTC[7];
                picImage2.Image = null;
                picImage3.Image = null;
                picImage4.Image = null;
                imag.loadNumbers(picNum1, 4);
                imag.loadNumbers(picNum2, 5);
                imag.loadNumbers(picNum3, 6);
                imag.loadNumbers(picNum4, 7);

                imag.loadPictureBox(picImage1, 4);
                imag.loadPictureBox(picImage2, 5);
                imag.loadPictureBox(picImage3, 6);
                imag.loadPictureBox(picImage4, 7);
                timer8.Interval = 28000;
                timer8.Start();
            }





        }
        //función control cuento Hansel y Gretel
        public void timerHanselGretel(Timer timer1, Timer timer2, Timer timer3, Timer timer4, Timer timer5, Timer timer6, Timer timer7, Timer timer8, AxWMPLib.AxWindowsMediaPlayer player, int pos, PictureBox picImage1, PictureBox picImage2, PictureBox picImage3, PictureBox picImage4, PictureBox picNum1, PictureBox picNum2, PictureBox picNum3, PictureBox picNum4)
        {

            if (pos == 8)
            {
                player.URL = Application.StartupPath + @"/images/" + filePathsHG[0];
                imag.loadNumbers(picNum1, 0);
                imag.loadPictureBox(picImage1, 8);
                picNum2.Image = null;
                picNum3.Image = null;
                picNum4.Image = null;
                picImage2.Image = null;
                picImage3.Image = null;
                picImage4.Image = null;
                timer1.Interval = 29000;
                timer1.Start();
                timer2.Interval = 47000;
                timer2.Start();
                timer3.Interval = 79000;
                timer3.Start();
                timer4.Interval = 99000;
                timer4.Start();
                timer5.Interval = 116000;
                timer5.Start();
                timer6.Interval = 142000;
                timer6.Start();
                timer7.Interval = 175000;
                timer7.Start();
                timer8.Interval = 197000;
                timer8.Start();
            }

            if (pos == 9)
            {

                player.URL = Application.StartupPath + @"/images/" + filePathsHG[1];
                stopTimer(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8);
                picNum3.Image = null;
                picImage2.Image = null;
                picImage3.Image = null;
                picImage4.Image = null;
                imag.loadNumbers(picNum1, 0);
                imag.loadNumbers(picNum2, 1);
                imag.loadPictureBox(picImage1, 8);
                imag.loadPictureBox(picImage2, 9);

                timer2.Interval = 18000;
                timer2.Start();
                timer3.Interval = 50000;
                timer3.Start();
                timer4.Interval = 70000;
                timer4.Start();
                timer5.Interval = 87000;
                timer5.Start();
                timer6.Interval = 113000;
                timer6.Start();
                timer7.Interval = 146000;
                timer7.Start();
                timer8.Interval = 168000;
                timer8.Start();
            }
            if (pos == 10)
            {
                player.URL = Application.StartupPath + @"/images/" + filePathsHG[2];
                stopTimer(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8);
                picNum4.Image = null;
                picImage2.Image = null;
                picImage3.Image = null;
                picImage4.Image = null;
                imag.loadNumbers(picNum1, 0);
                imag.loadNumbers(picNum2, 1);
                imag.loadNumbers(picNum3, 2);
                imag.loadPictureBox(picImage1, 8);
                imag.loadPictureBox(picImage2, 9);
                imag.loadPictureBox(picImage3, 10);

                timer3.Interval = 31000;
                timer3.Start();
                timer4.Interval = 47000;
                timer4.Start();
                timer5.Interval = 69000;
                timer5.Start();
                timer6.Interval = 95000;
                timer6.Start();
                timer7.Interval = 128000;
                timer7.Start();
                timer8.Interval = 150000;
                timer8.Start();
            }
            if (pos == 11)
            {
                player.URL = Application.StartupPath + @"/images/" + filePathsHG[3];
                stopTimer(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8);
                picImage2.Image = null;
                picImage3.Image = null;
                picImage4.Image = null;
                imag.loadNumbers(picNum1, 0);
                imag.loadNumbers(picNum2, 1);
                imag.loadNumbers(picNum3, 2);
                imag.loadNumbers(picNum4, 3);
                imag.loadPictureBox(picImage1, 8);
                imag.loadPictureBox(picImage2, 9);
                imag.loadPictureBox(picImage3, 10);
                imag.loadPictureBox(picImage4, 11);

                timer4.Interval = 21000;
                timer4.Start();
                timer5.Interval = 37000;
                timer5.Start();
                timer6.Interval = 65000;
                timer6.Start();
                timer7.Interval = 96000;
                timer7.Start();
                timer8.Interval = 118000;
                timer8.Start();
            }
            if (pos == 12)
            {
                player.URL = Application.StartupPath + @"/images/" + filePathsHG[4];
                stopTimer(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8);
                imag.loadNumbers(picNum1, 4);
                imag.loadPictureBox(picImage1, 12);
                picImage2.Image = null;
                picImage3.Image = null;
                picImage4.Image = null;
                picNum2.Image = null;
                picNum3.Image = null;
                picNum4.Image = null;

                timer5.Interval = 15000;
                timer5.Start();
                timer6.Interval = 44000;
                timer6.Start();
                timer7.Interval = 75000;
                timer7.Start();
                timer8.Interval = 97000;
                timer8.Start();
            }
            if (pos == 13)
            {
                player.URL = Application.StartupPath + @"/images/" + filePathsHG[5];
                stopTimer(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8);
                picNum3.Image = null;
                picNum4.Image = null;
                picImage2.Image = null;
                picImage3.Image = null;
                picImage4.Image = null;
                imag.loadNumbers(picNum1, 4);
                imag.loadNumbers(picNum2, 5);
                imag.loadPictureBox(picImage1, 12);
                imag.loadPictureBox(picImage2, 13);

                timer6.Interval = 26000;
                timer6.Start();
                timer7.Interval = 59000;
                timer7.Start();
                timer8.Interval = 81000;
                timer8.Start();
            }
            if (pos == 14)
            {
                player.URL = Application.StartupPath + @"/images/" + filePathsHG[6];
                stopTimer(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8);
                picNum4.Image = null;
                picImage2.Image = null;
                picImage3.Image = null;
                picImage4.Image = null;
                imag.loadNumbers(picNum1, 4);
                imag.loadNumbers(picNum2, 5);
                imag.loadNumbers(picNum3, 6);
                imag.loadPictureBox(picImage1, 12);
                imag.loadPictureBox(picImage2, 13);
                imag.loadPictureBox(picImage3, 14);

                timer7.Interval = 33000;
                timer7.Start();
                timer8.Interval = 55000;
                timer8.Start();
            }
            if (pos == 15)
            {
                player.URL = Application.StartupPath + @"/images/" + filePathsHG[7];
                stopTimer(timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8);
                picImage2.Image = null;
                picImage3.Image = null;
                picImage4.Image = null;
                imag.loadNumbers(picNum1, 4);
                imag.loadNumbers(picNum2, 5);
                imag.loadNumbers(picNum3, 6);
                imag.loadNumbers(picNum4, 7);
                imag.loadPictureBox(picImage1, 12);
                imag.loadPictureBox(picImage2, 13);
                imag.loadPictureBox(picImage3, 14);
                imag.loadPictureBox(picImage4, 15);

                timer8.Interval = 22000;
                timer8.Start();
            }
        }
        //función detener timers
        private void stopTimer(Timer timer1, Timer timer2, Timer timer3, Timer timer4, Timer timer5, Timer timer6, Timer timer7, Timer timer8)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
            timer7.Stop();
            timer8.Stop();
        }

        #endregion
    }
}
