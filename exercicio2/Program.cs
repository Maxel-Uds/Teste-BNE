using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite 4 números: ");
            string nums = Console.ReadLine();
            
            double maior = Char.GetNumericValue(nums[0]);
            double menor = Char.GetNumericValue(nums[0]);
            double soma = Char.GetNumericValue(nums[0]);
            for(int i = 1; i < nums.Length ; i++)
            {
                if(Char.GetNumericValue(nums[i]) < menor)
                {
                    menor = Char.GetNumericValue(nums[i]);;
                }
                else if(Char.GetNumericValue(nums[i]) > maior)
                {
                    maior = Char.GetNumericValue(nums[i]);
                }

                soma += Char.GetNumericValue(nums[i]);
            }

            Console.WriteLine($"Maior número digitado: {maior}");
            Console.WriteLine($"Menor número digitado: {menor}");
            Console.WriteLine($"Média dos números digitados: {(soma/nums.Length).ToString("F2")}");
        }
    }
}
