using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ship
{
    class Ship
    {
        /// <summary>
        /// Левая координата отрисовки корабля
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки корабля
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _maxHeight;
        /// <summary>
        /// Ширина отрисовки корабля
        /// </summary>
        private readonly int shipWidth = 120;
        /// <summary>
        /// Высота отрисовки корабля
        /// </summary>
        private readonly int shipHeight = 58;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес корабля
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Количество кают
        /// </summary>
        public bool Cabin { private set; get; }
        /// <summary>
        /// Полоса
        /// </summary>
        public bool Line { private set; get; }
        /// <summary>
        /// Наличие труб
        /// </summary>
        public int Pipe { private set; get; }
        /// <summary>
        /// Основной цвет корабля
        /// </summary>
        /// 
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }

        private Pipes pips;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес корабля</param>
        /// /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="cabin">Количество кают</param>
        /// <param name="line">Наличие полосы</param>
        /// <param name="countPipe">Наличие труб</param>
        /// <param name="mainColor">Основной цвет корабля</param>
        /// <param name="dopColor">Дополнительный цвет</param>

        public Ship(int maxSpeed, float weight, int countPipe, Color mainColor, Color dopColor, bool cabin, bool line)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Cabin = cabin;
            Line = line;

            pips = new Pipes();
            pips.CountPipe = countPipe;
            _maxHeight = 45;
        }
        /// <summary>
        /// Установка позиции корабля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height )
        {
            _pictureWidth = width;
            _pictureHeight = height;
            if (x >=0 && x + shipWidth < width && y >=0 && shipHeight < height)
            {
                _startPosX = x;
                _startPosY = y + 45;
            }
            
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - shipWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                   
                    if (_startPosY - step > _maxHeight)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - shipHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка корабля
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {     
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(MainColor);
            SolidBrush brWh = new SolidBrush(Color.White);
            //Палуба
            Point plate1 = new Point((int)_startPosX,(int)_startPosY);
            Point plate2 = new Point((int)_startPosX + 12, (int)_startPosY + 24);
            Point plate3 = new Point((int)_startPosX + 28, (int)_startPosY + 42);
            Point plate4 = new Point((int)_startPosX + 84, (int)_startPosY + 44);
            Point plate5 = new Point((int)_startPosX + 104, (int)_startPosY + 40);
            Point plate6 = new Point((int)_startPosX + 114, (int)_startPosY + 28);
            Point plate7 = new Point((int)_startPosX + 120, (int)_startPosY);           
            Point[] PlateForm1 = { plate1, plate2, plate3 };
            Point[] PlateForm2 = { plate3, plate4, plate5,  plate6, plate7};
            Point[] FillPlate = { plate1, plate3, plate7 };
            g.DrawCurve(pen, PlateForm1);
            g.DrawCurve(pen, PlateForm2);
            g.DrawLine(pen, plate1, plate7);
            g.FillClosedCurve(brush, PlateForm1);
            g.FillClosedCurve(brush, PlateForm2);
            g.FillPolygon(brush, FillPlate);
            
            if (Line)
            {
                Point line1 = new Point((int)_startPosX + 4, (int)_startPosY + 10);
                Point line2 = new Point((int)_startPosX + 66, (int)_startPosY + 14);
                Point line3 = new Point((int)_startPosX + 118, (int)_startPosY + 14);
                Point line4 = new Point((int)_startPosX + 8, (int)_startPosY + 16);
                Point line5 = new Point((int)_startPosX + 66, (int)_startPosY + 20);
                Point line6 = new Point((int)_startPosX + 116, (int)_startPosY + 20);
                Point[] linePoints1 = { line1, line2, line3 };
                Point[] linePoints2 = { line4, line5, line6 };
                g.DrawCurve(pen, linePoints1);
                g.DrawCurve(pen, linePoints2);
            }                    
            //якорь
            g.FillEllipse(brWh, (int)_startPosX + 27, (int)_startPosY + 10, 13, 13);
            g.DrawEllipse(pen, (int)_startPosX + 27, (int)_startPosY + 10, 13, 13);
            g.DrawEllipse(pen, (int)_startPosX + 31, (int)_startPosY + 14, 6, 6);
            g.DrawEllipse(pen, (int)_startPosX + 32, (int)_startPosY + 12, 4, 2);
            g.DrawEllipse(pen, (int)_startPosX + 28, (int)_startPosY + 15, 2, 4);
            g.DrawEllipse(pen, (int)_startPosX + 37, (int)_startPosY + 15, 2, 4);
            g.DrawEllipse(pen, (int)_startPosX + 32, (int)_startPosY + 29, 4, 4);
            g.DrawEllipse(pen, (int)_startPosX + 26, (int)_startPosY + 24, 3, 6);
            g.DrawEllipse(pen, (int)_startPosX + 40, (int)_startPosY + 24, 3, 6);
            g.DrawRectangle(pen, (int)_startPosX + 28, (int)_startPosY + 25, 12, 3);
            g.DrawRectangle(pen, (int)_startPosX + 33, (int)_startPosY + 20, 3, 10);
            g.FillRectangle(brWh, (int)_startPosX + 27, (int)_startPosY + 26, 14, 2);
            g.FillRectangle(brWh, (int)_startPosX + 34, (int)_startPosY + 21, 2, 10);
            //каюты
            brush = new SolidBrush(DopColor);
            Point CabinPoint1 = new Point((int)_startPosX + 10, (int)_startPosY);
            Point FillCabinPoint1 = new Point((int)_startPosX + 18, (int)_startPosY + 1);
            Point CabinPoint2 = new Point((int)_startPosX + 26, (int)_startPosY - 14);
            Point CabinPoint3 = new Point((int)_startPosX + 84, (int)_startPosY - 13);
            Point CabinPoint4 = new Point((int)_startPosX + 105, (int)_startPosY - 10);
            Point CabinPoint5 = new Point((int)_startPosX + 114, (int)_startPosY);
            Point FillCabinPoint5 = new Point((int)_startPosX + 106, (int)_startPosY + 1);
            Point[] fillCabin1 = { FillCabinPoint1, CabinPoint2, CabinPoint3, CabinPoint4, FillCabinPoint5 };
            g.FillClosedCurve(brush, fillCabin1);
            Point[] drawCabin1 = { CabinPoint1, CabinPoint2, CabinPoint3, CabinPoint4, CabinPoint5 };
            g.DrawCurve(pen, drawCabin1);
            if (Cabin)
            { 
                g.DrawEllipse(pen, (int)_startPosX + 23, (int)_startPosY - 10, 8, 8);
                g.FillEllipse(brWh, (int)_startPosX + 23, (int)_startPosY - 10, 8, 8);
                g.DrawEllipse(pen, (int)_startPosX + 42, (int)_startPosY - 10, 8, 8);
                g.FillEllipse(brWh, (int)_startPosX + 42, (int)_startPosY - 10, 8, 8);
                g.DrawEllipse(pen, (int)_startPosX + 61, (int)_startPosY - 9, 7, 7);
                g.FillEllipse(brWh, (int)_startPosX + 61, (int)_startPosY - 9, 7, 7);
                g.DrawEllipse(pen, (int)_startPosX + 80, (int)_startPosY - 8, 6, 6);
                g.FillEllipse(brWh, (int)_startPosX + 80, (int)_startPosY - 8, 6, 6);
                g.DrawEllipse(pen, (int)_startPosX + 99, (int)_startPosY - 7, 5, 5);
                g.FillEllipse(brWh, (int)_startPosX + 99, (int)_startPosY - 7, 5, 5);
            }
            else
            {
                g.DrawEllipse(pen, (int)_startPosX + 42, (int)_startPosY - 10, 8, 8);
                g.FillEllipse(brWh, (int)_startPosX + 42, (int)_startPosY - 10, 8, 8);
                g.DrawEllipse(pen, (int)_startPosX + 61, (int)_startPosY - 9, 7, 7);
                g.FillEllipse(brWh, (int)_startPosX + 61, (int)_startPosY - 9, 7, 7);
                g.DrawEllipse(pen, (int)_startPosX + 80, (int)_startPosY - 8, 6, 6);
                g.FillEllipse(brWh, (int)_startPosX + 80, (int)_startPosY - 8, 6, 6);
            }
            pips.DrawPipe(g, _startPosX, _startPosY);
        }
    }
}