namespace Demo
{
    internal class Car
    {
        #region Attribute
        private int id;
        private int speed;
        private string model;
        #endregion

        #region Properties
        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion


        // CLR Will Create Parameterless Constructor
        // This Constructor Does Nothing

        // CTOR
        //public Car()
        //{
        //} // Does Nothing


        public Car(int id, int speed, string model) : this(id, speed)
        {
            //Id = id;
            //Speed = speed;
            Model = model;
        }

        public Car(int id, int speed) : this(id)
        {
            //Id = id;
            Speed = speed;
            //Model = model;
        }

        public Car(int id)
        {
            Id = id;
            //Speed = speed;
            //Model = model;
        }

        public override string ToString()
        {
            return $"Id: {Id} :: Speed: {Speed} :: Model: {Model}";
        }



    }
}
