using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    //Q13. Create an interface IVehicle that inherits from both IMoveable and IFlyable
    //without adding new members
    internal interface IVehicle : IMoveable,IFlyable
    {
    }
}
