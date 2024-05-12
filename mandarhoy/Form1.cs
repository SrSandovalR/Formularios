using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mandarhoy.Formularios;

namespace mandarhoy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido");

        }

        private void buttoningreso_Click(object sender, EventArgs e)
        {
          textBoxusuario.Text =  textBoxusuario.Text.ToLower();
           textBoxcontra.Text = textBoxcontra.Text.ToLower();
            int intento = 0;
            if (textBoxusuario.Text.Equals("admin") && textBoxcontra.Text.Equals("admin"))
            {
            FRMingresos form = new FRMingresos();
             form.Show();
            }
            else
            {
                
                textBoxcontra.Clear();
                textBoxusuario.Clear();
                MessageBox.Show("denegado");
                intento++;

            }


            if(intento >= 3) {
            buttoningreso.Enabled = false;
            }
            



        }

        private void textBoxcontra_TextChanged(object sender, EventArgs e)
        {
            
        }

        //private void Inicio_Click(object sender, EventArgs e)
        //{
        //    FRMingresos form = new FRMingresos();
        //    form.Show();
        //}
    }
}
