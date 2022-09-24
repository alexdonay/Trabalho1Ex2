namespace Trabalho_01___Exercício_02
{
    public class Novo : Imovel
    {
        public double Adicional { get; set; }
        public Novo(string endereço, double preço, double porcentagemAdicional)
        {
            this.Endereço = endereço;
            this.Preço = preço;
            this.Adicional = porcentagemAdicional;
        }
        public void CalcularAdicional()
        {
            base.Preço += this.Preço * (this.Adicional / 100); ;
        }
    }
}
