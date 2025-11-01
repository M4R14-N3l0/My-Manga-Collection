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
    public partial class Form2 : Form
    {
        Form3 f3;
        Form4 f4;
        public Form2()
        {
            InitializeComponent();
            f3 = new Form3();
            f4 = new Form4();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            f3.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f4.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
