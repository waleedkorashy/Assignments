using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    //Q11. Implement the interfaces in three classes:
    //Ship : IMoveable — prints messages about moving on the sea.
    internal class Ship : IMoveable
    {
        //public void MoveForward()
        //   => Console.WriteLine("Moving forward in the sea");
        //public void MoveBackward()
        //   => Console.WriteLine("Moving backward in the sea");



        //Q14. (Challenge) Can a class implement IMoveable explicitly? Rewrite Ship.MoveForward() 
        //using explicit interface implementation(void IMoveable.MoveForward()),

        //yes a class can implement an interface member explicitly  

        void IMoveable.MoveForward() => Console.WriteLine("Ship sailing forward on the sea.");
        void IMoveable.MoveBackward() => Console.WriteLine("Ship sailing backward on the sea.");
    }
}
