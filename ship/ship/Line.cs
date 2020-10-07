using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ship
{
    class Line : DopDetails
    {
        private DetailsEnum _countLine;
        public int CountLine
        {
            set
            {
                if (value < 1)
                {
                    _countLine = DetailsEnum.one;
                }
                if (value > 2)
                {
                    _countLine = DetailsEnum.two;
                }
                else
                {
                    _countLine = (DetailsEnum)value;
                }
            }
        }
        public override void DrawDetails(Graphics g)
        {
            if (_countLine == DetailsEnum.one)
            {
                DrawLine(g, _startX, _startY, false);
            }
            if (_countLine == DetailsEnum.two)
            {
                DrawLine(g, _startX, _startY, true);
            }
        }
        private void DrawLine(Graphics g, float startX, float startY, bool count)
        {
            Point line1 = new Point((int)startX + 4, (int)startY + 10);
            Point line2 = new Point((int)startX + 66, (int)startY + 14);
            Point line3 = new Point((int)startX + 118, (int)startY + 14);
            Point line4 = new Point((int)startX + 8, (int)startY + 16);
            Point line5 = new Point((int)startX + 66, (int)startY + 20);
            Point line6 = new Point((int)startX + 116, (int)startY + 20);
            Point[] linePoints1 = { line1, line2, line3 };
            Point[] linePoints2 = { line4, line5, line6 };
            if (count)
            {
                g.DrawCurve(pen, linePoints1);
                g.DrawCurve(pen, linePoints2);
            }
            else
            {
                g.DrawCurve(pen, linePoints1);                
            }        
        }
    }
}
