using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_5Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1, num2, rezultatas;
            char veiksmas;


            Console.Write("Iveskite pirma skaiciu ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Iveskite veiksma (+, -, *, /) ");
            veiksmas = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Iveskite antra skaiciu  ");
            num2 = Convert.ToDouble(Console.ReadLine());

            double resultatas = apskaiciavimas(num1, num2, veiksmas);

            Console.WriteLine(resultatas);


        }

        static double apskaiciavimas(double num1, double num2, char veiksmas)
        {
            switch (veiksmas)
            {

                case '+':

                    return prideti(num1, num2);
                case '-':
                    return atimti(num1, num2);
                case '*':
                return dauginti(num1, num2);
                case '/':
                    return dalinti(num1, num2);
                default:
                    Console.WriteLine("Neteisingas pasirinkimas");
                    return 0;


            }



        }
        static double prideti(double num1, double num2)
        {
            return num1 + num2;
        }

        static double atimti(double num1, double num2)
        {
            return num1 - num2;
        }

        static double dauginti(double num1, double num2)
        {
            return num1 * num2;
        }

        static double dalinti(double num1, double num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0;
            }
        }
    }
}
    

