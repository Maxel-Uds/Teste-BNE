using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] origem = new int[]{1, 3, 35, 40, 85, 123, 121, 209, 200, 305, 350};
            int[] pares = new int[3];
            int[] impares = new int[8];

            int indicePar = 0;
            int indiceImpar = 0;
            for(int i = 0; i < origem.Length; i++)
            {
                if(origem[i] % 2 == 0)
                {
                    pares[indicePar] = origem[i];
                    indicePar++;
                }
                else
                {
                    impares[indiceImpar] = origem[i];
                    indiceImpar++;
                }
                
            }
        }
    }
}
