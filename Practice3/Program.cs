using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Point
    {
        public double x;
        public double y;
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point(double x,double y)
        {
            X = x;
            Y = y;
        }
    }
    class Program
    {
        static Point Enter()
        {
            Console.WriteLine("Enter x coordinate.");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y coordinate.");
            double y = Convert.ToDouble(Console.ReadLine());
            Point it = new Point(x, y);
            return it;
        }
        static void Main(string[] args)
        {
            string repeat;
            do
            {
                double u = 0;
                Point p = Enter();
                if ((p.X * p.X + p.Y * p.Y >= 1) && (p.X * p.X + p.Y * p.Y <= 4))
                {
                    u = 0;
                }
                else
                {
                    u = p.X;
                }
                Console.WriteLine("Variable u equals {0}", u);
                Console.WriteLine("Repeat? Enter (yes) or (no).");
                repeat = Console.ReadLine();
            } while (repeat != "no");
            Console.ReadKey();
        }
    }
}
