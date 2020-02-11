using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero_Automatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRetirar_Click(object sender, EventArgs e)
        {
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
            double cantidad = double.Parse(TxtCantidad.Text);
            sbyte n = 0;
            String Respuesta = "Respuesta: \n";
            foreach (double denominacion in denominaciones)
            {
                while (denominacion<=Math.Round(cantidad,2))
                {
                    n++;
                    cantidad -= denominacion;
                }
                if (n > 0)
                {
                    Respuesta += n + (denominacion>1 ? "Billetes" : "Monedas") + denominacion + "\n";
                }
                n = 0;
            }
            LblRespuesta.Text = Respuesta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, a, b = 0;
            x = Convert.ToInt32(txtNP.Text);
           
            for (a = 1; a <= x; a++)
            {

                if (x % a == 0)
                    b++;
            }

            if (b!=2)

            {
                lblRP.Text ="El numero no es primo.";
            }
            else
            {
                lblRP.Text = "El numero es primo.";
            }
            
        }

        private void btnMF_Click(object sender, EventArgs e)
        {
            int a, b, c, d, num;
            a = 0;
            b = 1;

            listBox1.Items.Add(a);
            listBox1.Items.Add(b);
            num = Convert.ToInt32(txtF.Text);

            for(d=3;d<=num; d++)
            {
                c = a + b;
                listBox1.Items.Add(c);
                a = b;
                b = c;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            double cambio;
            double pagar = double.Parse(txtTotal.Text);
            double efectivo = double.Parse(txtPaga.Text);
            sbyte n = 0;
            cambio = (efectivo - pagar);
            {
                {
                    n++;
                }
                if (n > 0);
            }
            {
                lblCambio.Text = "Su cambio es de: " + cambio;
            }
        }
    }
}
