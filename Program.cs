namespace AreaCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {

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
        public virtual double Area(double length, double width)
        { return 0; }
    }

    public class Square : shape
    {
        //Constructor
        public Square(double length, double width) : base(length, width) { }

        //method 
        public override double Area(double Length, double width) 
        {
            double Area = 0; 
            Area += Math.Pow(Length, 2);

            return Area;
        }
        
    }

    public class Circle : shape
    {
    }

    public class Triangle : shape
    {

    }

    public class Rectangle : shape
    {
    }

}
