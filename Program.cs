namespace AreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public class shape
        {
            //Attributes
            protected double Length;
            protected double Width;

            //Constructor 
            public shape(double length, double width)
            {
                Length = length;
                Width = width;  
            }

            //Method
            public virtual double area()
            { return 0;  }
        }

        
    }
}
