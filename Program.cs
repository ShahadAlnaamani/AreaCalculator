using System.Numerics;
using System.Reflection;

namespace AreaCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- - -A R E A   C A L C U L A T O R- - -");
            shape cir = new Circle(4,5);
            shape rec = new Rectangle(4, 5);
            shape tri = new Triangle(4, 5);
            shape squ = new Square(4, 5);

            double CircleArea = cir.Area();
            Console.WriteLine($"Circle area: {CircleArea}\n");
            
            double RectangleArea = rec.Area();
            Console.WriteLine($"Rectangle area: {RectangleArea}\n");
            
            double TriangleArea = tri.Area();
            Console.WriteLine($"Triangle area: {TriangleArea} \n");

            double SquareArea = squ.Area();
            Console.WriteLine($"Square area: {SquareArea} \n");
        }
    }

    public abstract class shape
    {
        //Attributes
        protected double Length { get; private set; }
        protected double Width { get; private set; }

        //Constructor 
        public shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        //Method
        public virtual double Area()
        { return 0; }
    }

    public class Square : shape
    {
        //Constructor
        public Square(double length, double width) : base(length, width) { }

        //method 
        public override double Area() 
        {
            double Area = 0; 
            Area = Math.Pow(Length, 2);

            Console.WriteLine("Calculating area of a square...");

            return Area;
        }
        
    }

    public class Circle : shape
    {
        //Constructor
        public Circle(double length, double width) : base(length, width) { }

        //method 
        public override double Area()
        {
            //Consider width is r*2 (full line through circle)
            double Area = 0;
            double Radius = 0;
            Radius = Width/2;
            Area = Math.PI*(Math.Pow(Radius,2));

            Console.WriteLine("Calculating area of a circle...");

            return Area;
        }
    }

    public class Triangle : shape
    {
        //Constructor
        public Triangle(double length, double width) : base(length, width) { }

        //method 
        public override double Area()
        {
            //Consider Length is hight and width is base
            double Area = 0;
            Area = (1/2 * (Length * Width));

            Console.WriteLine("Calculating area of a triangle...");

            return Area;
        }
    }

    public class Rectangle : shape
    {
        //Constructor
        public Rectangle(double length, double width) : base(length, width) { }

        //method 
        public override double Area()
        {
            double Area = 0;
            Area = Length*Width;

            Console.WriteLine("Calculating area of a rectangle...");

            return Area;
        }
    }

}
