using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppShow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vtotal = 0;
            int ing_m = 0;
            int ing_i = 0;
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine("Você é estudante? S/N");
                string res = Console.ReadLine().ToUpper();
                if (res == "S" && i <= 10)
                {
                    double ingresso = 100 / 2;
                    vtotal += ingresso;
                    ing_m++;
                    Console.WriteLine("Ingresso comprado!!!");
                }
                else if (i <= 10)
                {
                    double ingresso = 100;
                    vtotal += ingresso;
                    ing_i++;
                    Console.WriteLine("Ingresso comprado!!!");
                }
                else if (res == "S" && i <= 20)
                {
                    double ingresso = 150 / 2;
                    vtotal += ingresso;
                    ing_m++;
                    Console.WriteLine("Ingresso comprado!!!");
                }
                else if (i <= 20)
                {
                    double ingresso = 150;
                    vtotal += ingresso;
                    ing_i++;
                    Console.WriteLine("Ingresso comprado!!!");
                }
                else if (res == "S" && i <= 30)
                {
                    double ingresso = 200 / 2;
                    vtotal += ingresso;
                    ing_m++;
                    Console.WriteLine("Ingresso comprado!!!");
                }
                else if (i <= 30)
                {
                    double ingresso = 200;
                    vtotal += ingresso;
                    ing_i++;
                    Console.WriteLine("Ingresso comprado!!!");
                }
                else { Console.WriteLine("Comando errado. Tente novamente"); }
            }
            Console.WriteLine("O faturamento total foi de: " + vtotal.ToString("C"));
            Console.WriteLine("O total de ingressos vendidos integralmente foi de: " + ing_i);
            Console.WriteLine("O total de ingressos vendidos meia foi de: " + ing_m);
            Console.ReadKey();
        }
    }
}
