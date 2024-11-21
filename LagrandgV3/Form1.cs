using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LagrandgV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (f1.Checked && !f2.Checked && !f3.Checked && !f4.Checked)
            {
                try
                {
                    int n = Convert.ToInt32(textBox2.Text);
                    double a = -1;
                    double b = 1;
                    double h = (b -a)/n;
                    double[] y = new double[n];
                    double[] x = new double[n];
                    double x0 = a;

                    for (int i = 0; i < n; i++, x0 += h)
                    {
                        x[i] = x0;
                        y[i] = function1(x0);
                    }

                    Lagrandg var = new Lagrandg(x, y);

                    GraphPane pane = zedGraph.GraphPane;

                    pane.CurveList.Clear();

                    PointPairList list = new PointPairList();
                    PointPairList list2 = new PointPairList();
                    h = 0.00001;
                    for (x0 = a; x0 <= b; x0 += h)
                    {
                        list2.Add(x0, function1(x0));
                        list.Add(x0, var.L(x0));
                    }
                    LineItem myCurve = pane.AddCurve(" ", list, Color.Blue, SymbolType.None);
                    LineItem myCurve2 = pane.AddCurve(" ", list2, Color.Red, SymbolType.None);

                    zedGraph.AxisChange();

                    zedGraph.Invalidate();
                }
                catch
                {
                    MessageBox.Show("Wrong input of parameter n!", "Worning!");
                }
            }
            else if (f2.Checked && !f1.Checked && !f3.Checked && !f4.Checked)
            {
                try
                {
                    int n = Convert.ToInt32(textBox2.Text);
                    double a = -1;
                    double b = 1;
                    double h = (b -a)/n;
                    double[] y = new double[n];
                    double[] x = new double[n];
                    double x0 = a;
                    for (int i = 0; i < n; i++, x0 += h)
                    {
                        x[i] = x0;
                        y[i] = function2(x0);
                    }

                    Lagrandg var = new Lagrandg(x, y);

                    GraphPane pane = zedGraph.GraphPane;

                    pane.CurveList.Clear();

                    PointPairList list = new PointPairList();
                    PointPairList list2 = new PointPairList();
                    h = 0.00001;
                    for (x0 = a; x0 <= b; x0 += h)
                    {
                        list2.Add(x0, function2(x0));
                        list.Add(x0, var.L(x0));
                    }
                    LineItem myCurve = pane.AddCurve(" ", list, Color.Blue, SymbolType.None);
                    LineItem myCurve2 = pane.AddCurve(" ", list2, Color.Red, SymbolType.None);

                    zedGraph.AxisChange();

                    zedGraph.Invalidate();
                }
                catch
                {
                    MessageBox.Show("Wrong input of parameter n!", "Worning!");
                }
            }
            else if (!f2.Checked && !f1.Checked && f3.Checked && !f4.Checked)
            {
                try
                {
                    int n = Convert.ToInt32(textBox2.Text);
                    double a = -1;
                    double b = 1;
                    double h = (b -a)/n;
                    double[] y = new double[n];
                    double[] x = new double[n];
                    double x0 = a;
                    for (int i = 0; i < n; i++, x0 += h)
                    {
                        x[i] = x0;
                        y[i] = function3(x0);
                    }

                    Lagrandg var = new Lagrandg(x, y);

                    GraphPane pane = zedGraph.GraphPane;

                    pane.CurveList.Clear();
                    PointPairList list2 = new PointPairList();

                    PointPairList list = new PointPairList();
                    h = 0.00001;
                    for (x0 = a; x0 <= b; x0 += h)
                    {
                        list2.Add(x0, function3(x0));
                        list.Add(x0, var.L(x0));
                    }
                    LineItem myCurve = pane.AddCurve(" ", list, Color.Blue, SymbolType.None);
                    LineItem myCurve2 = pane.AddCurve(" ", list2, Color.Red, SymbolType.None);

                    zedGraph.AxisChange();

                    zedGraph.Invalidate();
                }
                catch
                {
                    MessageBox.Show("Wrong input of parameter n!", "Worning!");
                }
            }
            else if (!f2.Checked && !f1.Checked && !f3.Checked && f4.Checked)
            {
                try
                {
                    double k = Convert.ToDouble(textBox4.Text);
                }
                catch
                {
                    MessageBox.Show("Wrong input of parameter k!", "Worning!");
                    return;
                }
                try
                {
                    int n = Convert.ToInt32(textBox2.Text);
                    double k = Convert.ToDouble(textBox4.Text);
                    double a = -1;
                    double b = 1;
                    double h = (b -a)/n;
                    double[] y = new double[n];
                    double[] x = new double[n];
                    double x0 = a;
                    for (int i = 0; i < n; i++, x0 += h)
                    {
                        x[i] = x0;
                        y[i] = function4(x0, k);
                    }

                    Lagrandg var = new Lagrandg(x, y);

                    GraphPane pane = zedGraph.GraphPane;

                    pane.CurveList.Clear();
                    PointPairList list2 = new PointPairList();
                    PointPairList list = new PointPairList();
                    h = 0.00001;
                    for (x0 = a; x0 <= b; x0 += h)
                    {
                        list2.Add(x0, function4(x0, k));
                        list.Add(x0, var.L(x0));
                    }
                    LineItem myCurve = pane.AddCurve(" ", list, Color.Blue, SymbolType.None);
                    LineItem myCurve2 = pane.AddCurve(" ", list2, Color.Red, SymbolType.None);
                    zedGraph.AxisChange();

                    zedGraph.Invalidate();
                }
                catch
                {
                    MessageBox.Show("Wrong input of parameter n!", "Worning!");
                }
            }
            else
            {
                MessageBox.Show("Select one function!", "Worning!");
            }
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (f1.Checked && !f2.Checked && !f3.Checked && !f4.Checked)
            {
                try
                {
                    GraphPane pane = zedGraph.GraphPane;

                    pane.CurveList.Clear();

                    PointPairList list = new PointPairList();
                    PointPairList list2 = new PointPairList();

                    int n = Convert.ToInt32(textBox2.Text);

                    double a = -1;
                    double b = 1;
                    double h = (b -a)/n;
                    double[] y = new double[n];
                    double[] x = new double[n];
                    double x0 = a;
                    for (int i = 1; i < n; i++)
                    {
                        h = (b + a) / 2 + (b - a) * Math.Cos((2 * i + 1) * Math.PI / (2 * n + 2)) / 2;
                        x[i] = h;
                        y[i] = function1(h);
                    }

                    Lagrandg var = new Lagrandg(x, y);
                    h = 0.00001;
                    for (x0 = a; x0 <= b; x0 += h)
                    {
                        list2.Add(x0, function1(x0));
                        list.Add(x0, var.L(x0));
                    }
                    LineItem myCurve = pane.AddCurve(" ", list, Color.Blue, SymbolType.None);
                    LineItem myCurve2 = pane.AddCurve(" ", list2, Color.Red, SymbolType.None);
                    zedGraph.AxisChange();

                    zedGraph.Invalidate();
                }
                catch
                {
                    MessageBox.Show("Wrong input of parameter n!", "Worning!");
                }
            }
            else if (f2.Checked && !f1.Checked && !f3.Checked && !f4.Checked)
            {
                try
                {
                    GraphPane pane = zedGraph.GraphPane;

                    pane.CurveList.Clear();

                    PointPairList list = new PointPairList();
                    PointPairList list2 = new PointPairList();
                    int n = Convert.ToInt32(textBox2.Text);
                    double a = -1;
                    double b = 1;
                    double h = (b -a)/n;
                    double[] y = new double[n];
                    double[] x = new double[n];
                    double x0 = a;
                    for (int i = 1; i < n; i++)
                    {
                        h = (b + a) / 2 + (b - a) * Math.Cos((2 * i + 1) * Math.PI / (2 * n + 2)) / 2;
                        x[i] = h;
                        y[i] = function2(h);
                    }

                    Lagrandg var = new Lagrandg(x, y);
                    h = 0.00001;
                    for (x0 = a; x0 <= b; x0 += h)
                    {
                        list2.Add(x0, function2(x0));
                        list.Add(x0, var.L(x0));
                    }
                    LineItem myCurve = pane.AddCurve(" ", list, Color.Blue, SymbolType.None);
                    LineItem myCurve2 = pane.AddCurve(" ", list2, Color.Red, SymbolType.None);
                    zedGraph.AxisChange();

                    zedGraph.Invalidate();
                }
                catch
                {
                    MessageBox.Show("Wrong input of parameter n!", "Worning!");
                }
            }
            else if (!f2.Checked && !f1.Checked && f3.Checked && !f4.Checked)
            {
                try
                {
                    GraphPane pane = zedGraph.GraphPane;

                    pane.CurveList.Clear();

                    PointPairList list = new PointPairList();
                    PointPairList list2 = new PointPairList();
                    int n = Convert.ToInt32(textBox2.Text);
                    double a = -1;
                    double b = 1;
                    double h = (b -a)/n;
                    double[] y = new double[n];
                    double[] x = new double[n];
                    double x0 = a;
                    for (int i = 1; i < n; i++)
                    {
                        h = (b + a) / 2 + (b - a) * Math.Cos((2 * i + 1) * Math.PI / (2 * n + 2)) / 2;
                        x[i] = h;
                        y[i] = function3(h);
                    }
                    h = 0.00001;
                    Lagrandg var = new Lagrandg(x, y);

                    for (x0 = a; x0 <= b; x0 += h)
                    {
                        list2.Add(x0, function3(x0));
                        list.Add(x0, var.L(x0));
                    }
                    LineItem myCurve = pane.AddCurve(" ", list, Color.Blue, SymbolType.None);
                    LineItem myCurve2 = pane.AddCurve(" ", list2, Color.Red, SymbolType.None);
                    zedGraph.AxisChange();

                    zedGraph.Invalidate();
                }
                catch
                {
                    MessageBox.Show("Wrong input of parameter n!", "Worning!");
                }
            }
            else if (!f2.Checked && !f1.Checked && !f3.Checked && f4.Checked)
            {
                try
                {
                    double k = Convert.ToDouble(textBox4.Text);
                }
                catch
                {
                    MessageBox.Show("Wrong input of parameter k!", "Worning!");
                    return;
                }
                try
                {
                    GraphPane pane = zedGraph.GraphPane;

                    pane.CurveList.Clear();

                    PointPairList list = new PointPairList();
                    PointPairList list2 = new PointPairList();
                    int n = Convert.ToInt32(textBox2.Text);
                    double k = Convert.ToDouble(textBox4.Text);
                    double a = -1;
                    double b = 1;
                    double h = (b -a)/n;
                    double[] y = new double[n];
                    double[] x = new double[n];
                    double x0 = a;
                    for (int i = 1; i < n; i++)
                    {
                        h = (b + a) / 2 + (b - a) * Math.Cos((2 * i + 1) * Math.PI / (2 * n + 2)) / 2;
                        x[i] = h;
                        y[i] = function4(h, k);
                    }

                    Lagrandg var = new Lagrandg(x, y);
                    h = 0.00001;
                    for (x0 = a; x0 <= b; x0 += h)
                    {
                        list2.Add(x0, function4(x0, k));
                        list.Add(x0, var.L(x0));
                    }
                    LineItem myCurve = pane.AddCurve(" ", list, Color.Blue, SymbolType.None);
                    LineItem myCurve2 = pane.AddCurve(" ", list2, Color.Red, SymbolType.None);
                    zedGraph.AxisChange();

                    zedGraph.Invalidate();
                }
                catch
                {
                    MessageBox.Show("Wrong input of parameter n!", "Worning!");
                }
            }
            else
            {
                MessageBox.Show("Select one function!", "Worning!");
            }
        }
        public double function1(double x)
        {
            return 1/(1+25*x*x);
        }
        public double function2(double x)
        {
            return x*x;
        }
        public double function3(double x)
        {
            return Math.Abs(x);
        }
        public double function4(double x, double k)
        {
            return Math.Pow(Math.E, (-k * x * x));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zedGraph.GraphPane.Title.Text = "Interpolation";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (f1.Checked && !f2.Checked && !f3.Checked && !f4.Checked)
            {
                try
                {
                    int n = Convert.ToInt32(textBox2.Text);
                    double a = -1;
                    double b = 1;
                    double h = (b -a)/n;
                    double[] y = new double[n];
                    double[] x = new double[n];
                    double x0 = a;

                    for (int i = 0; i < n; i++, x0 += h)
                    {
                        x[i] = x0;
                        y[i] = function1(x0);
                    }

                    Splines var = new Splines(x, y);

                    GraphPane pane = zedGraph.GraphPane;

                    pane.CurveList.Clear();

                    PointPairList list = new PointPairList();
                    PointPairList list2 = new PointPairList();
                    h = 0.00001;
                    int j = 1;
                    for (x0 = a; x0 <= b; x0 += h)
                    {
                        list2.Add(x0, function1(x0));
                        if (x0 > x[j] && j < n - 1)
                        {
                            j++;
                        }
                        list.Add(x0, var.S(j, x0));
                    }
                    LineItem myCurve = pane.AddCurve(" ", list, Color.Blue, SymbolType.None);
                    LineItem myCurve2 = pane.AddCurve(" ", list2, Color.Red, SymbolType.None);

                    zedGraph.AxisChange();

                    zedGraph.Invalidate();
                }
                catch
                {
                    MessageBox.Show("Wrong input of parameter n!", "Worning!");
                }
            }
            else if (f2.Checked && !f1.Checked && !f3.Checked && !f4.Checked)
            {
                try
                {
                    int n = Convert.ToInt32(textBox2.Text);
                    double a = -1;
                    double b = 1;
                    double h = (b -a)/n;
                    double[] y = new double[n];
                    double[] x = new double[n];
                    double x0 = a;

                    for (int i = 0; i < n; i++, x0 += h)
                    {
                        x[i] = x0;
                        y[i] = function2(x0);
                    }

                    Splines var = new Splines(x, y);

                    GraphPane pane = zedGraph.GraphPane;

                    pane.CurveList.Clear();

                    PointPairList list = new PointPairList();
                    PointPairList list2 = new PointPairList();
                    h = 0.00001;
                    int j = 1;
                    for (x0 = a; x0 <= b; x0 += h)
                    {
                        list2.Add(x0, function2(x0));
                        if (x0 > x[j] && j < n - 1)
                        {
                            j++;
                        }
                        list.Add(x0, var.S(j, x0));
                    }
                    LineItem myCurve = pane.AddCurve(" ", list, Color.Blue, SymbolType.None);
                    LineItem myCurve2 = pane.AddCurve(" ", list2, Color.Red, SymbolType.None);

                    zedGraph.AxisChange();

                    zedGraph.Invalidate();
                }
                catch
                {
                    MessageBox.Show("Wrong input of parameter n!", "Worning!");
                }
            }
            else if (!f2.Checked && !f1.Checked && f3.Checked && !f4.Checked)
            {
                try
                {
                    int n = Convert.ToInt32(textBox2.Text);
                    double a = -1;
                    double b = 1;
                    double h = (b -a)/n;
                    double[] y = new double[n];
                    double[] x = new double[n];
                    double x0 = a;

                    for (int i = 0; i < n; i++, x0 += h)
                    {
                        x[i] = x0;
                        y[i] = function3(x0);
                    }

                    Splines var = new Splines(x, y);

                    GraphPane pane = zedGraph.GraphPane;

                    pane.CurveList.Clear();

                    PointPairList list = new PointPairList();
                    PointPairList list2 = new PointPairList();
                    h = 0.00001;
                    int j = 1;
                    for (x0 = a; x0 <= b; x0 += h)
                    {
                        list2.Add(x0, function3(x0));
                        if (x0 > x[j] && j < n - 1)
                        {
                            j++;
                        }
                        list.Add(x0, var.S(j, x0));
                    }
                    LineItem myCurve = pane.AddCurve(" ", list, Color.Blue, SymbolType.None);
                    LineItem myCurve2 = pane.AddCurve(" ", list2, Color.Red, SymbolType.None);

                    zedGraph.AxisChange();

                    zedGraph.Invalidate();
                }
                catch
                {
                    MessageBox.Show("Wrong input of parameter n!", "Worning!");
                }
            }
            else if (!f2.Checked && !f1.Checked && !f3.Checked && f4.Checked)
            {
                try
                {
                    double k = Convert.ToDouble(textBox4.Text);
                }
                catch
                {
                    MessageBox.Show("Wrong input of parameter k!", "Worning!");
                    return;
                }
                try
                {
                    int n = Convert.ToInt32(textBox2.Text);
                    double a = -1;
                    double b = 1;
                    double h = (b -a)/n;
                    double[] y = new double[n];
                    double[] x = new double[n];
                    double x0 = a;
                    double k = Convert.ToDouble(textBox4.Text);
                    for (int i = 0; i < n; i++, x0 += h)
                    {
                        x[i] = x0;
                        y[i] = function4(x0, k);
                    }

                    Splines var = new Splines(x, y);

                    GraphPane pane = zedGraph.GraphPane;

                    pane.CurveList.Clear();

                    PointPairList list = new PointPairList();
                    PointPairList list2 = new PointPairList();
                    h = 0.00001;
                    int j = 1;
                    for (x0 = a; x0 <= b; x0 += h)
                    {
                        list2.Add(x0, function4(x0, k));
                        if (x0 > x[j] && j < n - 1)
                        {
                            j++;
                        }
                        list.Add(x0, var.S(j, x0));
                    }
                    LineItem myCurve = pane.AddCurve(" ", list, Color.Blue, SymbolType.None);
                    LineItem myCurve2 = pane.AddCurve(" ", list2, Color.Red, SymbolType.None);

                    zedGraph.AxisChange();

                    zedGraph.Invalidate();
                }
                catch
                {
                    MessageBox.Show("Wrong input of parameter n!", "Worning!");
                }
            }
            else
            {
                MessageBox.Show("Select one function!", "Worning!");
            }
        }
    }
}