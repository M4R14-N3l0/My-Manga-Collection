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
    public partial class Form3 : Form
    {
        Manga manga;
        Conexion conexion;
        Form5 f5;
        //public static String id;
        public static String title;
        public static String cap;
        public static String autora;
        public static String periodo;
        public static String gen;
        public static String enlace;
        public static RichTextBox res;
        public static Image imagen;



        public Form3()
        {
            InitializeComponent();
            manga = new Manga();
            conexion = new Conexion();
            f5 = new Form5();
            res = new RichTextBox();
        }

        private void button1_Click(object sender, EventArgs e)


        {
            
            listView1.Items.Clear();
                  

                manga.setTitulo(textBox2.Text);
                manga.setCapitulo(textBox1.Text);
                manga.setAutor(textBox3.Text);
                manga.setPeriodicidad(comboBox1.Text);
                manga.setGenero(comboBox2.Text);
                manga.setEnlace(textBox6.Text);               
                conexion.Busqueda(manga, listView1);
       




        }

        

       
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

     

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        internal class listView
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            title = listView1.SelectedItems[0].SubItems[0].Text;
            cap = listView1.SelectedItems[0].SubItems[1].Text;
            autora = listView1.SelectedItems[0].SubItems[2].Text;
            periodo = listView1.SelectedItems[0].SubItems[3].Text;
            gen = listView1.SelectedItems[0].SubItems[4].Text;
            enlace= listView1.SelectedItems[0].SubItems[5].Text;
            res.Text = listView1.SelectedItems[0].SubItems[6].Text;
           


            f5.ShowDialog();
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
    }

