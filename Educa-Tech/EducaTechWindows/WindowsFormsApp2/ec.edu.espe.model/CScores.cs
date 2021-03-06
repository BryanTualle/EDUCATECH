﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
namespace WindowsFormsApp2.ec.edu.espe.model
{
    class CScores
    {
        #region attributes
        private string[] emojis = new string[] { "bad.png", "good.png", "verygood.png" };
        private string[] soundEmojis = new string[] { "bad.wav", "good.wav", "verygood.wav" };
        private Bitmap myBitmap;
        private SoundPlayer player;
        #endregion

        #region methods
        //carga imagens de premiacion
        public void loadEmoji(PictureBox picEmoji, int position)
        {
             myBitmap = new Bitmap(Application.StartupPath + @"/images/" + emojis[position]);
            picEmoji.Image = myBitmap;
            picEmoji.BackColor = Color.Transparent;
            picEmoji.Visible = true;
            player = new SoundPlayer(Application.StartupPath + @"/images/" + soundEmojis[position]);
            picEmoji.BackColor = Color.Transparent;
            player.Play();
            picEmoji.BackColor = Color.Transparent;
        }
        #endregion

    }
}
