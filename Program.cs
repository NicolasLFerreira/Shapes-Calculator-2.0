using System;

namespace Shapes_Calculator_2._0

{
    public class InputCheck
    {
        private int Int;
        public double Checker()
        {
            string input = Console.ReadLine();

            while (!int.TryParse(input, out Int))
            {
                Console.WriteLine("Enter a valid input: ");
                input = Console.ReadLine();
            }
            return Convert.ToDouble(input);
        }
    }

    public class Square
    {
        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        public double Area { get; private set; }

        public double AreaSquare()
        {
            var check = new InputCheck();

            double input = check.Checker();

            double area = Math.Pow(input, 2);

            return area;
        }
    }

    class Triangle
    {
        public double Cathet1 { get; private set; }
        public double Cathet2 { get; private set; }
        public double Hypotenusa { get; private set; }

        public double SidesTriangle()
        {
            var input = new InputCheck();

            double[] sides = { 1, 2 };

            Cathet1 = input.Checker();

            sides[0] = Cathet1;

            Cathet2 = input.Checker();

            sides[1] = Cathet2;

            return sides[];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("AREA TEST");

            var triangle = new Triangle();

            var input = triangle.PerimeterTriangle();

            Console.WriteLine("Input: {0}",input);

            Console.ReadKey();
        }
    }
}
