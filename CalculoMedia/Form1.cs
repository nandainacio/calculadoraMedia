using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txt1.Text);
            double nota2 = Convert.ToDouble(txt2.Text);
            double nota3 = Convert.ToDouble(txt3.Text);
            double media = Math.Round(((nota1 + nota2 + nota3) / 3), 2);

            if(media < 6.0)
            {
                label2.Text = "Reprovado - Média " + media.ToString();
            }
            else if(media >= 6.0)
            {
                label2.Text = "Aprovado - Média " + media.ToString();
            }
            else
            {
                label2.Text = "Insira os dados novamente";
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
