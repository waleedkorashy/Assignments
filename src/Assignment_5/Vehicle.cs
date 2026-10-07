using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    //Q13.Then create a class Vehicle :Vehicle that implements all four methods as virtual.
    //What is the benefit of an interface inheriting other interfaces?

    //IVehicle just combines IMoveable and IFlyable into one interface so instead of writing both
    //every time I can just use IVehicle.It keeps the code cleaner 
    //while still letting classes use IMoveable or IFlyable alone if they only need one.

    internal class Vehicle : IVehicle
    {
        public virtual void MoveForward() 
            => Console.WriteLine("Vehicle moving forward.");
        public virtual void MoveBackward() 
            => Console.WriteLine("Vehicle moving backward.");
        public virtual void MoveUp() 
            => Console.WriteLine("Vehicle moving up.");
        public virtual void MoveDown() 
            => Console.WriteLine("Vehicle moving down.");
    }
}
