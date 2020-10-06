using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace IDU.Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Route first = new Route();

            first.add_point(2, 4, 0);
            
            first.add_point(4, 8, 1);
            first.add_point(2132, 1234, 2);
            first.add_point(2132, 1, 3);
            first.add_point(123, 1, 4);

            first.get_length();

            first.remove_point(2);
            first.get_length();

            Console.ReadLine();
        }
    }

    public class Point
    {
        public Point(double setX, double setY)
        {
            x = setX;
            y = setY;
        }


        public double x;
        public double y;

        public string printInfo()
        {
            Console.WriteLine("X:" + x + " Y:" + y);
            return null;
        }
        //abscissa
        public double X()
        {
            return x;
        }

        //ordinate
        public double Y()
        {
            return y;
        }

        //distance to origin(0,0)
        public double Rho()
        {
            return Math.Sqrt(Math.Pow(X(), 2) + Math.Pow(Y(), 2));
        }

        //angle to horizontal axis
        public double Theta()
        {
            return Math.Atan2(Y(), X());
        }

        //distance to other
        public double Distance(Point other)
        {
            Console.WriteLine(vectorTo(other).Rho());
            return vectorTo(other).Rho();
        }

        //Returns the Point representing the vector from self to other Point
        public Point vectorTo(Point other)
        {
            return new Point(other.X() - X(), other.Y() - Y());
        }

        //Move by dx horizontally, dy vertically
        public void Translate(double moveX, double moveY)
        {
            x += moveX;
            y += moveY;
            Console.WriteLine(x.ToString() + " " + y.ToString());
        }

        //Scale by factor
        public void Scale(double factor)
        {
            x *= factor;
            y *= factor;
            Console.WriteLine(x.ToString() + " " + y.ToString());
        }

        //Rotate around origin (0, 0) by angle
        public void Centre_Rotate(double angle)
        {
            double tempX = Rho() * Math.Cos(Theta() + angle);
            double tempY = Rho() * Math.Sin(Theta() + angle);
            x = tempX;
            y = tempY;
        }

    }

    public class Route
    {
        public List<Point> points;

        public Route()
        {
            points = new List<Point>();
        }

        public void add_point(double x, double y, int index)
        {
            points.Insert(index,new Point(x, y));
            Console.WriteLine("Added point(" + x + "," + y + ") at an index of " + index);
        }

        public void remove_point(int index)
        {
            points.RemoveAt(index);
            foreach(Point e in points)
            {
                Console.WriteLine(e.printInfo());
            }
        }

        public void get_length()
        {
            List<double> totalDist = new List<double>();
            for (int i = 0; i <= points.Count; i++)
            {
                if(i == points.Count - 1)
                {
                    double sum = totalDist.Sum();
                    Console.WriteLine(sum);
                    return;
                }
               else totalDist.Add(points[i].Distance(points[i + 1]));
            }
        }
    }
}
