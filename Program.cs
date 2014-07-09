using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату xA: ");
            Double xA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату yA: ");
            Double yA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату xB: ");
            Double xB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату yB:");
            Double yB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату xC: ");
            Double xC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату yC: ");
            Double yC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату xM: ");
            Double xM = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату yM: ");
            Double yM = Convert.ToDouble(Console.ReadLine());

            Double a = Math.Sqrt((xB - xA) + (yB - xA));
            Double b = Math.Sqrt((xC - xB) + (yC - yB));
            Double c = Math.Sqrt((xA - xC) + (yA - yC));

            Double P = ((a + b + c) / 2);
            Double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));

            Double q = Math.Sqrt((xM - xA) + (yM - yA));
            Double w = Math.Sqrt((xM - xB) + (yM - yB));
            Double r = Math.Sqrt((xM - xC) + (yM - yC));

            Double P1 = ((a + q + w) / 2);
            Double S1 = Math.Sqrt(P1 * (P1 - a) * (P1 - q) * (P1 - w));

            Double P2 = ((b + r + w) / 2);
            Double S2 = Math.Sqrt(P2 * (P2 - b) * (P2 - w) * (P2 - r));

            Double P3 = ((c + q + r) / 2);
            Double S3 = Math.Sqrt(P3 * (P3 - c) * (P3 - q) * (P3 - r));

            Double SS = S1 + S2 + S3;

            if (S > SS)
            {
                Console.WriteLine("Точка M лежит внутри треугольника. ");
            }
            else
            {
                Console.WriteLine("Точка M не лежит внутри треугольника. ");
            }

            Console.ReadKey();

        }
    }
}