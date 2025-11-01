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
    public partial class Form1 : Form
    {
        Form2 f2;
        Form7 f7;
        Conexion conexion;
        public Form1()
        {
            InitializeComponent();
            f2 = new Form2();
            f7 = new Form7();
            conexion = new Conexion();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            

            String[] consultas = new String[2]; 

            consultas= conexion.BusquedaUsuarioyContrasena(textBox1.Text, textBox2.Text);
           
            textBox2.Text=Encriptacion.GetSHA256(textBox2.Text);


            if (textBox1.Text.Equals(consultas[0]) && textBox2.Text.Equals(consultas[1]))

            {
                MessageBox.Show("Usuario y/o contraseña correctos");
                f2.ShowDialog();
                

            }else MessageBox.Show("Usuario y/o contraseña incorrectos");

           
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            f7.ShowDialog();
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

