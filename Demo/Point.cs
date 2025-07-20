namespace Demo
{
    internal struct Point
    {
        public int X;
        public int Y;

        // Constructor : Special Methods
        //              1. Named Like Struct
        //              2. Has No Return Type

        // CLR : Will Generate Parameterless Constructor
        // This Constructor Will Initialize the Attributes With The Default Value


        // Constructor
        //public Point()
        //{

        //}

        // .NET 5.0 C# 9.0  
        // .NET 6.0 C# 10.0
        // .NET 7.0 C# 11.0 // Auto default field


        //public Point()
        //{
        //    X = 8;
        //    Y = 8;
        //}

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void PrintPoint()
        {
            Console.WriteLine($"({X}, {Y})");
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

    }
}
