using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ship
{
    class PipeTriangle : IDetails
    {
        private DetailsEnum _countPipe;
        private Color pipeColor;
        private Pen pen = new Pen(Color.Black);
        private SolidBrush brush;
        public PipeTriangle(int count, Color dopColor)
        {
            Count = count;
            pipeColor = dopColor;
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
            brush = new SolidBrush(pipeColor);
            //труба2
            Point[] twoPipe = { new Point((int)_startPosX + 67, (int)_startPosY - 14), 
                new Point((int)_startPosX + 76, (int)_startPosY - 39), 
                new Point((int)_startPosX + 84, (int)_startPosY - 13) };
            g.DrawPolygon(pen, twoPipe);
            g.FillPolygon(brush, twoPipe);
        }
        public void Draw2PipeTriangle(Graphics g, float _startPosX, float _startPosY)
        {
            brush = new SolidBrush(pipeColor);
            //труба1
            Point[] onePipe = { new Point((int)_startPosX + 44, (int)_startPosY - 15),
                new Point((int)_startPosX + 55, (int)_startPosY - 44),
                new Point((int)_startPosX + 64, (int)_startPosY - 14) };
            g.DrawPolygon(pen, onePipe);
            g.FillPolygon(brush, onePipe);
            //труба3
            Point[] threePipe = { new Point((int)_startPosX + 87, (int)_startPosY - 13),
                new Point((int)_startPosX + 95, (int)_startPosY - 32),
                new Point((int)_startPosX + 101, (int)_startPosY - 12)};
            g.DrawPolygon(pen, threePipe);
            g.FillPolygon(brush, threePipe);
        }
    }
}
