using System;

namespace ISoft
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            float menor = 0;
            float maior = 0;
            float soma = 0;
 

            while (n <= 10)
            {
                Console.WriteLine("Insira o " + n + " ° número diferente de zero");
                int a = Convert.ToInt32(Console.ReadLine());
                n = n + 1;
                soma = soma + a;

                if (maior == 0)
                {
                    maior = a;
                }

                if (menor == 0)
                {
                    menor = a;
                }
                
                if (a <= menor)
                {
                    menor = a;
                }
                if (a >= maior )
                {
                    maior = a;
                }

            }

            Console.WriteLine("O menor número é: " + menor);
            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("A soma dos números é: " + soma);
            Console.WriteLine("A média dos números é: " + soma / 10);

        }
    }
}
