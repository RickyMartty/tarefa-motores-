using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Motores_07_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p, o;
            double[] mot = new double[15];

            do
            {
                Console.WriteLine("Escolha uma das opções abaixo:");
                Console.WriteLine("(0) Sair.");
                Console.WriteLine("(1) Lançar gastos.");
                Console.WriteLine("(2) Mostrar gastos.");
                Console.WriteLine("(3) Motor de maior gasto.");
                Console.Write("Sua opção:");
                p = int.Parse(Console.ReadLine());
                Console.Clear();

                if (p == 1)
                {
                    Console.Write("Identifique o motor: (1-15):");
                    o = int.Parse(Console.ReadLine());
                    o--;
                    Console.Write("Descreva o valor gasto:");
                    mot[o] = double.Parse(Console.ReadLine());
                    Console.Clear();
                }

                if (p == 2)
                {
                    for(int i = 0; i<15; i++)
                    {
                        Console.WriteLine($" Motor {i+1}: {mot[i]}");
                    }
                }

                if (p == 3)
                {
                    var vmax = mot.Max();
                    for (int i = 0; i < 15; ++i)
                    {
                        if (mot[i] == vmax)
                        {
                            Console.WriteLine($"O motor de maior gasto foi o Motor {i+1}, com {vmax} reais em gastos.");
                        }
                    }
                   
                }


            } while(p!=0);
            Console.Clear();
        }
    }
}
