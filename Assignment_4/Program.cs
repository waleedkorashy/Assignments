namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1

            //==============================Part 1==============================
            Console.WriteLine("//==============================Part 1==============================\n");
            Console.WriteLine("-------------Q6-----------------");
            // Part 01 Q6 array of three employees
            // first is a DBA then a Guest then the security officer with full permissions
            Employee[] EmpArr = new Employee[]
            {
                new Employee("Ahmed", SecLevels.DBA, 20_000, new HireDate(1, 2, 2020), 'M'),
                new Employee("Layla", SecLevels.Guest, 15_000, new HireDate(15, 9, 2025), 'F'),
                new Employee("Tamer", SecLevels.SecurityOfficer, 45_000, new HireDate(24, 6, 2016), 'M'),
            };

            foreach (Employee emp in EmpArr)
            {
                Console.WriteLine(emp);
                Console.WriteLine("--------------------------------\n");
            }
            #endregion
            #region Part 2
            //==============================Part 2==============================
            Console.WriteLine("//==============================Part 2==============================\n");
            Console.WriteLine("-------------Q3-----------------\n");

            //Q3.In Main, create:
            //•	Shape shape = new Shape(2, 3); → call Area() — what is printed?
            //•	Cube cube = new Cube(2, 3, 4); → call Area() — what is printed?
            //•	Shape shapeRef = new Cube(2, 3, 4); → call Area() — what is printed and why? Explain the difference between this and the previous call(which version of Area() gets executed and why this is called early /static binding).


            Shape shape = new Shape(2, 3);
            Console.WriteLine(shape.CalcArea());//what is printed? 6
            Console.WriteLine("------------------------------------\n");

            Cube cube = new Cube(2, 3, 4);
            Console.WriteLine(cube.CalcArea());//what is printed? 24
            Console.WriteLine("------------------------------------\n");

            Shape shapeRef = new Cube(2, 3, 4);
            Console.WriteLine(shapeRef.CalcArea());// prints 6 not 24
            // why? because the reference type is Shape so the compiler picks Shape CalcArea
            // it doesn't care that the real object is a Cube
            // this is early/static binding because the choice is made at compile time
            // if CalcArea was virtual in Shape and override in Cube it would print 24 (late/dynamic binding)
            Console.WriteLine("------------------------------------\n");







            //Q4.Declare object obj = new Cube(1, 2, 3); and call obj.ToString().
            Console.WriteLine("-------------Q4-----------------\n");

            object obj = new Cube(1, 2, 3);
            Console.WriteLine(obj.ToString());
            Console.WriteLine("------------------------------------\n");
            // which ToString runs?
            // the one in Cube (the override) not the one in object 

            //why?
            // because ToString is virtual in object and Cube overrides it
            // so at run time the real object type is checked and it is a Cube

            //What concept does this demonstrate(late / dynamic binding) ?
            //late (dynamic) binding also called run time polymorphism

            //Why did ToString() behave polymorphically while Area() did not?
            //ToString is virtual in object and overridden in Cube so the call is decided at run time
            // Area is a normal method (not virtual) so the call was decided at compile time
            // using the reference type only (early binding)
            // to make Area work the same way we need virtual in Shape and override in Cube

            Console.WriteLine("------------------------------------\n");
            Console.WriteLine("-------------Q7-----------------\n");

            Person doctor = new Doctor("Mohamed", 22, "Cardiology");
            Person engineer = new Engineer("Ahmed", 32, "Civil");

            //Doctor object of Person refrence
            ProcessPerson(doctor);
            Console.WriteLine("-------------------------------------\n");
            //Engineer object of Person refrence
            ProcessPerson(engineer);

        }

        static void ProcessPerson(Person person)
        {
            Console.WriteLine(person.Greet());    //because of hidin the method the compiler decides because its compile time so it calls Person.Greet()
            Console.WriteLine(person.Display()); //because the method is overriden (Virtual = rundime) the call happens in runtime so its calls (Doctor or Engineer)'s  
        }


        //Q8. What happens if you remove virtual from Display() in Person?
        //What compiler warning/error appears in the derived classes, and what does it mean?

        //compile error shows up
        //CS0506: 'Doctor.Display()': cannot override inherited member 'Person.Display()' because it is not marked virtual, abstract, or override
        //this means that we cant overried Display method without marking it as virtual in the parent class
        #endregion
        #region Part 3
        //Q15.Fill in the comparison table from your own experiments:
        //Feature                            Static Binding(new)	             Dynamic Binding(override)

        //Keyword in base	                 no keyword needed                      virtual    
        //Keyword in derived                 new                                    override
        //Resolved at		                 compile time                           runtime 
        //Behavior via base reference        runs the parent version                runs the overriden version (the child)




        //Q16.In your own words: why does C# require virtual on the base method before override is allowed, but new works on any method?


        // When a base class marks a method as virtual it creates a slot in the vtable When a derived class uses override it explicitly targets that specific slot and rewrites
        //the function pointer to point to the new derived implementation

        // The new keyword tells the compiler:"I know a method with this exact signature exists in the base class but I want to introduce a completely
        // unrelated method that just happens to share the same name" It does not alter the vtable slot of the base class
        #endregion
    }

}