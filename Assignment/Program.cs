namespace Assignment
{
    internal class Program
    {
        static double GetDistance(Point p1, Point p2)
        {
            return Math.Sqrt(
                            Math.Pow(p1.X - p2.X, 2) +
                            Math.Pow(p1.Y - p2.Y, 2)
                            );
        }
        static void Main(string[] args)
        {
            // Part01
            #region Q01
            /*
                   1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". 
                   Write a C# program that takes two points as input from the user and calculates the distance between them.
                */

            //Point p1 = new Point();
            //Point p2 = new Point();

            //p1.X = 1;
            //p1.Y = 1;
            //p2.X = 2;
            //p2.Y = 2;

            //Console.WriteLine($"Distance Is : {GetDistance(p1, p2)}"); 
            #endregion


        }
    }
}
