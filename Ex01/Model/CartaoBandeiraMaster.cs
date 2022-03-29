using Ex01.Interfaces;

namespace Ex01.Model
{
    public class CartaoBandeiraMaster : IPagamentoCartao
    {
        public void pagamentoCredito()
        {
            Console.WriteLine("Credito \nPago com Master");
        }

        public void pagamentoDebito()
        {
            Console.WriteLine("Debito \nPago com Master");
        }
    }
}