using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ship
{
    class Cabin : DopDetails
    {
        private DetailsEnum _countCabin;
        public int CountCabin
        {
            set
            {
                if (value < 3)
                {
                    _countCabin = DetailsEnum.three;
                }
                if(value == 4)
                {
                    _countCabin = DetailsEnum.four;
                }
                if(value > 5)
                {
                    _countCabin = DetailsEnum.five;
                }
                else
                {
                    _countCabin = (DetailsEnum)value;
                }
            }
        }
        public override void DrawDetails(Graphics g)
        {
            SolidBrush brWh = new SolidBrush(Color.White);

            if (_countCabin == DetailsEnum.four)
            {

                Draw4Cabin(g, brWh, _startX, _startY);
            }
            if (_countCabin == DetailsEnum.five)
            {
                Draw4Cabin(g, brWh, _startX, _startY); 
                Draw5Cabin(g, brWh, _startX, _startY);
            }
        }
        private void Draw4Cabin(Graphics g, SolidBrush brWh, float startX, float startY)
        {
            g.DrawEllipse(pen, (int)startX + 23, (int)startY - 10, 8, 8);
            g.FillEllipse(brWh, (int)startX + 23, (int)startY - 10, 8, 8);
        }
        private void Draw5Cabin(Graphics g, SolidBrush brWh, float startX, float startY)
        {
            g.DrawEllipse(pen, (int)startX + 99, (int)startY - 7, 5, 5);
            g.FillEllipse(brWh, (int)startX + 99, (int)startY - 7, 5, 5);
        }
    }
}