using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coords
{
    internal class Coord : IEquatable<Coord>, IComparable<Coord>
    {
        public Coord(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        public int X { get; set; }
        public int Y { get; set; }

        public double Size 
        { 
            get 
            { 
                return Math.Sqrt(X * X + Y * Y); 
            } 
        }

        public double Magnitude 
        { 
            get 
            { 
                return (X * X + Y * Y); 
            } 
        }

        public bool Equals (Coord other)
        {
            if (X == other.X && Y == other.Y)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public static bool operator ==(Coord a, Coord b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Coord a, Coord b)
        {
            return !a.Equals(b);
        }
        
        public int CompareTo (Coord other)
        {
            return Size.CompareTo (other.Size);
        }

        public static bool operator >(Coord a, Coord b)
        {
            return a.CompareTo(b) > 0;
        }

        public static bool operator <(Coord a, Coord b)
        {
            return a.CompareTo(b) < 0;
        }
    }
}
