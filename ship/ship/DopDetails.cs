using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ship
{
    public abstract class DopDetails : IDetails
    {
        protected float _startX;
        protected float _startY;
        protected Pen pen = new Pen(Color.Black);
        public void SetData(int startX,int startY)
        {
            _startX = startX;
            _startY = startY;
        }
        public abstract void DrawDetails(Graphics g);
    }
}
