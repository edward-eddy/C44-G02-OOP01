namespace Demo
{
    internal struct Phonebook
    {
        string[] names;
        long[] numbers;

        public Phonebook(int size)
        {
            names = new string[size];
            numbers = new long[size];
        }

        public long this[string name]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        return numbers[i];
                    }
                }
                return -1;
            }

            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = value;
                    }
                }
            }
        }

        public string this[long number]
        {
            get
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == number)
                    {
                        return names[i];
                    }
                }
                return "Not Found";
            }

            set
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == number)
                    {
                        names[i] = value;
                    }
                }
            }
        }









        public void AddPerson(string name, long number, int index)
        {
            names[index] = name;
            numbers[index] = number;
        }

        //public long GetNumber(string name)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if (names[i] == name)
        //        {
        //            return numbers[i];
        //        }
        //    }
        //    return -1;
        //}

        //public void UpdateNumber(string name, long newNumber)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if (names[i] == name)
        //        {
        //            numbers[i] = newNumber;
        //        }
        //    }
        //}

        //public string GetName(long number)
        //{
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] == number)
        //        {
        //            return names[i];
        //        }
        //    }
        //    return "Not Found";
        //}

        //public void UpdateName(string newName, long number)
        //{
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] == number)
        //        {
        //            names[i] = newName;
        //        }
        //    }
        //}
    }
}
