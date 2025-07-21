namespace Assignment
{
    internal class HireDate
    {
        public int Day { set; get; }
        public int Month { set; get; }
        public int Year { set; get; }

        public HireDate()
        {
            this.Day = DateTime.Today.Day;
            this.Month = DateTime.Today.Month;
            this.Year = DateTime.Today.Year;
        }

        public override string ToString()
        {
            return $"{Day} - {Month} - {Year}";
        }
    }
}
