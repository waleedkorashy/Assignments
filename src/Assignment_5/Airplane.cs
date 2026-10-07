namespace Assignment_5
{
    //Q11. Implement the interfaces in three classes:
    //Airplane : IMoveable, IFlyable — prints messages about moving in the air
    internal class Airplane : IMoveable, IFlyable
    {
        public void MoveForward()
            => Console.WriteLine("Moving forward in the air");
        public void MoveBackward()
            => Console.WriteLine("Moving backward in the air");
        public void MoveUp()
            => Console.WriteLine("Moving upward in the air");
        public void MoveDown()
            => Console.WriteLine("Moving downward in the air");
    }
}
