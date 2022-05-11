using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOps
{
    internal class Point:IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x,int y)
        {
            X = x; Y = y; 
        }
        public override string ToString() => $"[{this.X},{this.Y}]";
        public static Point operator +(Point p1,Point p2)=> new Point((p1.X+p2.X),(p1.Y+p2.Y));
            
        
        public static Point operator -(Point p1, Point p2)=> new Point((p1.X - p2.X), (p1.Y - p2.Y));
            
        public static Point operator +(Point p,int number)=>new Point((p.X+number), (p.Y+number)); 
        public static Point operator +(int number, Point p)=>new Point((number+p.X), (number+ p.Y)); 
        public static Point operator ++(Point point)=>new Point(point.X+1,point.Y+1);
        public static Point operator --(Point point)=>new Point(point.X-1, point.Y-1);
        public override bool Equals(object obj) => ToString() == this.ToString();
        public override int GetHashCode() => ToString().GetHashCode();
        public static  bool operator ==(Point p,Point p2)=>p.Equals(p);
        public static bool operator !=(Point p,Point p2)=>!p.Equals(p2);
        public int CompareTo(Point other)
        {
            if (this.X > other.X && this.Y > other.Y)
                return 1;
            if (this.X < other.X && this.Y < other.Y)
                return -1;
            else
                return 0;
        }
        public static bool operator >(Point p,Point p2)=>p.CompareTo(p2) > 0;
        public static bool operator <(Point p,Point p2)=>p.CompareTo(p2) < 0;
        public static bool operator <= (Point p,Point p2)=>p.CompareTo(p2) <= 0;
        public static bool operator >= (Point p,Point p2)=>p.CompareTo(p2) >= 0;

    }
}
