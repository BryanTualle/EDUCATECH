using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppBotiAprende
{
    #region Copyright
    /*
     * Desarrollador:
     * Bryan Rodriguez - Estudiante de la Universidad de las Fuerzas Armadas - ESPE
     */
    #endregion

    public class CSound
    {
        #region Member Data
        SoundPlayer sonido1 = new SoundPlayer();
        SoundPlayer sonido2 = new SoundPlayer();
        SoundPlayer sonido3 = new SoundPlayer();
        SoundPlayer sonido4 = new SoundPlayer();
        SoundPlayer sonido5 = new SoundPlayer();
        SoundPlayer sonido6 = new SoundPlayer();
        SoundPlayer sonido7 = new SoundPlayer();
        SoundPlayer sonido8 = new SoundPlayer();
        SoundPlayer sonido9 = new SoundPlayer();
        SoundPlayer sonido10 = new SoundPlayer();
        SoundPlayer sonido11 = new SoundPlayer();
        SoundPlayer Game = new SoundPlayer();
        SoundPlayer excelente = new SoundPlayer();
        SoundPlayer bueno = new SoundPlayer();
        SoundPlayer regular = new SoundPlayer();
        SoundPlayer ayudaSound = new SoundPlayer();
        SoundPlayer helpFalse = new SoundPlayer();
        #endregion

        #region Constructors
        public CSound()
        {
        }
        #endregion

        #region Methods
        public void Sound(int numeroSonido)
        {
            switch (numeroSonido)
            {
                case 1:
                    sonido1 = new SoundPlayer(Properties.Resources.sound1);
                    sonido1.Play();
                    break;

                case 2:
                    sonido2 = new SoundPlayer(Properties.Resources.sound2);
                    sonido2.Play();
                    break;

                case 3:
                    sonido3 = new SoundPlayer(Properties.Resources.sound3);
                    sonido3.Play();
                    break;

                case 4:
                    sonido4 = new SoundPlayer(Properties.Resources.sound4);
                    sonido4.Play();
                    break;

                case 5:
                    sonido5 = new SoundPlayer(Properties.Resources.sound5);
                    sonido5.Play();
                    break;

                case 6:
                    sonido6 = new SoundPlayer(Properties.Resources.sound6);
                    sonido6.Play();
                    break;

                case 7:
                    sonido7 = new SoundPlayer(Properties.Resources.sound7);
                    sonido7.Play();
                    break;

                case 8:
                    sonido8 = new SoundPlayer(Properties.Resources.sound8);
                    sonido8.Play();
                    break;

                case 9:
                    sonido8 = new SoundPlayer(Properties.Resources.sound9);
                    sonido8.Play();
                    break;

                case 10:
                    sonido10 = new SoundPlayer(Properties.Resources.sound10);
                    sonido10.Play();
                    break;
                case 11:
                    sonido11 = new SoundPlayer(Properties.Resources.sound11);
                    sonido11.Play();
                    break;

            }
        }

        public void SoundGame(bool sgame)
        {
            if (sgame == true) {
                Game = new SoundPlayer(Properties.Resources.soundGame);
                Game.Play();
            }
        }

        public void Excellent() {
            excelente = new SoundPlayer(Properties.Resources.Excelente);
            excelente.Play();
        }

        public void Good()
        {
            bueno = new SoundPlayer(Properties.Resources.Bueno);
            bueno.Play();
        }

        public void Regular()
        {
            regular = new SoundPlayer(Properties.Resources.Regular);
            regular.Play();
        }

        internal void HelpSound(PictureBox picHelp)
        {
            ayudaSound = new SoundPlayer(Properties.Resources.Help1);
            ayudaSound.Play();
            picHelp.Show();
        }
        internal void HelpOffSound(PictureBox picHelp)
        {
            ayudaSound = new SoundPlayer(Properties.Resources.Help1);
            ayudaSound.Stop();
            picHelp.Hide();
        }

        #endregion
    }
}
