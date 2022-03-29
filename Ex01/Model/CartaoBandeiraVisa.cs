using Ex01.Interfaces;

namespace Ex01.Model
{
    public class CartaoBandeiraVisa : IPagamentoCartao
    {
        public void pagamentoCredito()
        {
            Console.WriteLine("Credito \nPago com Visa");
        }

        public void pagamentoDebito()
        {
            Console.WriteLine("Debito \nPago com Visa");
        }
    }
}