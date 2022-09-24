using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_01___Exercício_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Novo imovelNovo = null;
        Velho imovelVelho = null;
        private void btnCriar_Click(object sender, EventArgs e)
        {
            CriarImovel();
        }
        public void CriarImovel()
        {
            if (Botao1.Checked)
            {
                imovelVelho = null;
                string endereçoImovel = textBox1.Text;
                double preçoImovel = Convert.ToDouble(textBox2.Text);
                double adicionalPreço = Convert.ToDouble(textBox3.Text);
                imovelNovo = new Novo(endereçoImovel, preçoImovel, adicionalPreço);
                MessageBox.Show("Imóvel criado");
            }
            else
            {
                imovelNovo = null;
                string endereçoImovel = textBox1.Text;
                double preçoImovel = Convert.ToDouble(textBox2.Text);
                double descontoPreço = Convert.ToDouble(textBox3.Text);
                imovelVelho = new Velho(endereçoImovel, preçoImovel, descontoPreço);
                MessageBox.Show("Imóvel criado");
            }
        }
        private void btcCalcular_Click(object sender, EventArgs e)
        {
            if (imovelNovo != null)
            {
                imovelNovo.CalcularAdicional();
                MessageBox.Show("Imóvel calculado");
                return;
            }
            MessageBox.Show("Imóvel calculado");
            imovelVelho.CalcularDesconto();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (imovelNovo != null)
            {
                MessageBox.Show("O valor do imóvel é: R$" + imovelNovo.MostrarPreço());
                return;
            }
            MessageBox.Show("O valor do imóvel é: R$" + imovelVelho.MostrarPreço());
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
