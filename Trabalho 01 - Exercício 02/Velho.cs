using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_01___Exercício_02
{
    internal class Velho : Imovel
    {
        public double Desconto;
        public Velho(string endereço, double preço, double porcentagemDesconto)
        {
            this.Endereço = endereço;
            this.Preço = preço;
            this. Desconto = porcentagemDesconto;
        }
        public void CalcularDesconto()
        {
            base.Preço -= this.Preço * (this.Desconto / 100);
        }
    }
}
