using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ship
{
    class CountCabin : DopDetails
    {
        private DetailsEnum _countCabin;
        public int countCabin
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
        public override void SetDetails(Graphics g)
        {
            DrawCabin(g, (int)_countCabin);
        }
    }
}