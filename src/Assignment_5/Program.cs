namespace Assignment_5
{

    internal class Program
    {

        static void Main(string[] args)
        {
            //    #region Assignment 03 OOP
            //    //Q12. In Main:
            //    //•	Create each class with its concrete type and call its methods.
            //    Car car = new Car();
            //    car.MoveForward();
            //    car.MoveBackward();
            //    Console.WriteLine("================================================");

            //    Ship ship = new Ship();
            //    ship.MoveForward();
            //    ship.MoveBackward();
            //    Console.WriteLine("================================================");

            //    Airplane plane = new Airplane();
            //    plane.MoveForward();
            //    plane.MoveBackward();
            //    plane.MoveUp();
            //    plane.MoveDown();
            //    Console.WriteLine("================================================");


            //    //•	Then declare IMoveable carRef = new Car(); and IMoveable planeRef = new Airplane();
            //    //and call MoveForward()/MoveBackward() through the interface references.
            //    IMoveable carRef = new Car();
            //    IMoveable planeRef = new Airplane();

            //    carRef.MoveForward();
            //    carRef.MoveBackward();

            //    planeRef.MoveForward();
            //    planeRef.MoveBackward();


            //    //Question: Can you call MoveUp() on planeRef?   ->     No we can't call Moveup() on planeRef
            //    //Why or why not?    ->   it will give a compilor error because its from IMoveable type it cant see MoveUp()
            //    //What reference type would you need?       ->     IFlyable refrence

            //    //Q14
            //    //Q14. (Challenge) Can a class implement IMoveable explicitly? Rewrite Ship.MoveForward()
            //    //using explicit interface implementation(void IMoveable.MoveForward())
            //    //, then try calling it on a Ship object directly.

            //    //Ship ship = new Ship();
            //    //ship.MoveForward();   


            //    //What happens?
            //    // gives a compile error ->CS1061: 'Ship' does not contain a definition for 'MoveForward'
            //    // and no accessible extension method 'MoveForward' accepting a first argument of type
            //    // 'Ship' could be found (are you missing a using directive or an assembly reference?)

            //    //, and how must you call it instead?  ->     using a reference of IMovable
            //    IMoveable moveableShip = new Ship();
            //    moveableShip.MoveForward();
            //    moveableShip.MoveBackward();

            //    //or cast an existing Ship reference
            //    ((IMoveable)ship).MoveForward();

            //    #endregion
            //    #region Assignment 04 OOP
            //    #region First Project

            //    //First Project:
            //    //3. Read from the User the Coordinates for 2 points P1, P2
            //    //(Check the input using try Pares, Parse, Convert).
            //    Point3D P1 = new Point3D();
            //    Point3D P2 = new Point3D();
            //    P1.X = Helpers.ReadInt("Enter point 1 X value:");
            //    P1.Y = Helpers.ReadInt("Enter point 1 Y value:");
            //    P1.Z = Helpers.ReadInt("Enter point 1 Z value:");

            //    P2.X = Helpers.ReadInt("Enter point 2 X value:");
            //    P2.Y = Helpers.ReadInt("Enter point 2 Y value:");
            //    P2.Z = Helpers.ReadInt("Enter point 2 Z value:");

            //    //Try to use ==
            //    if(P1 == P2 )
            //        Console.WriteLine("True");
            //    else 
            //        Console.WriteLine("False");
            //    //If(P1 == P2) Does it work properly? No because they are different objects in memory 

            //    //---------------------------------------

            //    //3. Read from the User the Coordinates for 2 points P1, P2
            //    //(Check the input using try Pares, Parse, Convert).

            //    Point3D p1 = Helpers.ReadPoint3D(); // the implementation is inside the Helper method ReadPoint3D()
            //    Point3D p2 = Helpers.ReadPoint3D();


            //    //-------------------------------------------------

            //    //Define an array of points and sort this array based on X & Y coordinates
            //    Point3D[] points = new Point3D[] 
            //    { 
            //        new Point3D( 1 , 1, 1 ),
            //        new Point3D( 1 , 0, 1 ),
            //        new Point3D( 2 , 1, 8 ),
            //        new Point3D( 4 , 3, 7 ),
            //        new Point3D( 5 , 6, 1 ),

            //    };
            //    Array.Sort(points);
            //    #endregion

            //    #region Second Project:
            //    //Define Class Maths that has four methods: Add, Subtract, Multiply,
            //    //and Divide, each of them takes two parameters.Call each method
            //    //in Main().

            //    //Maths maths = new Maths();
            //    //maths.Add(10, 5);
            //    //maths.Subtract(10, 5);
            //    //maths.Multiply(10, 5);
            //    //maths.Divide(10, 5);


            //    //Modify the program so that you do not have to create an instance
            //    //of class to call the four methods.
            //    Maths.Add(10, 5);
            //    Maths.Subtract(10, 5);
            //    Maths.Multiply(10, 5);
            //    Maths.Divide(10, 5);

            //    #endregion
            //    #region Third Project:

            //    #endregion
            //    #endregion
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1);

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2);


            Duration D3 = new Duration(7800);
            Console.WriteLine(D3);


            Duration D4 = new Duration(666);
            Console.WriteLine(D4);


        }
    }
}