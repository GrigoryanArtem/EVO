using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVO.Parameters
{
    public class Coordinate
    {
        private double _x;
        private double _y;

        #region Constructors

        public Coordinate()
        {
            _x = 0;
            _y = 0;
        }

        public Coordinate(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public Coordinate(Coordinate coordinate) 
            : this(coordinate.X, coordinate.Y) { }

        #endregion

        #region Auto implemented properties

        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        #endregion

        #region Override methods

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Coordinate p = obj as Coordinate;

            if ((System.Object)p == null)
                return false;

            return (_x == p.X) && (_y == p.Y);
        }

        public override int GetHashCode()
        {
            return _x.GetHashCode() ^ _y.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", _x, _y);
        }

        #endregion

        #region Arithmetic operators

        public static Coordinate operator +(Coordinate a, Coordinate b)
        {
            return new Coordinate(a.X + b.X, a.Y + b.Y);
        }

        public static Coordinate operator -(Coordinate a, Coordinate b)
        {
            return new Coordinate(a.X - b.X, a.Y - b.Y);
        }

        public static Coordinate operator -(Coordinate a)
        {
            return new Coordinate(-a.X, -a.Y);
        }

        #endregion

        #region Comparison operators

        public static bool operator ==(Coordinate a, Coordinate b)
        {
            if (System.Object.ReferenceEquals(a, b))
                return true;

            if (((object)a == null) || ((object)b == null))
                return false;

            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(Coordinate a, Coordinate b)
        {
            return !(a == b);
        }

        #endregion

        public virtual bool IsNull()
        {
            return false;
        }
    }
}
