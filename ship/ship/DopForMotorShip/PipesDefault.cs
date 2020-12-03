using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ship
{
    class PipesDefault : IDetails
    {
        private DetailsEnum _countPipe;
        private Color pipeColor;
        private Pen pen = new Pen(Color.Black);
        private SolidBrush brush;
        public PipesDefault(int count, Color dopColor)
        {
            Count = count;
            pipeColor = dopColor;
        }
        public void SetDopColor(Color color)
        {
            pipeColor = color;
        }
        public int Count { set => _countPipe = (DetailsEnum)value; }
        public void DrawDetails(Graphics g, float _startX, float _startY)
        {
            brush = new SolidBrush(pipeColor);
            switch (_countPipe)
            {
                case DetailsEnum.one:
                    Draw1Pipe(g, _startX, _startY);
                    break;
                case DetailsEnum.two:
                    Draw2Pipe(g, _startX, _startY);
                    break;
                case DetailsEnum.three:
                    Draw1Pipe(g, _startX, _startY);
                    Draw2Pipe(g, _startX, _startY);
                    break;
            }
        }
        public void Draw1Pipe(Graphics g, float startX, float startY)
        {
            brush = new SolidBrush(pipeColor);
            //2 труба
            
            Point pipe21 = new Point((int)startX + 67, (int)startY - 14);
            Point pipe22 = new Point((int)startX + 68, (int)startY - 36);
            Point pipe23 = new Point((int)startX + 76, (int)startY - 39);
            Point pipe24 = new Point((int)startX + 84, (int)startY - 35);
            Point pipe25 = new Point((int)startX + 84, (int)startY - 13);
            Point pipe26 = new Point((int)startX + 68, (int)startY - 30);
            Point pipe27 = new Point((int)startX + 76, (int)startY - 33);
            Point pipe28 = new Point((int)startX + 84, (int)startY - 29);
            Point pipe29 = new Point((int)startX + 68, (int)startY - 26);
            Point pipe210 = new Point((int)startX + 76, (int)startY - 29);
            Point pipe211 = new Point((int)startX + 84, (int)startY - 25);
            Point[] pipe2 = { new Point((int)startX + 67, (int)startY - 14),
            new Point((int)startX + 68, (int)startY - 36),
            new Point((int)startX + 76, (int)startY - 39),
            new Point((int)startX + 84, (int)startY - 35),
            new Point((int)startX + 84, (int)startY - 13)
            }; 
            g.FillPolygon(brush, pipe2);
            g.DrawLine(pen, pipe21, pipe22);
            Point[] PIPE2 = { pipe22, pipe23, pipe24 };
            Point[] PIPE22 = { pipe26, pipe27, pipe28 };
            Point[] PIPE23 = { pipe29, pipe210, pipe211 };
            g.DrawCurve(pen, PIPE2);
            g.DrawLine(pen, pipe24, pipe25);
            g.DrawCurve(pen, PIPE22);
            g.DrawCurve(pen, PIPE23);           
        }
        public void Draw2Pipe(Graphics g, float startX, float startY)
        {
            //1 труба
            Point pipe11 = new Point((int)startX + 44, (int)startY - 15);
            Point pipe12 = new Point((int)startX + 45, (int)startY - 41);
            Point pipe13 = new Point((int)startX + 55, (int)startY - 44);
            Point pipe14 = new Point((int)startX + 64, (int)startY - 40);
            Point pipe15 = new Point((int)startX + 64, (int)startY - 14);
            Point pipe16 = new Point((int)startX + 45, (int)startY - 33);
            Point pipe17 = new Point((int)startX + 55, (int)startY - 36);
            Point pipe18 = new Point((int)startX + 64, (int)startY - 32);
            Point pipe19 = new Point((int)startX + 45, (int)startY - 29);
            Point pipe110 = new Point((int)startX + 55, (int)startY - 32);
            Point pipe111 = new Point((int)startX + 64, (int)startY - 28);
            Point[] pipe1 = { new Point((int)startX + 44, (int)startY - 15),
            new Point((int)startX + 45, (int)startY - 41),
            new Point((int)startX + 55, (int)startY - 44),
            new Point((int)startX + 64, (int)startY - 40),
            new Point((int)startX + 64, (int)startY - 14)
            };
            g.FillPolygon(brush, pipe1); 
            g.DrawLine(pen, pipe11, pipe12);
            Point[] PIPE1 = { pipe12, pipe13, pipe14 };
            Point[] PIPE12 = { pipe16, pipe17, pipe18 };
            Point[] PIPE13 = { pipe19, pipe110, pipe111 };
            g.DrawCurve(pen, PIPE1);
            g.DrawLine(pen, pipe14, pipe15);
            g.DrawCurve(pen, PIPE12);
            g.DrawCurve(pen, PIPE13);
            //3 труба
            Point pipe31 = new Point((int)startX + 87, (int)startY - 13);
            Point pipe32 = new Point((int)startX + 88, (int)startY - 30);
            Point pipe33 = new Point((int)startX + 95, (int)startY - 32);
            Point pipe34 = new Point((int)startX + 101, (int)startY - 29);
            Point pipe35 = new Point((int)startX + 101, (int)startY - 12);
            Point pipe36 = new Point((int)startX + 88, (int)startY - 26);
            Point pipe37 = new Point((int)startX + 95, (int)startY - 28);
            Point pipe38 = new Point((int)startX + 101, (int)startY - 25);
            Point pipe39 = new Point((int)startX + 88, (int)startY - 23);
            Point pipe310 = new Point((int)startX + 95, (int)startY - 25);
            Point pipe311 = new Point((int)startX + 101, (int)startY - 22);
            Point[] pipe3 = { new Point((int)startX + 87, (int)startY - 13),
            new Point((int)startX + 88, (int)startY - 30),
            new Point((int)startX + 95, (int)startY - 32),
            new Point((int)startX + 101, (int)startY - 29),
            new Point((int)startX + 101, (int)startY - 12)
            };
            g.FillPolygon(brush, pipe3);
            g.DrawLine(pen, pipe31, pipe32);
            Point[] PIPE3 = { pipe32, pipe33, pipe34 };
            Point[] PIPE32 = { pipe36, pipe37, pipe38 };
            Point[] PIPE33 = { pipe39, pipe310, pipe311 };
            g.DrawCurve(pen, PIPE3);
            g.DrawLine(pen, pipe34, pipe35);
            g.DrawCurve(pen, PIPE32);
            g.DrawCurve(pen, PIPE33);
        }
    }
}