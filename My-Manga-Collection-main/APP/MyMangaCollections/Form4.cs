using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMangaCollections
{
    public partial class Form4 : Form
    {
        Manga manga;
        Conexion conexion;
        public static PictureBox imagen;
        String titulo;
        String capitulo;
        String autor;
        String periodicidad;
        String genero;
        String enlace;
        String resumen;
     
        int hayalgo;
        public Form4()
        {
            InitializeComponent();
            manga = new Manga();
            conexion = new Conexion();
            imagen = new PictureBox();  
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.conectar();
            hayalgo = 0;
            if (hayalgo == 0) { 
            if(!textBox1.Text.Equals(""))
            {
                titulo=textBox1.Text;
                hayalgo = 1;    
                }
            }
            if (!textBox2.Text.Equals(""))
                {
                capitulo = textBox2.Text;
                hayalgo = 1;
                }
            if (!textBox3.Text.Equals(""))
            {
                autor = textBox3.Text;
                hayalgo = 1;
            }
            if (!comboBox1.Text.Equals(""))
            {
                periodicidad = comboBox1.Text;
                hayalgo = 1;
            }
            if (!comboBox2.Text.Equals(""))
            {
                genero = comboBox2.Text;
                hayalgo = 1;
            }
            if (!imagen.Text.Equals(""))
            {

               
                hayalgo = 1;
            }
            if (!textBox6.Text.Equals(""))
            {
                enlace = textBox6.Text;
                hayalgo = 1;
            }

            if (!textBox7.Text.Equals(""))
            {
                resumen = textBox7.Text;
                hayalgo = 1;
            }
            else
            {
                MessageBox.Show("Llene todos los campos");
                hayalgo = 0;
            }


            if(hayalgo == 1)
            {

            MemoryStream ms = new MemoryStream();
            imagen.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            String insertar = "INSERT INTO coleccion_uno (titulo, capitulo,autor,periodicidad, genero, enlace, imagen, resumen) values (" + "'" + titulo + "'" + "," + "'" + capitulo + "'" + "," + "'" +autor + "'" + "," + "'" + periodicidad + "'" + "," + "'" + genero + "'" + "," + "'" + enlace + "'" + "," + "@imagen" + "," + "'" + resumen + "'" + ");";
            Console.WriteLine(insertar);
            SqlCommand sql_cmd = new SqlCommand(insertar, Conexion.conectar());
            sql_cmd.Parameters.AddWithValue("imagen", aByte);
           

            try
            {
                sql_cmd.ExecuteNonQuery();

                MessageBox.Show("Su manga ha sido registrada");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            }


        }

     

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.Title = "Seleccionar imagen";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
            
                imagen.Image = Image.FromFile(openFileDialog1.FileName);
            
            }  
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
