#define TECLA

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();

            #if TECLA
                this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            #elif !TECLA
                    this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            #endif
        }


        // Función que controla el movimiento del cursor del ratón en el formulario
        private void moverRaton(object sender, MouseEventArgs e)
        {
            Button boton; // Creo una variable de tipo botón para castear el sender

            // Dependiendo del sender, muestro las coordenadas correctas
            if (sender is Button) // Si el sender es un botón...
            {
                boton = (Button)sender; // Establezco la variable tipo Button al sender casteado como Button
                Text = "X : " + (e.X + boton.Location.X) + " Y : " + (e.Y + boton.Location.Y);
            }
            else
            {
                Text = "X : " + e.X + " Y : " + e.Y;
            }
        }


        // Y le indico que cuando el cursor del ratón no esté en la parte visible del Form el título de éste cambie a su valor original
        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            Text = "Mouse Tester";
        }


        // Función que controla la pulsación de los dos botones
        private void pulsarBoton(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnIzquierdo.BackColor = Color.IndianRed; // Pongo el color de fondo del formulario a rojo
            }
            else if (e.Button == MouseButtons.Right)
            {
                btnDerecho.BackColor = Color.BlueViolet; // Pongo el color de fondo del formulario a azul
            }
            else if (e.Button == MouseButtons.Middle)
            {
                btnIzquierdo.BackColor = Color.IndianRed; // Pongo el color de fondo del formulario a rojo
                btnDerecho.BackColor = Color.BlueViolet; // Pongo el color de fondo del formulario a azul
            }
        }


        // Función que controla cuando se suelta la pulsación de los dos botones
        private void soltarBoton(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnIzquierdo.BackColor = SystemColors.Control;
            }
            else if (e.Button == MouseButtons.Right)
            {
                btnDerecho.BackColor = SystemColors.Control; 
            }
            else if (e.Button == MouseButtons.Middle)
            {
                btnIzquierdo.BackColor = SystemColors.Control; 
                btnDerecho.BackColor = SystemColors.Control;
            }
        }


        // Función que indica las acciones a realizar cuando se realiza una pulsación de una tecla
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Escape)
            {
                Text = e.KeyChar.ToString();
            }
            else
            {
                Text = "Mouse Tester";
            }
        }


        // Función que indica las acciones a realizar cuando se presiona una tecla
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape)
            {
                Text = e.KeyCode.ToString();
            }
            else
            {
                Text = "Mouse Tester";
            }
        }


        // Acciones a realizar cuando se quiere salir del Form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Ejercicio 1", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
