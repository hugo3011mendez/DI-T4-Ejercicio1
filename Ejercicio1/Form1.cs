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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #if TECLA
                this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            #elif !TECLA
                    this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            #endif
        }

        // Mouse Move del Form
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = Form1.MousePosition.ToString();
        }


        // Y le indico que cuando el cursor del ratón no esté en la parte visible del Form el título de éste cambie a su valor original
        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            Text = "Mouse Tester";
        }


        // Mouse Move del botón izquierdo
        private void btnIzquierdo_MouseMove(object sender, MouseEventArgs e)
        {
            Text = Form1.MousePosition.ToString();
        }


        // Mouse Move del botón derecho
        private void btnDerecho_MouseMove(object sender, MouseEventArgs e)
        {
            Text = Form1.MousePosition.ToString();
        }


        // Función que controla la pulsación de los dos botones
        private void pulsarBoton(object sender, MouseEventArgs e)
        {
            if (sender == btnIzquierdo && e.Button == MouseButtons.Left)
            {
                btnIzquierdo.BackColor = Color.IndianRed; // Pongo el color de fondo del formulario a rojo
            }
            else if (sender == btnDerecho && e.Button == MouseButtons.Right)
            {
                btnDerecho.BackColor = Color.BlueViolet; // Pongo el color de fondo del formulario a azul
            }
        }


        // Función que controla cuando se suelta la pulsación de los dos botones
        private void soltarBoton(object sender, MouseEventArgs e)
        {
            if (sender == btnIzquierdo)
            {
               btnIzquierdo.BackColor = SystemColors.Control;
            }
            else if (sender == btnDerecho)
            {
                btnDerecho.BackColor = SystemColors.Control;
            }
        }


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
