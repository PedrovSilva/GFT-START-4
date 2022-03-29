using Ex01.Model;

namespace atividade01
{
    class program
    {
        static void Main()
        {
             CartaoBandeiraMaster master = new CartaoBandeiraMaster();
             CartaoBandeiraVisa visa = new CartaoBandeiraVisa();
            
            Console.WriteLine("1- Visa Debito \n2- Visa Credito \n3- Master Debito\n4- Master Credito");
            
            string input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    visa.pagamentoDebito();
                    break;
                case "2":
                    visa.pagamentoCredito();
                    break;
                case "3":
                    master.pagamentoDebito();
                    break;
                case "4":
                    master.pagamentoCredito();
                    break;
                
                default:
                Console.WriteLine("Opção Invalida");
                    break;
            }




        }

 

    }
}