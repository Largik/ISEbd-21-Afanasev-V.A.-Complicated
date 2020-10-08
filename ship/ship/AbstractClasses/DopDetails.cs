using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace ship
{
    public abstract class DopDetails : IDetails
    {
        protected float _startX;
        protected float _startY;
        protected Pen pen = new Pen(Color.Black);
        public int _form = 1;
        public void SetData(int startX,int startY)
        {
            _startX = startX;
            _startY = startY;
        }
        public abstract void SetDetails(Graphics g);
        public void DrawCabin(Graphics g,  int count)
        {
            SolidBrush brWh = new SolidBrush(Color.White);
            int tmp = 0;
            if(_form == 1)
            {
                for (int index = 0; index < count; index++)
                {
                    g.DrawEllipse(pen, (int)_startX + 23 + tmp, (int)_startY - 10 + index, 9 - index, 9 - index);
                    g.FillEllipse(brWh, (int)_startX + 23 + tmp, (int)_startY - 10 + index, 9 - index, 9 - index);
                    tmp += 19;
                }
            }
            if (_form == 2)
            {
                for (int index = 0; index < count; index++)
                {
                    g.DrawRectangle(pen, (int)_startX + 23 + tmp, (int)_startY - 10 + index, 9 - index, 9 - index);
                    g.FillRectangle(brWh, (int)_startX + 23 + tmp, (int)_startY - 10 + index, 9 - index, 9 - index);
                    tmp += 19;
                }
            }
        }
        public void SetForm(int form)
        {
            _form = form;
        }
    }
}
