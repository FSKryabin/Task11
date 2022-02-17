using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    struct Equation
    {
        private double _coefK;
        public double CoefK
        {
            get
            {
                return _coefK;
            }
            set
            {
                if (value != 0)
                {
                    _coefK = value;
                }
                else
                {
                    Console.WriteLine("Коэффициент k не может быть равен 0");
                }
            }
        }
        public double CoefB { get; set; }
        public Equation(double CoefK, double CoefB)
        {
            this._coefK = CoefK;
            this.CoefB = CoefB;
        }
        public void Solution()
        {
            Console.WriteLine("Решение уравнения. Х = {0:f2}", (-CoefB) / CoefK);
        }
    }
}
