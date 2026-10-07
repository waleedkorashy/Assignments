using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    //    Q6.Create two derived classes:
    //•	Doctor : Person with property Specialty — hide Greet() with new and override Display() to include the specialty.

    internal class Doctor: Person
    {
        public string Specialty { get; set; }
        public Doctor(string name, int age, string specialty) :base(name, age)
        {
            Specialty = specialty;
        }

        public new string Greet() 
        {
            return "I am a doctors's basic data.";
        }

        public override string Display()
        {
            return $"Doctors's info:\n\tID: {ID}\n\tName: {Name}\n\tAge: {Age}\n\tSpecialty: {Specialty}";
        }
    }
}
