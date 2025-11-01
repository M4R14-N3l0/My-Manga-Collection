using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMangaCollections
{
    public partial class Form5 : Form
    {
        Form6 f6;
        //public static String id;
        public static String title;
        public static String cap;
        public static String autora;
        public static String periodo;
        public static String gen;
        public static String enlace;
        public static RichTextBox res;
        public static Image imagen;
        public Form5()
        {
            InitializeComponent();
            
            f6 = new Form6();
            RichTextBox richTextBox1=new RichTextBox();
            
            
        }



       private void Form5_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
          
                conexion.RecargarImagen(pictureBox2, Form3.title, Form3.cap);

                
                label2.Text = Form3.title;
                label8.Text = Form3.cap;
                label9.Text = Form3.autora;
                label11.Text = Form3.periodo;
                label12.Text = Form3.gen;
                linkLabel1.Text = Form3.enlace;
                richTextBox1.Text = Form3.res.Text;
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            String titulo= Form3.title;
            String capitulo = Form3.cap;
            conexion.eliminarManga(titulo, capitulo);
            MessageBox.Show("El manga ha sido eliminado");
           
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            f6.ShowDialog();
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(((LinkLabel)sender).Text);
        }
    }
}
