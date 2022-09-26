using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumarNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // STANDALONE es un programa para
        {

            // Definif variables
            int valorInicial; // Valor inicial
            int valorFinal;
            // Definir las variables de proceso o de salida
            int resultado = 0; //asignar un valor
            // Se le agrego el valor 0 porque se utiliza para sumar la variable i y si no tiene valor no se puede hacer una operacion con el
            // asignar los valores de las cajas de texto a las variables
            valorInicial = int.Parse(textBox1.Text);
            valorFinal = int.Parse(textBox2.Text);
            // Realizar el calculo
            if(valorInicial >= valorFinal)
            {
                MessageBox.Show("El valor inicial debe ser menor"); // nos mostrara una pestaña con un mensaje 
            }
            for(int i = valorInicial; i <= valorFinal; i++) // i = valorInicial saber donde voy a iniciar, i<= valorFinal condicion para saber hasta cuando dejar de contar, i++ es para sumarle 1
            {
                resultado = resultado + i;
            }

            Resultado.Text = resultado.ToString();
        }
    }
}
