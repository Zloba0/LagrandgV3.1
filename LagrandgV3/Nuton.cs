using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagrandgV3
{
    internal class Nuton
    {
        private int n;
        private double[] x;
        private double[] y;
        private double h;
        public Nuton(double[] x, double[] y, double h)
        {
            this.n = x.Length;
            this.x = new double[n];
            this.y = new double[n];
            this.h = h;
            for (int i = 0; i < n; i++)
            {
                this.x[i] = x[i];
                this.y[i] = y[i];
            }
        } 
        public double DeltaY(int i, int k)
        {
            if (k == 1)
            {
                return y[i+1] - y[i];
            }
            else
            {
                return DeltaY(i+1, k-1) - DeltaY(i, k-1);
            }
        }
        public double Q(double xI, int i)
        {
            return (xI - x[i])/(h*(i+1));
        }
        public double N(double xI)
        {
            double result = y[0];
            for (int i = 1;i < n; i++)
            {
                result += DeltaY(0, i) * QPolinom(xI, i);
            }
            return result;
        }
        public double QPolinom(double xI,int i)
        {
            double result = 1;
            for(int j = 0; j < i; j++)
            {
                result *= Q(xI, j);
            }
            return result;

        }
        public int Factorial(int n1)
        {
            int result = 1;
            if (n1 == 0 || n1 == 1)
            {
                return result;
            }
            for(int i = 2;i <= n1; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
