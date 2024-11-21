using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LagrandgV3
{
    internal class Splines
    {
        private double[,] matr;
        private int n;
        private double[] x;
        private double[] y;
        private double[] c;
        private double[] d;
        private double[] b;
        public Splines(double[] x, double[] y)
        {
            this.n = x.Length;
            this.matr = new double[x.Length, x.Length+1];
            this.x = new double[x.Length];
            this.y = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                this.x[i] = x[i];
                this.y[i] = y[i];
            }
            for (int i = 0; i < n; i++)
            {

                if (i == 0)
                {
                    matr[i, 0] = 1;
                    for (int j = 1; j < n+1; j++)
                    {
                        matr[i, j] = 0;
                    }
                }
                else if (i == n-1)
                {
                    matr[i, n-1] = 1;
                    matr[i, n] = 0;
                    for (int j = 0; j < n-1; j++)
                    {
                        matr[i, j] = 0;
                    }
                }
                else
                {
                    matr[i, n] = 6*((y[i+1] - y[i])/ Hi(i+1) - (y[i] - y[i-1]) / Hi(i));
                    matr[i, i-1] = Hi(i+1);
                    matr[i, i] = 2*(Hi(i+1) + Hi(i));
                    matr[i, i+1] = Hi(i);
                }
            }
            this.c = RunMethod(matr, n);
            this.d = new double[x.Length];
            this.b = new double[x.Length];

            //double[] h = new double[x.Length];
            //for (int i = x.Length-1; i >= 0; --i)
            //{
            //    if (i == 0 || i == x.Length-1)
            //    {
            //        h[i] = 1;
            //    }
            //    else
            //    {
            //        h[i] = 2 * (Hi(i+1) + Hi(i)) - Hi(i+1)*Hi(i+1)/(h[i+1]);
            //    }
            //}

            for (int i = 0; i < x.Length; i++)
            {
                if (i == 0)
                {
                    //this.c[i] = 0;
                    this.d[i] = 0;
                    this.b[i] = 0;
                }
                else if (i == x.Length-1)
                {
                    //this.c[i] = 0;
                    this.d[i] = (-this.c[i-1]) / Hi(i);
                    this.b[i] = (y[i] - y[i-1]) / Hi(i);
                }
                else
                {
                    //this.c[i] = (6*((y[i+1] - y[i])/ Hi(i+1) - (y[i] - y[i-1])/ Hi(i)) - Hi(i)* c[i-1]) / h[i]; 
                    this.d[i] = (this.c[i] - this.c[i-1]) / Hi(i);
                    this.b[i] = Hi(i) * this.c[i] / 2 - Hi(i)*Hi(i) * this.d[i] / 6 + (y[i] - y[i-1]) / Hi(i);
                }
            }
        }
        public double[] RunMethod(double[,] matr, int n)
        {
            double an1 = -matr[n-1, n-2] / matr[n-1, n-1];
            double bn1 = matr[n-1, n] / matr[n-1, n-1];
            double[] a = new double[n-1];
            double[] b = new double[n-1];
            a[n-2] = an1;
            b[n-2] = bn1;
            double[] xi = new double[n];
            for (int i = n-3; i >= 0; i--)
            {
                a[i] = -matr[i+1, i] / (a[i+1]*matr[i+1, i+2] + matr[i+1, i+1]);
                b[i] = (matr[i+1, n] - b[i+1]*matr[i+1, i+2]) / (a[i+1]*matr[i+1, i+2] + matr[i+1, i+1]);
            }
            xi[1] = (-b[0]- matr[0, n] * a[0] / matr[0, 0]) / (-1 - matr[0, 1] * a[0] / matr[0, 0]);
            xi[0] = (matr[0, n] - matr[0, 1] * xi[1]) / matr[0, 0];
            for (int i = 2; i < n; i++)
            {
                xi[i] = a[i-1] * xi[i-1] + b[i-1];
            }
            return xi;
        }
        private double Hi(int i)
        {
            return x[i] - x[i-1];
        }
        public double S(int i, double x0)
        {
            return y[i] + b[i]*(x0 - x[i]) + c[i]*(x0 - x[i])*(x0 - x[i])/2 + d[i]*(x0 - x[i])*(x0 - x[i])*(x0 - x[i])/6;
        }
    }
}
