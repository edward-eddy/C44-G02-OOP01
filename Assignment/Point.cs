namespace Assignment
{
    internal struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public double GetDistanceFrom(Point p1)
        {
            return Math.Sqrt(
                            Math.Pow(this.X - p1.X, 2) +
                            Math.Pow(this.Y - p1.Y, 2)
                            );
        }

    }
}
