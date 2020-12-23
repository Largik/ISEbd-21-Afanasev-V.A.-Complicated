﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ship
{
    public class MotorShip : DefaultShip, IEquatable<MotorShip>, IComparable<MotorShip>, IEnumerator<string>
    {
        private IDetails details;
        public bool Cabin { private set; get; }
        public bool Line { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { protected set; get; }
        private int currentIndex;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес корабля</param>
        /// /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="cabin">Количество кают</param>
        /// <param name="fCabin">Наличие полосы</param>
        /// <param name="pipe">Наличие труб</param>
        /// <param name="mainColor">Основной цвет корабля</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        public MotorShip(int maxSpeed, float weight, Color mainColor,
            Color dopColor, bool cabin, bool line) :
            base(maxSpeed, weight, mainColor, 120, 58)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            DopColor = dopColor;
            Cabin = cabin;
            Line = line;    
        }
        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info"></param>
        public MotorShip(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Cabin = Convert.ToBoolean(strs[4]);
                Line = Convert.ToBoolean(strs[5]);
                switch (strs[6].Split('.')[0])
                {
                    case "PipesDefault":
                        details = new PipesDefault(Convert.ToInt32(strs[6].Split('.')[1]));
                        details.SetDopColor(DopColor);
                        break;
                    case "PipeRectangle":
                        details = new PipeRectangle(Convert.ToInt32(strs[6].Split('.')[1]));
                        details.SetDopColor(DopColor); 
                        break;
                    case "PipeTriangle":
                        details = new PipeTriangle(Convert.ToInt32(strs[6].Split('.')[1]));
                        details.SetDopColor(DopColor);
                        break;
                }
            }
        }
        public void SetPipeForm(IDetails idetails)
        {
            this.details = idetails;
        }
        /// <summary>
        /// Отрисовка корабля
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            SolidBrush brWh = new SolidBrush(Color.White);
            details?.DrawDetails(g, _startPosX, _startPosY);
            base.DrawTransport(g);
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
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
            details.SetDopColor(DopColor);
        }
        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Cabin}{separator}{Line}{separator}{details}";
        }
        public bool Equals(MotorShip other)
        {
            var res = base.Equals(other);
            if (!res)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Cabin != other.Cabin)
            {
                return false;
            }
            if (Line != other.Line)
            {
                return false;
            }
            if ((details != null) && (other.details != null))
            {
                if (details.ToString() != other.details.ToString())
                {
                    return false;
                }
            }
            if (details != null ^ other.details != null)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is MotorShip motShipObj))
            {
                return false;
            }
            else
            {
                return Equals(motShipObj);
            }
        }
        public new string Current
        {
            get
            {
                switch (currentIndex)
                {
                    case 0:
                        return MaxSpeed.ToString();
                    case 1:
                        return Weight.ToString();
                    case 2:
                        return MainColor.Name;
                    case 3:
                        return DopColor.Name;
                    case 4:
                        return Cabin.ToString();
                    case 5:
                        return Line.ToString();
                    case 6:
                        return details.ToString();
                }
                return null;
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public new void Dispose()
        {
        }
        public new bool MoveNext()
        {
            currentIndex++;
            return (currentIndex < 6);
        }
        public new void Reset()
        {
            currentIndex = -1;
        }
        public new IEnumerator<string> GetEnumerator()
        {
            return this;
        }
        public int CompareTo(MotorShip other)
        {
            var res = base.CompareTo(other as DefaultShip);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                return DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Cabin != other.Cabin)
            {
                return Cabin.CompareTo(other.Cabin);
            }
            if (Line != other.Line)
            {
                return Line.CompareTo(other.Line);
            }
            if ((details != null) && (other.details != null))
            {
                if (details.ToString() != other.details.ToString())
                {
                    return details.ToString().CompareTo(other.details.ToString());
                }
            }
            if ((details == null) && (other.details != null))
            {
                return 1;
            }
            if ((details != null) && (other.details == null))
            {
                return -1;
            }
            return 0;
        }
    }
}