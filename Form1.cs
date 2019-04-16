using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trapezio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declarando variaveis
           double B, b, h, a ;
            //entrada de dados
            B = Convert.ToDouble(txtBasem.Text);
            b = Convert.ToDouble(txtBasep.Text);
            h = Convert.ToDouble(txtAltura.Text);
            //processamento
            a = ((B + b) * h) / 2;
            //saída de dados
            lblValor.Text= Convert.ToString(a);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblValor.Text = "";
            txtBasem.Text = "";
            txtAltura.Clear();
            txtBasep.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
