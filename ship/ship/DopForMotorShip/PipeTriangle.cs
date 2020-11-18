using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ship.DopForMotorShip
{
    class PipeTriangle:IDetails
    {
        private DetailsEnum _countPipe;
        public Pen pen = new Pen(Color.Black);
        public PipeTriangle(int count)
        {
            Count = count;
        }
        public int Count { set => _countPipe = (DetailsEnum)value; }
        public void DrawDetails(Graphics g, float _startX, float _startY)
        {
            switch (_countPipe)
            {
                case DetailsEnum.one:
                    Draw1PipeTriangle(g, _startX, _startY);
                    break;
                case DetailsEnum.two:
                    Draw2PipeTriangle(g, _startX, _startY);
                    break;
                case DetailsEnum.three:
                    Draw1PipeTriangle(g, _startX, _startY);
                    Draw2PipeTriangle(g, _startX, _startY);
                    break;
            }
        }
        public void Draw1PipeTriangle(Graphics g, float _startPosX, float _startPosY)
        {
            //труба2
            Point pipe21 = new Point((int)_startPosX + 67, (int)_startPosY - 14);
            Point pipe22 = new Point((int)_startPosX + 76, (int)_startPosY - 39);
            Point pipe23 = new Point((int)_startPosX + 84, (int)_startPosY - 13);
            g.DrawLine(pen, pipe21, pipe22);
            g.DrawLine(pen, pipe22, pipe23);
        }
        public void Draw2PipeTriangle(Graphics g, float _startPosX, float _startPosY)
        {
            //труба1
            Point pipe11 = new Point((int)_startPosX + 44, (int)_startPosY - 15);
            Point pipe12 = new Point((int)_startPosX + 55, (int)_startPosY - 44);
            Point pipe13 = new Point((int)_startPosX + 64, (int)_startPosY - 14);
            g.DrawLine(pen, pipe11, pipe12);
            g.DrawLine(pen, pipe12, pipe13);
            //труба3
            Point pipe31 = new Point((int)_startPosX + 87, (int)_startPosY - 13);
            Point pipe32 = new Point((int)_startPosX + 95, (int)_startPosY - 32);
            Point pipe33 = new Point((int)_startPosX + 101, (int)_startPosY - 12);
            g.DrawLine(pen, pipe31, pipe32);
            g.DrawLine(pen, pipe32, pipe33);
        }
    }
}