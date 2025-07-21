using System.Globalization;

namespace Assignment
{
    internal class Employee
    {
        public enum SecurityLevel
        {
            Guest,
            Developer,
            Security,
            DBA
        }

        public enum GenderEnum
        {
            Male = 1,
            M = 1,
            Female = 2,
            F = 2
        }

        private int id;
        private string name;
        private decimal salary;
        private HireDate hiringDate = new HireDate();
        private GenderEnum gender;
        private SecurityLevel level;

        // Property
        public int Id
        {
            set
            {
                if (value > 0)
                    id = value;
            }
            get
            {
                return id;
            }
        }
        // Method
        public void SetId(int id)
        {
            if (id > 0)
                this.id = id;
        }
        public int GetId()
        {
            return id;
        }

        // Property
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        // Method
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        // Property
        public decimal Salary
        {
            set
            {
                if (value > 3000)
                    salary = value;
            }
            get
            {
                return salary;
            }
        }
        // Method
        public void SetSalary(decimal salary)
        {
            if (salary > 3000)
                this.salary = salary;
        }
        public decimal GetSalary()
        {
            return salary;
        }

        // Property
        public string Gender
        {
            set
            {
                if (Enum.TryParse(typeof(GenderEnum), value, true, out object Temp))
                    gender = (GenderEnum)Temp;
            }
            get
            {
                return gender.ToString();
            }
        }
        // Method
        public void SetGender(string gender)
        {
            if (Enum.TryParse(typeof(GenderEnum), gender, true, out object Temp))
                this.gender = (GenderEnum)Temp;
        }
        public GenderEnum GetGender()
        {
            return gender;
        }

        // Property
        public string Level
        {
            set
            {
                if (Enum.TryParse(typeof(SecurityLevel), value, true, out object Temp2))
                    level = (SecurityLevel)Temp2;
            }
            get
            {
                return level.ToString();
            }
        }
        // Method
        public void SetSecurityLevel(string level)
        {
            if (Enum.TryParse(typeof(SecurityLevel), level, true, out object Temp2))
                this.level = (SecurityLevel)Temp2;
        }
        public SecurityLevel GetSecurityLevel()
        {
            return level;
        }

        //public Employee(int id, string name, decimal salary, string gender, string level)
        //{
        //    SetId(id);
        //    SetName(name);
        //    SetSalary(salary);
        //    SetGender(gender);
        //    SetSecurityLevel(level);
        //}


        public Employee(int id, string name, decimal salary, string gender, string level)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Gender = gender;
            Level = level;
        }


        public override string ToString()
        {
            string Return = $"Employee Salary Is : {String.Format(new CultureInfo("en-EG"), "{0:C}", Salary)}";
            return Return;
        }
    }
}
