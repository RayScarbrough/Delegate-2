using System;

namespace Assignment8ex2
{
    public class MathSolutions
    {
        public double GetSum(double x, double y)
        {
            return x + y;
        }

        public double GetProduct(double a, double b)
        {
            return a * b;
        }

        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }

        static void Main(string[] args)
        {
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);

           
            Func<double, double, double> sumDelegate = answer.GetSum;
            Console.WriteLine($" {num1} + {num2} = {sumDelegate(num1, num2)}");

         
            Action<double, double> smallerDelegate = answer.GetSmaller;
            smallerDelegate(num1, num2);

    
            ProductDelegate productDelegate = answer.GetProduct;
            Console.WriteLine($" {num1} * {num2} = {productDelegate(num1, num2)}");
        }


        delegate double ProductDelegate(double a, double b);
    }
}
