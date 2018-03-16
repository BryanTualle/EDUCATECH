using System;
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
    class CRandom
    {
        #region attributes
        private Point[] position = new Point[8] {new Point(14, 5), new Point(217, 5), new Point(423, 5),
                                                 new Point(628, 5), new Point(14, 161), new Point(217, 161),
                                                 new Point(423, 161), new Point(628, 161)};

        private Random random = new Random();
        int[] randomNum;
        #endregion

        #region methods
        //Realiza ranfom de posiciones
        public void Position(PictureBox Image1, PictureBox Image2, PictureBox Image3, PictureBox Image4,
                             PictureBox Image5, PictureBox Image6, PictureBox Image7, PictureBox Image8)
        {
           randomNum = new int[8] { -1, -1, -1, -1, -1, -1, -1, -1 };


            int auxiliar = 0;
            int contador = 0;

            for (int i = 0; i < 8; i++)
            {
                auxiliar = random.Next(8);
                bool continuar = false;

                while (!continuar)
                {
                    for (int j = 0; j <= contador; j++)
                    {
                        if (auxiliar == randomNum[j])
                        {
                            continuar = true;
                            j = contador;
                        }
                    }

                    if (continuar)
                    {
                        auxiliar = random.Next(8);
                        continuar = false;
                    }
                    else
                    {
                        continuar = true;
                        randomNum[i] = auxiliar;
                        contador++;
                    }
                }
            }


            Image1.Location = position[randomNum[0]];
            Image2.Location = position[randomNum[1]];
            Image3.Location = position[randomNum[2]];
            Image4.Location = position[randomNum[3]];
            Image5.Location = position[randomNum[4]];
            Image6.Location = position[randomNum[5]];
            Image7.Location = position[randomNum[6]];
            Image8.Location = position[randomNum[7]];

        }
        #endregion
    }
}
