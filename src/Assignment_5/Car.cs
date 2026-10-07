namespace Assignment_5
{
    //Q11. Implement the interfaces in three classes:
    //•	Car : IMoveable — prints messages about moving on the ground.


    internal class Car : IMoveable
    {
        public void MoveForward()
            => Console.WriteLine("Moving forward on the ground");
        public void MoveBackward()
            => Console.WriteLine("Moving backward on the ground");

    }
}
