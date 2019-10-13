using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace bisq
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Title = "Латыпова Камиля ИУ5-33Б";
            //Ввод коэффициентов с проверкой на ноль
            double a = 0, b = 0, c = 0, D = 0;
            Console.Write("Enter a:");
            a = Convert.ToInt32(Console.ReadLine());
            while (a == 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Incorrect! Enter a:");
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.ResetColor();
            Console.Write("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());
           
            Console.ResetColor();
            Console.Write("Enter c:");
            c = Convert.ToInt32(Console.ReadLine());

            //Находим корни относительно замены и дискриминант
            double y1, y2;
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There are no decisions! D={0},", D);
                Console.ReadKey();
                return 0;
            }
            else if (D == 0)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("D={0}", D);
                y1 = (-1.0 * b) / (2.0 * a);
                y2 = (-1.0 * b) / (2.0 * a);
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("D={0}", D);
                y1 = (-1.0 * b + Math.Sqrt(D)) / (2.0 * a);
                y2 = (-1.0 * b - Math.Sqrt(D)) / (2.0 * a);
                Console.ReadKey();
            }

            //Находим корни уравнения
            if (y1 >= 0)
            {
                double x1 = Math.Sqrt(y1);
                double x2 = -1 * x1;
                Console.WriteLine("X1={0} X2={1} ", x1, x2);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("x1<0, There no desicions!");
            }
            if (y2 >= 0)
            {
                double x3 = Math.Sqrt(y2);
                double x4 = -1 * x3;

                Console.WriteLine("X3={0} X4={1} ", x3, x4);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("x2<0, There no desicions!");
            }
            
            Console.ResetColor();
            Console.ReadKey();
            return 0;
        }
    }

}

