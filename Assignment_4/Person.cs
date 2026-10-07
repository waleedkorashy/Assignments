using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    internal class Person
    {

        //Q5.Create a base class Person with properties ID, Name, Age, and two methods:
        //•	Greet() (non-virtual) that prints "I am a person's basic data.
        //// Person."
        //•	Display() marked virtual that prints the

        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            ID = Guid.Empty;
            Name = string.Empty;
            Age = 0;
        }
        public Person(string name,int age)
        {
            ID= Guid.NewGuid();
            Name = name;
            Age = age;
        }


        public string Greet()
        {
            return $"I am a person's basic data.";
        }
        public virtual string Display()
        {
            return $"Person's info:\n\tID: {ID}\n\tName: {Name}\n\tAge: {Age}";
        }

    }
}
