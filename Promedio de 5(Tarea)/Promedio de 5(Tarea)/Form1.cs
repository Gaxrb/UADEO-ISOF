using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedio_de_5_Tarea_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Text = ((double.Parse(textBox1.Text) + double.Parse(textBox2.Text) + double.Parse(textBox3.Text) + double.Parse(textBox4.Text) + double.Parse(textBox5.Text)) / 5).ToString();
            
        }
    }
}
