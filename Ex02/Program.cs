namespace ex02
{
    class program
    {
        static void Main()
        {
            int[] vetor = new int[] { };

            Console.WriteLine("1- inserir numeros no  vetor\n 2- Ver numeros");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Quantos numeros serão inseridos?");
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i == n; i++)
                {
                    Console.WriteLine("Insira um numero inteiro:");



                    vetor[n] = int.Parse(Console.ReadLine());


                }
            }
        }
    }
}