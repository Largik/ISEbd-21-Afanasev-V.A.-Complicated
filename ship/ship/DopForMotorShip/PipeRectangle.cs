using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ship
{
    class PipeRectangle : IDetails
    {
        private DetailsEnum _countPipe;
        private Color pipeColor;
        private Pen pen = new Pen(Color.Black);
        private SolidBrush brush;
        public PipeRectangle(int count, Color dopColor)
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
                    Draw1PipeRect(g, _startX, _startY);
                    break;
                case DetailsEnum.two:
                    Draw2PipeRect(g, _startX, _startY);
                    break;
                case DetailsEnum.three:
                    Draw1PipeRect(g, _startX, _startY);
                    Draw2PipeRect(g, _startX, _startY);
                    break;
            }
        }
        public void Draw1PipeRect(Graphics g, float _startPosX, float _startPosY)
        {
            brush = new SolidBrush(pipeColor);
            //труба2
            g.DrawRectangle(pen, (int)_startPosX + 70, (int)_startPosY - 36, 14, 40);
            g.FillRectangle(brush, (int)_startPosX + 70, (int)_startPosY - 36, 14, 40);
        }
        public void Draw2PipeRect(Graphics g, float _startPosX, float _startPosY)
        {
            brush = new SolidBrush(pipeColor);
            //труба1
            g.DrawRectangle(pen, (int)_startPosX + 45, (int)_startPosY - 41, 16, 40);
            g.FillRectangle(brush, (int)_startPosX + 45, (int)_startPosY - 41, 16, 40);
            //труба3
            g.DrawRectangle(pen, (int)_startPosX + 92, (int)_startPosY - 30, 10, 40);
            g.FillRectangle(brush, (int)_startPosX + 92, (int)_startPosY - 30, 10, 40);
        }

        public void SetDopColor(Color color)
        {
            pipeColor = color;        
        }
    }
}