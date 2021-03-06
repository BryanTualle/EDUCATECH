﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp2
{
    class CDragAndDrop
    {
        #region attributes
        object origenes;
        private int[] valid = new int[8];

        #endregion

        #region constructor

        public CDragAndDrop()
        {
            for (int i = 0; i < 8; i++)
            {
                valid[i] = -1;
            }
           
        }
        #endregion

        #region methods
        public void controlMousePressing(object sender, MouseEventArgs e)
        {

            ///Objeto de origen de la imagen
            PictureBox pic = (PictureBox)sender;
            origenes = sender;



            if (e.Button == MouseButtons.Left)// si el mouse se ha presionado
            {
                if (pic.Image != null) // si lo que presiono no es nulo
                {
                    pic.DoDragDrop(pic.Image, DragDropEffects.Move);// efecto
                }
            }


        }

        //---------------------------------------------------------------------------

        public void DragAction(object sender, DragEventArgs e)// lo que voy a arrastrar
        {

            if (e.Data.GetDataPresent(DataFormats.Bitmap))// si tiene datos
            {
                e.Effect = DragDropEffects.Move;// efecto de moverse
            }
            else
            {
                e.Effect = DragDropEffects.None;// sin efecto
            }


        }

        //---------------------------------------------------------------------------

        public void dropAction(object sender, DragEventArgs e, PictureBox VImage, PictureBox picScores)// llegada de lo que arrastro
        {
            ec.edu.espe.model.CScores ObjScores = new ec.edu.espe.model.CScores();

            PictureBox pic = (PictureBox)sender; // imagen que llego
            PictureBox org = (PictureBox)origenes; // direccion de donde viene la imagen

            if (pic.Name != org.Name) // si el "nombre" es distinto  (de picturebox)
            {
                if (pic.Image == null)
                {
                   
                    pic.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap); // carga la imagen
                    pic.ImageLocation = org.ImageLocation;//copia la locacion de la imagen
                    org.Image = null; // quita la imagen del origen
                    
                }
            }


        }
        #endregion
    }
}
