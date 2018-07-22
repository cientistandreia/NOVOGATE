using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gateTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int numeroQtd = 10;
            int[] numeros = new int[numeroQtd];
            int maior = 0, posicao_maior = 0;
            Console.WriteLine("Informe 10 números inteiros:" + numeroQtd);
            for (int i = 0; i < numeroQtd; i++)
            {
                Console.WriteLine((i + 1) + "º número:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Maior valor:" +  (numeroQtd - i));
                //numeros[i] = numeroQtd - i;
                if (i == 0)
                {
                    maior = numeros[0];
                    maior = numeros[1];
                    maior = numeros[2];
                    maior = numeros[3];
                    maior = numeros[4];
                    maior = numeros[5];
                    maior = numeros[6];
                    maior = numeros[7];
                    maior = numeros[8];
                    maior = numeros[9];

                }
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                    posicao_maior = i;
                    numeros[i] = i;
                }
            }
            Console.WriteLine("O maior número é:" + maior);
            Console.Read();


        }

    }
}


