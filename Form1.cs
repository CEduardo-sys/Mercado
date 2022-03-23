using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (tb_codigo.Text == "")
            {
                MessageBox.Show("Informe o código do produto.");
                tb_codigo.Focus();
            }
            if (tb_qtd.Text == "")
            {
                MessageBox.Show("Informe a quantidade.");
            }
            if (tb_valorUni.Text == "")
            {
                MessageBox.Show("Informe o valor unitário.");
            }

        }

        private void radioButton_aVista_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_aVista.Checked == true)
            {
                
            }

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double qtd, valorUni, avista, credito;

            if (tb_codigo.Text.Length==0)
            {
                MessageBox.Show("Informe o código do produto.");
                tb_codigo.Focus();
            }
            else if (tb_qtd.Text.Length==0)
            {
                MessageBox.Show("Informe a quantidade");
                tb_qtd.Focus();
            }
            else if (tb_valorUni.Text.Length==0)
            {
                MessageBox.Show("Informe o valor do produto.");
                tb_valorUni.Focus();
            }
            else if (radioButton_aVista.Checked == false && radioButton_cartao.Checked == false)
            {
                MessageBox.Show("Selecione a forma de pagamento.");
            }
            else if (radioButton_aVista.Checked == true)
            {
                valorUni = double.Parse(tb_valorUni.Text);
                qtd = double.Parse(tb_qtd.Text);
                avista = (valorUni * qtd) * 0.95;
                tb_TotVista.Text = avista.ToString("C2");
                tb_TotCartao.Clear();
            }
            else if (radioButton_cartao.Checked == true)
            {
                valorUni = double.Parse(tb_valorUni.Text);
                qtd = double.Parse(tb_qtd.Text);
                avista = (valorUni * qtd) * 1.30;
                tb_TotCartao.Text = avista.ToString("C2");
                tb_TotVista.Clear();

            }


        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            tb_codigo.Clear();
            tb_qtd.Clear();
            tb_valorUni.Clear();
            tb_TotVista.Clear();
            tb_TotCartao.Clear();
            radioButton_aVista.Checked = false;
            radioButton_cartao.Checked = false;
        }
    }
}
