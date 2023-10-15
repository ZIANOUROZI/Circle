namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var MyCircle = new Circle(5); //This line creates an instance of the Circle Class 
            Console.WriteLine(MyCircle.GetArea()); // This line calls the GetArea method and MyCircle objekt
            Console.WriteLine(Math.Round(MyCircle.GetArea(), 2)); // This line calls again GetArea and MyCircle but i us Math.Round to round the area to 2 decimal

            Circle MyCircel2 = new Circle(6); //This line creates an instance of the Circle Class 
            Console.WriteLine(MyCircel2.GetArea());  // This line calls the GetArea method and MyCircle objekt
            Console.WriteLine(Math.Round(MyCircel2.GetArea(), 2)); // This line calls again GetArea and MyCircle but i us Math.Round to round the area to 2 decimal
        }
    }
}