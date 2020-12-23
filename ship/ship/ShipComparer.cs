using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ship
{
    public class ShipComparer : IComparer<Ship>
    {
        public int Compare(Ship x, Ship y)
        {
            if (x is MotorShip && y is MotorShip)
            {
                return ComparerMotorShip((MotorShip)x, (MotorShip)y);
            }
            if (x is MotorShip && y is DefaultShip)
            {
                return -1;
            }
            if (x is DefaultShip && y is MotorShip)
            {
                return 1;
            }
            if (x is DefaultShip && y is DefaultShip)
            {
                return ComparerDefaultShip((DefaultShip)x, (DefaultShip)y);
            }


            return 0;
        }
        private int ComparerDefaultShip(DefaultShip x, DefaultShip y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerMotorShip(MotorShip x, MotorShip y)
        {
            var res = ComparerDefaultShip(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Cabin != y.Cabin)
            {
                return x.Cabin.CompareTo(y.Cabin);
            }
            if (x.Line != y.Line)
            {
                return x.Line.CompareTo(y.Line);
            }

            return 0;
        }
    }
}