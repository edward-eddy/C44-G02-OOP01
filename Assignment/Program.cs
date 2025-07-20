namespace Assignment
{
    internal class Program
    {
        static void GetOldest(params Person[] p1)
        {
            string Name = "";
            int Age = 0;
            foreach (Person p in p1)
            {
                if (p.Age > Age)
                {
                    Name = p.Name;
                    Age = p.Age;
                }
            }
            Console.WriteLine($"The Oldest Person Is {Name} With Age Of {Age}");
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

            //Console.WriteLine($"Distance Is : {p1.GetDistanceFrom(p2)}");
            #endregion

            #region Q02
            /*
               2.Create a struct called 'Person" with properties "Name" and "Age". 
               Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            */

            //Person p1 = new Person("Ahmed", 28);
            //Person p2 = new Person("Ali", 20);
            //Person p3 = new Person("Esraa", 30);

            //GetOldest(p1, p2, p3);
            #endregion
        }
    }
}
