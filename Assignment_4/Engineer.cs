using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_4
{
    	//Engineer : Person with prope•	Create a Doctor object (usrties Field and c— hide Greet() with new and override Display() to include all data.


    internal class Engineer: Person
    {
        public string Field { get; set; }

        public Engineer(string name, int age, string field) : base(name, age)
        {
            Field = field;
        }

        public new string Greet()
        {
            return "I am an engineer's basic data.";
        }

        public override string Display()
        {
            return $"Engineers's info:\n\tID: {ID}\n\tName: {Name}\n\tAge: {Age}\n\tSpecialty: {Field}";

        }
    }
}
