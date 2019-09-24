using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Complex
    {
        public double Real { get; set; }
        public double Imag { get; set; }

        public void Add(Complex x)
        {
            Real += x.Real;
            Imag += x.Imag;
        }
        public void Substract(Complex x)
        {
            Real -= x.Real;
            Imag -= x.Imag;
        }
        public void Multiply(Complex x)
        {
            double _real = (Real * x.Real) + -(x.Imag * Imag);
            double _imag = (Real * x.Imag) + (Imag * x.Real);
            Imag = _imag;
            Real = _real;
        }
        public void Divide(Complex x)
        {
            Complex nr = new Complex { Real = x.Real, Imag = -x.Imag };
            Multiply(nr);
            x.Multiply(nr);
            Real /= x.Real;
            Imag /= x.Real;
        }
    }
}
