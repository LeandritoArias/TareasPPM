using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Leandro
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char operador;



        public Form1()
        {
            InitializeComponent();
        }

        private void agregar_numero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (txtResult.Text == "0")
                txtResult.Text = "";

            txtResult.Text += boton.Text;
        }

        private void buttonIGUAL_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(txtResult.Text);

            if (operador == '+' )
            
                txtResult.Text = (Numero1 + Numero2) .ToString();
                Numero1 = Convert.ToDouble (txtResult.Text);
            if (operador == '-')

                txtResult.Text = (Numero1 - Numero2).ToString();
            Numero1 = Convert.ToDouble(txtResult.Text);
            if (operador == 'x')

                txtResult.Text = (Numero1 * Numero2).ToString();
            Numero1 = Convert.ToDouble(txtResult.Text);
            if (operador == '%')

                txtResult.Text = (Numero1 / Numero2).ToString();
            Numero1 = Convert.ToDouble(txtResult.Text);
         /*   if (operador == 'x²')

                txtResult.Text = (Numero1 + Numero2).ToString();
            Numero1 = Convert.ToDouble(txtResult.Text);
            if (operador == '√')

                txtResult.Text = (Numero1 + Numero2).ToString();
            Numero1 = Convert.ToDouble(txtResult.Text);*/
        }

        private void clickOperador (object sender, EventArgs e)
        {
            var boton = (Button)sender;
            Numero1 = Convert.ToDouble(txtResult.Text);
            operador = Convert.ToChar(boton.Text);
            txtResult.Text = "0";
        }

    }
}
