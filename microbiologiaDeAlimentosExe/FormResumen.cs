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
    public partial class FormResumen : Form
    {
        public FormResumen()
        {
            InitializeComponent();
        }

        private void botonMenu_Click(object sender, EventArgs e)
        {
            FormMenu Menu = new FormMenu();
            Menu.Show();
        }
    }
}
