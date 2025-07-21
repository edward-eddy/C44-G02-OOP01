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
            #region Part01
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
            #endregion

            #region Part02
            #region Q01
            /*
                Design and implement a Class for the employees in a company:
                Notes:
                ● Employee is identified by an ID, Name, security level, salary, hire date and Gender.
                ● We need to restrict the Gender field to be only M or F[Male or Female]
                ● Assign the following security privileges to the employee(guest, Developer, secretary and DBA) in a form of Enum.
                ● We want to provide the Employee Class to represent Employee data in a string Form(override ToString()), 
                    display employee salary in a currency format. [Use String.Format() Function].
            */

            //Employee Emp = new Employee();
            //Emp.Id = 1;
            //Emp.Name = "Ahmed";
            //Emp.Salary = 12000;
            //Emp.Gender = Employee.GenderEnum.Male;
            //Emp.HiringDate = new HireDate();
            //Emp.Level = Employee.SecurityLevel.Guest;

            //Console.WriteLine(Emp);
            #endregion

            #region Q01.Part02
            /*Develop a Class to represent the Hiring Date Data:
                ● Consisting of fields to hold the day, month and Years.*/

            //Employee Emp = new Employee(1, "Edward", 12000, "male", "guest");

            //Console.WriteLine(Emp.HiringDate);
            #endregion

            #region Q01.Part03
            /*
             * Create an array of Employees with size three a DBA, Guest and the third one is security officer who have 
             * full permissions. (Employee [] EmpArr;)
                Notes:
                    ● Implement All the Necessary Member Functions on the Class (Getters, Setters)
                    ● Define all the Necessary Constructors for the Class
                    ● Allow NO RUNTIME errors if the user inputs any data
                    ● Write down all the necessary Properties (Instead of setters and getters)
            */


            Employee[] EmpArr = new Employee[3];


            // Allow NO RUNTIME errors
            for (int i = 0; i < 3; i++)
            {
                int id;
                decimal salary;
                string name, gender, level;

                do
                {
                    Console.Write($"Enter Employee {i + 1} Id : ");
                } while (!int.TryParse(Console.ReadLine(), out id) || id < 0);

                do
                {
                    Console.Write($"Enter Employee {i + 1} Name : ");
                    name = Console.ReadLine();
                } while (name.Length < 3);

                do
                {
                    Console.Write($"Enter Employee {i + 1} Salary : ");
                } while (!decimal.TryParse(Console.ReadLine(), out salary) || salary < 3000);

                do
                {
                    Console.Write($"Enter Employee {i + 1} Gender : ");
                    gender = Console.ReadLine().ToLower();
                } while (!(gender.Equals("male") || gender.Equals("female")));

                do
                {
                    Console.Write($"Enter Employee {i + 1} Security Level : ");
                    level = Console.ReadLine().ToLower();
                } while (!(level.Equals("guest") || level.Equals("developer") || level.Equals("security") || level.Equals("dba")));

                EmpArr[i].Id = id;
                EmpArr[i].Name = name;
                EmpArr[i].Salary = salary;
                EmpArr[i].SetGender(gender);
                EmpArr[i].SetSecurityLevel(level);

            }

            /*          OR          */

            //Employee Emp1 = new Employee(1, "Ahmed", 10000, "m", "DBA");
            //Employee Emp2 = new Employee(2, "Aliaa", 20000, "f", "Guest");
            //Employee Emp3 = new Employee(3, "Emad", 8000, "m", "Security");

            //Employee[] EmpArr = { Emp1, Emp2, Emp3 };

            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine($"{EmpArr[i].GetId()}, {EmpArr[i].GetName()}, {EmpArr[i].GetSalary()}, {EmpArr[i].GetGender()}, {EmpArr[i].GetSecurityLevel()}");
            }
            #endregion
            #endregion
        }
    }
}
