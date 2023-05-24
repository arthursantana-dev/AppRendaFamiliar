using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRendaFamiliar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double renda = double.Parse(txtRendaFamiliar.Text);

            double gastos = 0;

            gastos += double.Parse(txtEnergia.Text);
            gastos += double.Parse(txtInternet.Text);
            gastos += double.Parse(txtAgua.Text);
            gastos += double.Parse(txtAlimentacao.Text);
            gastos += double.Parse(txtOutrosGastos.Text);

            lblGastosTotais.Text = gastos.ToString("C");
            lblSaldo.Text = (renda-gastos).ToString("C");

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtRendaFamiliar, txtEnergia, txtInternet, txtAgua, txtAlimentacao, txtOutrosGastos };
            foreach(TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }

            lblGastosTotais.Text = "R$0,00";
            lblSaldo.Text = "R$0,00";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
