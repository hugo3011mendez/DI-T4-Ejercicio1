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

    }
}
