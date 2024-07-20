using Microsoft.CodeAnalysis.CSharp.Scripting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseProgram
{
    internal class MyChart
    {
        private string name;
        private double a;
        private double b;
        private ChartType type;
        public string Name { get { return name; } set { name = value; } }
        public double A { get { return a; } set { a = value; } }
        public double B { get { return b; } set { b = value; } }
        public ChartType Type { get { return type; } set { type = value; } }
        public Func<double, double> Func
        {
            get
            {
                switch (type)
                {
                    case ChartType.Direct:
                        return x => a * x + b;
                    case ChartType.Sin:
                        return x => a * Math.Sin(b * x);
                    case ChartType.Сos:
                        return x => a * Math.Cos(b * x);
                    case ChartType.Power:
                        return x => a * Math.Pow(x,b);
                    default: 
                        return x => 0;
                }
            }
        }
        public MyChart(string name, double a, double b, ChartType type)
        {
            this.name = name;
            this.a = a;
            this.b = b;
            this.type = type; 
        }

        public override string ToString()
        {
            return name + ": y => " + type + " a = " + a + " b = " + b;
        }
    }
    enum ChartType
    {
        Direct, Sin, Сos, Power
    }

}
