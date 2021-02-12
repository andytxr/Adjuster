using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adjuster
{
    class Adjuster
    {
        
            static int qtde;
            static AdjusterBase adj = new AdjusterBase();
            static int[] vetor = new int[qtde];
            static double perc;

            public static void QuantityReader()
            {

                Console.Write("How Many Employees? ");
                qtde = int.Parse(Console.ReadLine());


                if (qtde < 2 || qtde > 200)
                {
                     do
                     {
                        Console.WriteLine("Choose again the quantity! (Choose between 2 and 200)");
                        Console.Write("Re-enter the quantity: ");
                        qtde = int.Parse(Console.ReadLine());
                     } while (qtde < 2 || qtde > 200);
                }
            }

            public static void ReadjustPercentage()
            {
                Console.WriteLine("Enter with the readjust percentage: ");
                perc = double.Parse(Console.ReadLine());

                adj.readjusterValue(perc);
            }

            public static void Entry()
            {
                ReadjustPercentage();

                for (int i = 0; i < qtde; i++)
                {
                    Console.Write("Days Quantity: ");
                    adj.qtdDays = int.Parse(Console.ReadLine());

                    Console.Write("Hour Value: ");
                    adj.valueHour = double.Parse(Console.ReadLine());

                    Exit();
                }
            }

            public static void Exit()
            {               
                Console.WriteLine("Hour Value: {0:c}", adj.valueHour);
                Console.WriteLine("Days Quantity: {0}", adj.qtdDays);
                Console.WriteLine("Wage: {0:c}", adj.salCalc);
            }

            public static void Main(string[] args)
            {
                QuantityReader();
                Entry();

                Console.ReadKey();
            }
    }
}
