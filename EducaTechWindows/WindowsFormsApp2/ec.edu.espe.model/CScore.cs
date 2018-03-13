using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.ec.edu.espe.gui;

namespace WinAppBotiAprende
{
    class CScore
    {
        #region Copyright
        /*
         * Desarrollador:
         * Renzo Malla - Estudiante de la Universidad de las Fuerzas Armadas - ESPE
         */
        #endregion

        #region Member Data
        private string[] score = new string[] { "verygood.gif", "good.gif", "bad.gif" };
        SoundPlayer excelente = new SoundPlayer();
        SoundPlayer bueno = new SoundPlayer();
        SoundPlayer regular = new SoundPlayer();
        frmMenuBoti boti;
        #endregion

        #region Constructors
        public void SScore()
        {

        }
        #endregion

        #region Methods
        public void ScoresNivel1(int Movimientos, PictureBox picScore, Button btnLevel2, Timer tiempoScores)
        {
            boti = new frmMenuBoti();
            CSound sonidos = new CSound();
            tiempoScores.Enabled = true;
            tiempoScores.Start();
            if (Movimientos < 9)
            {
                loadScores(picScore, 0);
                sonidos.Excellent();        
                boti.Flag = true;                
            }
            else if (Movimientos > 9 && Movimientos < 14)
            {
                loadScores(picScore, 1);
                sonidos.Good();
            }
            else
            {
                loadScores(picScore, 2);
                sonidos.Regular();
            }

        }

        public void ScoresNivel2(int Movimientos, PictureBox picScore, Button btnLevel3, Timer tiempoScores)
        {
            CSound sonidos = new CSound();
            boti = new frmMenuBoti();
            tiempoScores.Enabled = true;
            tiempoScores.Start();
            if (Movimientos < 19)
            {
                loadScores2(picScore, 0);
                sonidos.Excellent();
                boti.Flag2 = true;
            }
            else if (Movimientos < 25 && Movimientos > 18)
            {
                loadScores2(picScore, 1);
                sonidos.Good();
            }
            else
            {
                loadScores2(picScore, 2);
                sonidos.Regular();
            }

        }
        public void ScoresNivel3(int Movimientos, PictureBox picScore, Timer tiempoScores)
        {
            CSound sonidos = new CSound();
            boti = new frmMenuBoti();
            tiempoScores.Enabled = true;
            tiempoScores.Start();
            if (Movimientos < 21)
            {
                loadScores3(picScore, 0);
                sonidos.Excellent();
                boti.Flag3 = true;
            }
            else if (Movimientos < 29 && Movimientos > 20)
            {
                loadScores3(picScore, 1);
                sonidos.Good();
            }
            else
            {
                loadScores3(picScore, 2);
                sonidos.Regular();
            }

        }

        public void loadScores(PictureBox pic1, int position)
        {
            Bitmap face = new Bitmap(Application.StartupPath + @"/images/" + score[position]);
            pic1.Image = face;
            pic1.Visible = true;
        }
        public void loadScores2(PictureBox pic2, int position)
        {
            Bitmap face = new Bitmap(Application.StartupPath + @"/images/" + score[position]);
            pic2.Image = face;
            pic2.Visible = true;
        }
        public void loadScores3(PictureBox pic3, int position)
        {
            Bitmap face = new Bitmap(Application.StartupPath + @"/images/" + score[position]);
            pic3.Image = face;
            pic3.Visible = true;
        }
        #endregion
    }

}
