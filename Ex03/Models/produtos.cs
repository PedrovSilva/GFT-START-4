namespace Ex03.Models
{
    public class produtos
    {
       public string descricao {get; set;}

       public double valorReal {get; set;}

       public int operacao {get; set;}

       public double percentual {get; set;}

       public double valorFinal {get; set;}

        public produtos(string descricao, double valorReal,)
    {
        this.descricao = descricao;
        this.valorReal = valorReal;
    }

    public double descontoAcrecimo(double percentual, int operacao)
    {
        this.valorReal = valorReal;
        if(operacao == 1)
        {
            double calculo = valorReal * (percentual * 100);
           
           return this.valorFinal = valorReal - calculo;

        }

        else if(operacao == 2)
        {
            double calculo = valorReal * (percentual * 100);

            return this.valorFinal = valorReal - calculo; 
        }

        else
        {
            Console.WriteLine("Operação invalida");
        }
    }



    }

   


}