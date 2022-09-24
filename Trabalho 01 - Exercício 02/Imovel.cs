namespace Trabalho_01___Exercício_02
{
    public class Imovel
    {
        public string Endereço { get; set; }
        public double Preço { get; set; }
        public virtual double MostrarPreço()
        {
            return this.Preço;
        }
    }
}
