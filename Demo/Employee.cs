namespace Demo
{
    internal struct Employee
    {
        private int id;
        private string name;
        private double salary;

        #region Apply Encapsulation User Setter Getter Method
        // Apply Encapsulation User Setter Getter Method

        //// Setter
        //public void SetId(int id)
        //{
        //    this.id = id;
        //}

        //// Getter
        //public int GetId()
        //{
        //    return id;
        //}

        //// Setter Name
        //public void SetName(string name)
        //{
        //    if (name.Length >= 8 && name.Length <= 20)
        //        this.name = name;
        //}

        //// Getter Name
        //public string GetName()
        //{
        //    return name;
        //}

        //public void SetSalary(double salary)
        //{
        //    if (salary > 0)
        //        this.salary = salary;
        //}

        //public double GetSalary()
        //{
        //    return salary;
        //}


        //public Employee(int id, string name, double salary)
        //{
        //    //this.id = id;
        //    SetId(id);
        //    //this.name = name;
        //    SetName(name);
        //    //this.salary = salary;
        //    SetSalary(salary);
        //}

        //public override string ToString()
        //{
        //    return $"ID: {GetId()}, Name: {GetName()}, Salary: {GetSalary}";
        //} 
        #endregion

        // Apply Encapsulation User Properties: [Recommended]
        // 1. Full Property

        //Id
        //public int Id
        //{
        //    set
        //    {
        //        id = value;
        //    }
        //    get
        //    {
        //        return id;
        //    }
        //}


        //Name
        //public string Name
        //{
        //    set
        //    {
        //        if (value.Length >= 8 && value.Length <= 20)
        //            name = value;
        //    }
        //    get
        //    {
        //        return name;
        //    }
        //}


        //Salary
        //public double Salary
        //{
        //    set
        //    {
        //        if (value > 0)
        //            salary = value;
        //    }
        //    get
        //    {
        //        return salary;
        //    }
        //}




        // 2. Automatic  Property
        //public string Address { set; get; }


        // 3. Spicial Property [Indexer]











    }
}
