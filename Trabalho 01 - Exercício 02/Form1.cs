using System;
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
                try
                {
                    imovelNovo = new Novo(textBox1.Text, Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                    MessageBox.Show("Imóvel Novo criado");

                }
                catch
                {
                    MessageBox.Show("Dados Inválidos");
                }
            }
            else
            {
                try
                {
                    imovelVelho = new Velho(textBox1.Text, Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                    MessageBox.Show("Imóvel Velho criado");
                }
                catch
                {
                    MessageBox.Show("Dados Inválidos");
                }

            }
        }
        private void btcCalcular_Click(object sender, EventArgs e)
        {
            if (Botao1.Checked)
            {
                imovelNovo.CalcularAdicional();
                MessageBox.Show("Imóvel Novo calculado");
                return;
            }
            else
            {
                imovelVelho.CalcularDesconto();
                MessageBox.Show("Imóvel Velho calculado");
            }


        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (Botao1.Checked)
            {
                MessageBox.Show("O valor do imóvel Novo é : R$" + imovelNovo.MostrarPreço());
 
            }
            else
            {
                MessageBox.Show("O valor do imóvel velho é: R$" + imovelVelho.MostrarPreço());
            }
            
        }
    }
}
