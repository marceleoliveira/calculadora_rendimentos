using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal aporte;
            int prazo;
            decimal taxa;
            decimal valorFinal;
            int i;

            aporte = Convert.ToDecimal(aporteTextBox.Text);
            prazo = Convert.ToInt32(prazoTextBox.Text);
            taxa = Convert.ToDecimal(taxaTextBox.Text);

            taxa = taxa / 100;
            valorFinal = aporte;


            for (i = 0; i<prazo; i++)
            {
                valorFinal = valorFinal + (valorFinal * taxa);
            };

            string[] vf;
            vf = Convert.ToString(valorFinal).Split(',');
            textBox4.Text = "R$ " + vf[0] + "," + vf[1].Substring(0,2);           

            decimal lucro = valorFinal - aporte;

            string[] lf;
            lf = Convert.ToString(lucro).Split(',');
            textBox5.Text = "R$ " + lf[0] + "," + lf[1].Substring(0, 2);

        }
    }
}
