using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mandarhoy.Formularios
{
    public partial class FRMingresos : Form
    {
        public FRMingresos()
        {
            InitializeComponent();
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            comboBoxfacultades.Items.Add("derecho");

            int numero1 = int.Parse(textBoxnumero1.Text);
            int numero2 = int.Parse(textBoxnumero2.Text);
            int resultado = numero1 + numero2;
            textBoxresultado.Text = resultado.ToString();


        }

        private void textBoxnumero2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBoxnumero1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxresultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxfacultades_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxfacultades.SelectedItem.ToString());

        }

        private void labelresutlado_Click(object sender, EventArgs e)
        {
           
        }

        private void FRMingresos_Load(object sender, EventArgs e)
        {

        }
    }
}
