namespace Demo
{
    internal class Program
    {
        // 1. Class
        // 2. Struct
        // 3. Interface
        // 4. Enum
        static void Main(string[] args)
        {
            #region Struct
            // Struct : Value Type : STACK

            // Employee
            // Id, Name, Salary



            // Point
            //Point P01;
            // Declare For Object From Type 'Point'
            // P01: Object
            // Allocate Uninitialized8 Bytes At STACK

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //P01.X = 12;
            //P01.Y = 12;
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //P01 = new Point(1, 2);
            // New : Used For Select Constructor

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //P01.PrintPoint();

            //Console.WriteLine(P01.ToString()); 
            #endregion

            #region OOP Overview
            // OOP : Object Oriented Programming
            // Programming Paradigm
            // OOP : The Paradigm Use For Build Any Business

            // Class : Bluprint of the Object
            // Object : Specific Instance From A Class

            // 4 Pillars
            // =================
            // 1. Encapsulation
            // 2. Inheritance
            // 3. Polymorphism
            // 4. Abstraction 
            #endregion

            #region Encapsulation
            // 1. Encapsulation
            // Class Or Struct
            // Seperate The Data(Attributes) Definition From Its Use
            // [Setter Getter Methods - Properties]


            // Employee
            // Id, Name, Salary

            // 1. End-User Access Data Itself
            // 2. No Data Validayion
            // 3. No Read Only Field

            // Apply Encapsulation
            // 1. Make All Data(Attributes) Private
            // 2. Access Data Through:
            //      2.1. Setter Getter Method
            //      2.2. Properties

            //Employee E01 = new Employee(1, "Edward", -12000);
            //E01.id = 1;
            //E01.name = "Edward";
            //E01.salary = 12000;

            //Console.WriteLine(E01.id);
            //Console.WriteLine(E01.name);
            //Console.WriteLine(E01.salary);

            //E01.SetId(1);
            //E01.SetName("Edward");
            //E01.SetSalary(12000);

            //Console.WriteLine(E01.GetId());
            //Console.WriteLine(E01.GetName());
            //Console.WriteLine(E01.GetSalary()); 


            //Employee E01 = new Employee();

            //E01.Id = 12;
            //E01.Name = "Edward";
            //E01.Salary = -12000;
            //E01.Address = "Cairo";


            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);
            //Console.WriteLine(E01.Address);
            #endregion

            #region Indexer
            // Indexer: Special Property
            //          1. Named this

            // Phonebook : 

            //Phonebook phonebook = new Phonebook(3);

            //phonebook.AddPerson("Edward", 222, 0);
            //phonebook.AddPerson("Ali", 111, 1);
            //phonebook.AddPerson("Omar", 333, 2);

            //Console.WriteLine(phonebook.GetNumber("Ahmed"));

            //phonebook.UpdateNumber("Edward", 999);

            //Console.WriteLine(phonebook.GetNumber("Edward"));

            //Console.WriteLine(phonebook["Edward"]); //long

            //phonebook["Edward"] = 999; //long

            //Console.WriteLine(phonebook["Edward"]); //long

            //Console.WriteLine(phonebook[222]); //long 
            #endregion



        }
    }
}
