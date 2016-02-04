using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application01
{
    public class Path : IEnumerator, IEnumerable
    {
        private List<Point3D> points;
        int position = -1;

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public int Count
        {
            get
            {
                return this.points.Count;
            }
        }

        public void AddPoint(Point3D p)
        {
            this.points.Add(p);
        }

        public void RemovePoint(Point3D point)
        {
            this.points.Remove(point);
        }
        
        //IEnumerator and IEnumerable require these methods.
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        //IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position < points.Count);
        }

        //IEnumerable
        public void Reset()
        { position = 0; }

        //IEnumerable
        public object Current
        {
            get { return points[position]; }
        }
    }
}
