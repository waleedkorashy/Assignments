using System.Reflection.Metadata.Ecma335;

namespace Assignment_5
{

    //1. Define 3D Point Class and the basic Constructors (use chaining in constructors)
    internal class Point3D : IComparable<Point3D>, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D()
        {
            X = default;
            Y = default;
            Z = default;
        }
        public Point3D(int x) : base()
        {
            X = x;
        }
        public Point3D(int x, int y) : base()
        {
            X = x;
            Y = y;
        }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        //2. Override the ToString Function to produce this output:
        //Point3D P = new Point3D(10, 10, 10);
        //Console.WriteLine(P.ToString( ));
        //Output: “Point Coordinates: (10, 10, 10)”.
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(Point3D? p)
        {
            if (p is null)
                return 1;

            int xCompare = this.X.CompareTo(p.X);
            if (xCompare != 0)
                return xCompare;

            return this.Y.CompareTo(p.Y);
        }

        public object Clone()
        {
            return new Point3D(this.X, this.Y, this.Z);
        }
    }
}
