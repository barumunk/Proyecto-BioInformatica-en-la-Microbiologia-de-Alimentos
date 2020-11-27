using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace microbiologiaDeAlimentos
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void botonIntroduccion_Click(object sender, EventArgs e)
        {
            Introduccion Intro = new Introduccion();
            Intro.Show();
        }

        private void botonDesarrollo_Click(object sender, EventArgs e)
        {
            FormDesarrollo desarollo = new FormDesarrollo();
            desarollo.Show();
        }

        private void botonPractica_Click(object sender, EventArgs e)
        {
            FormPractica Pract = new FormPractica();
            Pract.Show();
        }

        private void botonAplicaciones_Click(object sender, EventArgs e)
        {
            FormAplicaciones App = new FormAplicaciones();
            App.Show();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
