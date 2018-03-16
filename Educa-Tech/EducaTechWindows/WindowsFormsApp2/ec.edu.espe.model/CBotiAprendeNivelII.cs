using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppBotiAprende
{
    class CBotiAprendeNivelII
    {

        int TamanioColumnasFilas = 4;
        int Movimientos = 0;
        int CantidadDeCartasVolteadas = 0;
        List<string> CartasEnumeradas;
        List<string> CartasRevueltas;
        ArrayList CartasSeleccionadas;
        PictureBox CartaTemporal1;
        PictureBox CartaTemporal2;
        PictureBox[] CartaTemporal = new PictureBox[16];
        int CartaActual = 0, CartaActual2 = 0;
        CSound sonidos = new CSound();


        public List<string> CartasEnumeradas1 { get => CartasEnumeradas; set => CartasEnumeradas = value; }
        public ArrayList CartasSeleccionadas1 { get => CartasSeleccionadas; set => CartasSeleccionadas = value; }
        public PictureBox CartaTemporal11 { get => CartaTemporal1; set => CartaTemporal1 = value; }
        public PictureBox CartaTemporal21 { get => CartaTemporal2; set => CartaTemporal2 = value; }
        public PictureBox[] CartaTemporal3 { get => CartaTemporal; set => CartaTemporal = value; }

        public void juego(Panel PanelJuego, Timer esconderCartas, Timer abrirCartas, Label lblScores, PictureBox picScores, PictureBox picHelp, Button btnLevel3, Timer timeScore, AxWMPLib.AxWindowsMediaPlayer player)
        {
            
            esconderCartas.Enabled = false;
            esconderCartas.Stop();
            lblScores.Text = "0";
            CantidadDeCartasVolteadas = 0;
            Movimientos = 0;
            PanelJuego.Controls.Clear();
            CartasEnumeradas = new List<string>();
            CartasRevueltas = new List<string>();
            CartasSeleccionadas = new ArrayList();
            for (int i = 1; i < 9; i++)
            {
                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());
            }
            var NumeroAleatorio = new Random();
            var Resultado = CartasEnumeradas.OrderBy(item => NumeroAleatorio.Next());
            foreach (string ValorCarta in Resultado)
            {
                CartasRevueltas.Add(ValorCarta);
            }
            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = TamanioColumnasFilas;
            tablaPanel.ColumnCount = TamanioColumnasFilas;
            for (int i = 0; i < TamanioColumnasFilas; i++)
            {
                var Porcentaje = 150f / (float)TamanioColumnasFilas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));

            }
            int contadorFichas = 1;

            for (var i = 0; i < TamanioColumnasFilas; i++)
            {
                for (var j = 0; j < TamanioColumnasFilas; j++)
                {
                    var CartasJuego = new PictureBox();
                    CartasJuego.Name = string.Format("{0}", contadorFichas);
                    CartasJuego.Dock = DockStyle.Fill;
                    CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJuego.Image = WindowsFormsApp2.Properties.Resources.botiquin;
                    CartasJuego.VisibleChanged += show;
                    CartasJuego.Cursor = Cursors.Hand;
                    CartasJuego.Click += selection;
                    player.close();
                    tablaPanel.Controls.Add(CartasJuego, j, i);
                    contadorFichas++;
                }
            }
            tablaPanel.Dock = DockStyle.Fill;
            PanelJuego.Controls.Add(tablaPanel);


            void show(object sender, EventArgs e)
            {
                if (CartasSeleccionadas.Count < 16)
                {

                    var CartasSeleccionadasUsuario = (PictureBox)sender;

                    CartaActual2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionadasUsuario.Name) - 1]);
                    CartasSeleccionadasUsuario.Image = RecuperarImagen(CartaActual2);
                    CartasSeleccionadas.Add(CartasSeleccionadasUsuario);
                    CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                    CartaTemporal1.Enabled = false;
                    CartasSeleccionadasUsuario.Image = RecuperarImagen(CartaActual2);
                    if (CartasSeleccionadas.Count == 16)
                    {
                        CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                        CartaTemporal2 = (PictureBox)CartasSeleccionadas[1];

                        for (int i = 0; i < 16; i++)
                        {

                            CartaTemporal3[i] = (PictureBox)CartasSeleccionadas[i];


                        }
                        abrirCartas.Enabled = true;
                        abrirCartas.Start();
                        for (int i = 0; i < 16; i++)
                        {
                            CartaTemporal3[i].Enabled = true;
                        }

                    }
                }
            }


            void selection(object sender, EventArgs e)
            {
                player.close();
                picHelp.Hide();
                if (CartasSeleccionadas.Count < 2)
                {
                    Movimientos++;
                    lblScores.Text = Convert.ToString(Movimientos);
                    var CartasSeleccionadasUsuario = (PictureBox)sender;
                    CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionadasUsuario.Name) - 1]);
                    CartasSeleccionadasUsuario.Image = RecuperarImagen2(CartaActual);
                    CartasSeleccionadas.Add(CartasSeleccionadasUsuario);
                    CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                    CartaTemporal1.Enabled = false;
                    if (CartasSeleccionadas.Count == 2)
                    {
                        CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                        CartaTemporal2 = (PictureBox)CartasSeleccionadas[1];
                        int Carta1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal1.Name) - 1]);
                        int Carta2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal2.Name) - 1]);
                        if (Carta1 != Carta2)
                        {
                            esconderCartas.Enabled = true;
                            esconderCartas.Start();
                            CartaTemporal1.Enabled = true;
                            CartaTemporal2.Enabled = true;
                        }
                        else
                        {
                            CantidadDeCartasVolteadas++;
                            if (CantidadDeCartasVolteadas > 7)
                            {
                                CScore CScores = new CScore();
                                CartaTemporal1.Visible = false;
                                CartaTemporal2.Visible = false;
                                tablaPanel.Visible = false;
                                CScores.ScoresNivel2(Movimientos, picScores, btnLevel3,timeScore);
                                PanelJuego.Controls.Add(picScores);
                            }
                            CartaTemporal1.Enabled = false; CartaTemporal2.Enabled = false;
                            CartasSeleccionadas.Clear();
                        }
                    }
                }
            }

            Bitmap RecuperarImagen(int Num)
            {           
                Bitmap TmpImg = new Bitmap(200, 100);
                switch (Num)
                {
                    case 0:
                        TmpImg = WindowsFormsApp2.Properties.Resources.img10;
                        break;
                    default:
                        TmpImg = (Bitmap)WindowsFormsApp2.Properties.Resources.ResourceManager.GetObject("img" + Num);
                        break;
                }
                return TmpImg;
            }

            Bitmap RecuperarImagen2(int NumeroImagen)
            {           
                Bitmap TmpImg = new Bitmap(200, 100);
               
                switch (NumeroImagen)
                {
                    case 0:
                        TmpImg = WindowsFormsApp2.Properties.Resources.img10;
                        break;
                    default:
                        picHelp.Hide();
                        TmpImg = (Bitmap)WindowsFormsApp2.Properties.Resources.ResourceManager.GetObject("img" + NumeroImagen);
                        switch (NumeroImagen)
                        {
                            case 1:
                                sonidos.Sound(NumeroImagen);
                                break;

                            case 2:
                                sonidos.Sound(NumeroImagen);
                                break;

                            case 3:
                                sonidos.Sound(NumeroImagen);
                                break;

                            case 4:
                                sonidos.Sound(NumeroImagen);
                                break;

                            case 5:
                                sonidos.Sound(NumeroImagen);
                                break;

                            case 6:
                                sonidos.Sound(NumeroImagen);
                                break;

                            case 7:
                                sonidos.Sound(NumeroImagen);
                                break;

                            case 8:
                                sonidos.Sound(NumeroImagen);
                                break;

                            case 9:
                                sonidos.Sound(NumeroImagen);
                                break;

                            case 10:
                                sonidos.Sound(NumeroImagen);
                                break;

                            case 11:
                                sonidos.Sound(NumeroImagen);
                                break;
                        }
                        break;
                }
                return TmpImg;
            }
       
        }

    }
}
