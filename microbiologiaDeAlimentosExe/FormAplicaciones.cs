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
    public partial class FormAplicaciones : Form
    {
        public FormAplicaciones()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonEnf_CheckedChanged(object sender, EventArgs e)
        {
            labelTexto.Text = "Según la Organización Mundial de la Salud más de 200 enfermedades son" +
               "propagadas por el consumo de alimentos. Millones de personas al año padecen enfermedades a causa de"
               + "la transmisión de enfermedades alimentarias. Y los riesgos microbiológicos y los contaminantes químicos"
               + "son los mayores causantes de la seguridad alimentaria.\n"
               + "La globalización de los mercados es una de las grandes causantes de la propagación de las enfermedades"
               + "alimentarias. Cierto es que existen sistemas de seguridad, controles y normativas alimentarias que ayudan"
               + "a garantizar la salubridad de los alimentos.\n" + " El APPCC es uno de ellos y controla cada una de las etapas de"
               + "la producción con el fin de prevenir este tipo de peligros en el proceso de manipulación de los productos.";
        }

        private void radioButtonVirus_CheckedChanged(object sender, EventArgs e)
        {
            labelTexto.Text = " Los brotes de enfermedades virales trasmitidas por alimentos o por agua frecuentemente se atribuyen a "+
                           "la higiene personal deficiente, provisión de agua contaminada o pescado capturado en aguas contaminadas por desechos.\n"
                           + "\n"
                           + "\n"
                            + "Los alimentos involucrados son pescado crudo, vegetales crudos, ensaladas y agua contaminada con heces humanas. \n"
                            + "\n"
                            + "\n"
                            + "Los virus asociados a la transmisión por alimento incluyen los de las hepatitis A y E, virus Norwalk y rotavirus.";
        }

 

        private void radioButtonProd_CheckedChanged(object sender, EventArgs e)
        {
            labelTexto.Text = "La producción de alimentos por técnicas micro biológicas es una actividad de larga historia: los microorganismos alteran los"
                 + "constituyentes de los alimentos de forma que los estabilizan permitiendo su mayor duración y, además,"
                 + "proporcionan compuestos que confieren sabores característicos a los alimentos por ellos producidos."
                 + "\n"
                 + "\n"
                 + "\n"
                 + "Esta faceta se complementa con la acción de microorganismos alterantes de los alimentos y responsables de su"
                 + "deterioro de forma que se hagan inaceptables por los consumidores.";
        
        }
    }
}
