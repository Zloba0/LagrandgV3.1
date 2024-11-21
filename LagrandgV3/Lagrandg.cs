using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagrandgV3
{
    internal class Lagrandg
    {
        private int n;
        private double[] x;
        private double[] y;
        public Lagrandg(double[] x, double[] y)
        {
            this.n = x.Length;
            this.x = new double[n];
            this.y = new double[n];
            for (int i = 0; i < n; i++)
            {
                this.x[i] = x[i];
                this.y[i] = y[i];
            }
        }
        public double P(int i, double x0)
        {
            double result = 1;
            for (int j = 0; j < n; j++)
            {
                if (i== j)
                {
                    continue;
                }
                result *= (x0 -x[j]) / (x[i] - x[j]);
            }
            return result;
        }
        public double L(double x0)
        {
            double result = 0;
            for (int i = 0; i < n; i++)
            {
                result += y[i] * P(i, x0);
            }
            return result;
        }
    }
}
