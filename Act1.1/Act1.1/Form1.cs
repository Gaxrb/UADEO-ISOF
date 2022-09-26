using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = ((double.Parse(textBox1.Text) + double.Parse(textBox2.Text) + double.Parse(textBox3.Text)) / 3).ToString();
            if (double.Parse(textBox4.Text) >= 9)
            {
                MessageBox.Show("Alumno aprobado ");
            }
            else
            {
                MessageBox.Show("Alumno Reprobado");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
