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
    public partial class FormDesarrollo : Form
    {
        public FormDesarrollo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelo_Crecimiento_de_bacterias model = new Modelo_Crecimiento_de_bacterias();
            model.Show();
        }

        private void botonAplicaciones_Click(object sender, EventArgs e)
        {
            IPMP_2013 ipmp = new IPMP_2013();
            ipmp.Show();
        }
    }
}
