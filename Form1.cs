using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBaraja
{
    public partial class Form1 : Form
    {
        Baraja baraja = new Baraja();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearBaraja_Click(object sender, EventArgs e)
        {
            //Mostramos los botones para evitar errores
            btnMezclar.Enabled = true;
            btnRobar.Enabled = true;
            btnCogerCarta.Enabled = true;
            txtCogerCarta.Enabled = true;
            btnCogerCartaRandom.Enabled = true;

            //Crear Baraja
            MessageBox.Show("Has creado la baraja");
            baraja = new Baraja();

            actualizarListaCartas();
        }

        private void btnRobar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Tu carta es: " + baraja.RobaCarta().ToString());
            if (lstContenido.Items.Count > 0)
            {
                pictureBoxCarta.ImageLocation = "C:/Users/enric/source/repos/WinFormBaraja/Baraja/" + baraja.RobaCarta().File;
            }
            else
            {
                MessageBox.Show("No quedan mas cartas");
            }            
            
            actualizarListaCartas();
        }

        private void btnMezclar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has barajado");
            baraja.Barajar();

            actualizarListaCartas();
        }

        private void btnCogerCarta_Click(object sender, EventArgs e)
        {
            bool itsANumber;
            int num;
            itsANumber = Int32.TryParse(txtCogerCarta.Text, out num);

            if (!itsANumber) {
                MessageBox.Show("Introduce un numero valido");
            }
            else
            {
                num--;
                if (num >= 0 && num < baraja.NumeroCartas())
                {
                    //MessageBox.Show("Tu carta es: " + baraja.CogeCarta(num).ToString());
                    pictureBoxCarta.ImageLocation = "C:/Users/enric/source/repos/WinFormBaraja/Baraja/" + baraja.CogeCarta(num).File;

                    actualizarListaCartas();
                }
                else
                {
                    MessageBox.Show("Ese numero de carta no existe");
                }
            }
        }

        private void btnCogerCartaRandom_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Tu carta es: " + baraja.CogeCartaAlAzar().ToString());
            pictureBoxCarta.ImageLocation = "C:/Users/enric/source/repos/WinFormBaraja/Baraja/" + baraja.CogeCartaAlAzar().File;

            actualizarListaCartas();
        }
        private void actualizarListaCartas()
        {
            //Actualizar Lista
            lstContenido.Items.Clear();
            lstContenido.Items.AddRange(baraja.BarajaCartas.ToArray());

            //Actualizar numero cartas
            lblNumCartas.Text = baraja.NumeroCartas().ToString();
        }
    }
}
