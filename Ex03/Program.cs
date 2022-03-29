using Ex03.Models;

namespace Ex03
{
    class program
    {
        static void Main()
        {
            produtos Tv = new produtos("Tv", 2499.90);
            produtos Arcondicionado = new produtos("Arcondicionado", 6499.9);
            produtos Geladeira = new produtos("Geladeira", 3499.90);
            produtos Carro = new produtos("Carro", 20499.90);

            Console.WriteLine("Desconto ou acrecimo? \n------------------ \n1- Desconto \n2- Acrecimo");
            string input1 = Console.ReadLine();

            if(input1 == "1")
            {
                Console.WriteLine("Descontar \n--------------- \n1- TV \n2- Ar condicionado \n3- Geladeira \n4- Carro");
                string input2 = Console.ReadLine();
                Console.WriteLine("insira o percentual");
                double percentual = Convert.ToDouble(Console.ReadLine());
                

                switch(input2)
                {
                    case "1":
                        Tv.descontoAcrecimo(percentual, 1);
                        break;
                    case "2":
                        Arcondicionado.descontoAcrecimo(percentual,1);
                        break;
                    case "3":
                        Geladeira.descontoAcrecimo(percentual, 1);
                        break;
                    case "4":
                        Carro.descontoAcrecimo(percentual,1);
                        break;
                    
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }

            
            }

            if(input1 == "2")
            {
                Console.WriteLine("Acrecentar \n--------------- \n1- TV \n2- Ar condicionado \n3- Geladeira \n4- Carro");
                string input2 = Console.ReadLine();
                Console.WriteLine("insira o percentual");
                double percentual = Convert.ToDouble(Console.ReadLine());
                

                switch(input2)
                {
                    case "1":
                        Tv.descontoAcrecimo(percentual, 2);
                        break;
                    case "2":
                        Arcondicionado.descontoAcrecimo(percentual,2);
                        break;
                    case "3":
                        Geladeira.descontoAcrecimo(percentual, 2);
                        break;
                    case "4":
                        Carro.descontoAcrecimo(percentual,2);
                        break;
                    
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }

        }
        else
        {
            Console.WriteLine("Opção Invalida");
        }

    }
}}
