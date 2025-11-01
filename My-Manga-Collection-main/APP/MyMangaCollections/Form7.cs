using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMangaCollections
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.conectar();


            
            String usuario = textBox1.Text;
            String contrasena = textBox2.Text;
            String contrasena2 =Encriptacion.GetSHA256(contrasena);
         

            String insertar = "INSERT INTO usuarios (usuario, contrasena) values (" + "'" +usuario + "'" + "," + "'" + contrasena2 + "'" + ");";
            SqlCommand sql_cmd = new SqlCommand(insertar, Conexion.conectar());
          


            try
            {
                sql_cmd.ExecuteNonQuery();

                MessageBox.Show("Su usuario ha sido registrado con exito");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }




        }

    }
}

