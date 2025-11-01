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
    public partial class Form6 : Form
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
        String res;
       
        int hayalgo;

        public Form6()
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
            if (hayalgo == 0)
            {
                if (!textBox1.Text.Equals(""))
                {
                    titulo = textBox1.Text;
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
                res = textBox7.Text;
                hayalgo = 1;
            }
            else
            {
                MessageBox.Show("Llene todos los campos");
                hayalgo = 0;
            }


            if (hayalgo == 1 && imagen.Image!=null)            {

                MemoryStream ms = new MemoryStream();
                imagen.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();


                String consulta = "UPDATE coleccion_uno SET imagen= @imagen where titulo=" + "'" + titulo + "'" + "and capitulo=" + "'" + capitulo + "'";
            SqlCommand sql_cmd = new SqlCommand(consulta, Conexion.conectar());
            sql_cmd.Parameters.AddWithValue("imagen", aByte);


            try
            {
                sql_cmd.ExecuteNonQuery();

                MessageBox.Show("Su manga ha sido modificada");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conexion.modificarManga(titulo, capitulo, autor, periodicidad, genero, enlace, res);
            



        }else
            {
                MessageBox.Show("Adjunte una imagen");
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

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

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
     

      

        private void Form6_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = Form3.title;
            textBox2.Text = Form3.cap;
            textBox3.Text = Form3.autora;
            comboBox1.Text = Form3.periodo;
            comboBox2.Text = Form3.gen;
            textBox6.Text = Form3.enlace;
            textBox7.Text = Form3.res.Text;



        }

       

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}