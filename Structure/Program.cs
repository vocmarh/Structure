using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equation equation = new Equation();
            equation.Root();            
            Console.ReadKey();
        }
    }
    struct Equation
    {
        public double k;
        public double b;
        public double x;

                

        public void Root()
        {
            Console.WriteLine("Решите следующее уравнение: 0 = kx + b. Найдите значение x");
            Console.Write("Введите значение b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение k: ");
            k = Convert.ToDouble(Console.ReadLine());
            if (k == 0)
            {
                Console.WriteLine("При данном значении решение уровнения невозможно. Делить на ноль нельзя!");
            }
            x = (0 - b) / k;
            Console.WriteLine(x);
                        
        }

    }
}
