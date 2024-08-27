using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CajeroAslamSqlCichard
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }



        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Form1 cancelar = new Form1();
            cancelar.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 6;
            string textoActual = textBox5.Text;
            string textoFiltrado = "";

            foreach (char c in textoActual)
            {
                // Verifica si el carácter es un dígito
                if (char.IsDigit(c))
                {
                    textoFiltrado += c; // Agrega el dígito al texto filtrado
                }
            }

            // Si hubo cambios en el texto (se eliminaron caracteres no numéricos), actualiza el TextBox
            if (textoActual != textoFiltrado)
            {
                textBox5.Text = textoFiltrado;

                // Coloca el cursor al final del texto para que la experiencia del usuario sea fluida
                textBox5.SelectionStart = textBox5.Text.Length;
            }
        }

        private void NumDoc_TextChanged(object sender, EventArgs e)
        {
            NumDoc.MaxLength = 6;
            string textoActual = NumDoc.Text;
            string textoFiltrado = "";

            foreach (char c in textoActual)
            {
                // Verifica si el carácter es un dígito
                if (char.IsDigit(c))
                {
                    textoFiltrado += c; // Agrega el dígito al texto filtrado
                }
            }

            // Si hubo cambios en el texto (se eliminaron caracteres no numéricos), actualiza el TextBox
            if (textoActual != textoFiltrado)
            {
                NumDoc.Text = textoFiltrado;

                // Coloca el cursor al final del texto para que la experiencia del usuario sea fluida
                NumDoc.SelectionStart = NumDoc.Text.Length;
            }

        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }
    }
}
