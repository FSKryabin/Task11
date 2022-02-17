using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Equation lineEquation = new Equation();
            try
            {
                Console.WriteLine("Решаем линейное уравнение 0=kx+b ");
                Console.Write("Укажите коэффициент k: ");
                lineEquation.CoefK = Convert.ToDouble(Console.ReadLine());
                Console.Write("Укажите коэффициент b: ");
                lineEquation.CoefB = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода!");
                return;
            }
            lineEquation.Solution();
            Console.ReadKey();
        }
    }
   
}