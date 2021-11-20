using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadenaDeCaracteresTar2
{
    public partial class frmInvertirCadena : Form
    {
        public frmInvertirCadena()
        {
            InitializeComponent();
        }
        string original, salida;

       
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            salida = invertircaracteres(original);
            textBox2.Text = salida.ToString();


            txtContarPalabras.Text = "" + textBox1.TextLength; 

        }
        public string invertircaracteres(string original)
        {
            string invierte = "";
            for (int i = original.Length - 1; i >= 0; i--)
                invierte += original[i];
            return invierte;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            original = textBox1.Text;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
