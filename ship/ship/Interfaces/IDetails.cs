using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ship
{
    interface IDetails
    {
        int Count { set; }
        void DrawDetails(Graphics g, float _startX, float _startY);
    }
}