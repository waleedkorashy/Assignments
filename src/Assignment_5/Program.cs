using System.Dynamic;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q12. In Main:
            //•	Create each class with its concrete type and call its methods.
            Car car = new Car();
            car.MoveForward();
            car.MoveBackward();
            Console.WriteLine("================================================");

            Ship ship = new Ship();
            ship.MoveForward();
            ship.MoveBackward();
            Console.WriteLine("================================================");

            Airplane plane = new Airplane();
            plane.MoveForward();
            plane.MoveBackward();
            plane.MoveUp();
            plane.MoveDown();
            Console.WriteLine("================================================");


            //•	Then declare IMoveable carRef = new Car(); and IMoveable planeRef = new Airplane();
            //and call MoveForward()/MoveBackward() through the interface references.
            IMoveable carRef = new Car();
            IMoveable planeRef = new Airplane();

            carRef.MoveForward();
            carRef.MoveBackward();

            planeRef.MoveForward();
            planeRef.MoveBackward();


            //Question: Can you call MoveUp() on planeRef?   ->     No we can't call Moveup() on planeRef
            //Why or why not?    ->   it will give a compilor error because its from IMoveable type it cant see MoveUp()
            //What reference type would you need?       ->     IFlyable refrence

            //Q14
            //Q14. (Challenge) Can a class implement IMoveable explicitly? Rewrite Ship.MoveForward()
            //using explicit interface implementation(void IMoveable.MoveForward())
            //, then try calling it on a Ship object directly.

            //Ship ship = new Ship();
            //ship.MoveForward();   


            //What happens?
            // gives a compile error ->CS1061: 'Ship' does not contain a definition for 'MoveForward'
            // and no accessible extension method 'MoveForward' accepting a first argument of type
            // 'Ship' could be found (are you missing a using directive or an assembly reference?)

            //, and how must you call it instead?  ->     using a reference of IMovable
            IMoveable moveableShip = new Ship();
            moveableShip.MoveForward();  
            moveableShip.MoveBackward();  

            //or cast an existing Ship reference
            ((IMoveable)ship).MoveForward();



        }
    }
}
