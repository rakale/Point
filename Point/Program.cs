using System;
using System.Security.Cryptography.X509Certificates;

namespace IDU.Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(5, 10);
            Console.WriteLine(A.Y());
            Point B = new Point(10, 25.4);
            Console.WriteLine(A.X());
            Console.WriteLine(A.Theta());
            Console.WriteLine(A.Distance(B));

            A.Centre_Rotate(0.5);
            Console.WriteLine(A.X());
            Console.WriteLine(A.Y());

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
}
