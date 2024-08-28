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
using System.Data.SqlClient;

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

        private void btGuardarRegis_Click(object sender, EventArgs e)
        {
            Form1 guardar = new Form1();
            guardar.Show();
            this.Hide();

            try
            {
                SqlConnection Conexion = new SqlConnection("Server=CAMILO\\SQLEXPRESS;Database=CajeroCAM; Integrated security=True");
                SqlCommand Realiza = new SqlCommand();
                Realiza.Connection = Conexion;
                Realiza.CommandText = "insert into Registrar (Nombre,Apellido,Edad,TipDocumento,Documento,Clave) values(@Nombre,@Apellido,@Edad,@TipDocumento,@Documento,@Clave)";
                Realiza.CommandType = System.Data.CommandType.Text;
                Realiza.Parameters.AddWithValue("@Nombre", textBox1.Text);
                Realiza.Parameters.AddWithValue("@Apellido", textBox2.Text);
                Realiza.Parameters.AddWithValue("@Edad", textBox3.Text);
                Realiza.Parameters.AddWithValue("@TipDocumento", comboBox1.Text);
                Realiza.Parameters.AddWithValue("@Documento", NumDoc.Text);
                Realiza.Parameters.AddWithValue("@Clave", textBox5.Text);
                Conexion.Open();
                Realiza.ExecuteNonQuery();
                string cadena = "select top 1 * from Registrar order by NumCuenta desc ";
                SqlCommand comando = new SqlCommand(cadena, Conexion);
                SqlDataReader registros = comando.ExecuteReader();
                if (registros.Read())
                {

                    string numeroDeCuenta = registros["NumCuenta"].ToString();
                    MessageBox.Show($"Su número de cuenta es {numeroDeCuenta}", "Número de Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron registros.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
