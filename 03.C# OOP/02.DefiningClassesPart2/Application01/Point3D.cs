using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application01
{
    public struct Point3D
    {
        //Fields
        private double x;
        private double y;
        private double z;
        private static readonly Point3D o;

        //Constructors
        public Point3D(double x, double y, double z)
            : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point3D O 
        {
            get { return o; }
        }
        static Point3D() 
        {
            o = new Point3D(0, 0, 0);
        }

        //Properties
        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.x, this.y, this.z);
        }
    }
}
