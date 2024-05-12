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
             textBoxresultado.Text = textBoxnumero1.Text + textBoxnumero2.Text ;
            
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
    }
}
