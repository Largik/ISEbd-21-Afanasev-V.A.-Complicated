﻿using ship.DopForMotorShip;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ship
{
    public class MotorShip : DefaultShip
    {
        private IDetails details;
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
        public MotorShip(int maxSpeed, float weight, int pipe, int fPipes,  Color mainColor,
            Color dopColor) :
            base(maxSpeed, weight, mainColor, 120, 58)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            details = GetDetails(fPipes, pipe);
        }
        /// <summary>
        /// Отрисовка корабля
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            //Brush brush = new SolidBrush(MainColor);
            SolidBrush brWh = new SolidBrush(Color.White);
            details?.DrawDetails(g, _startPosX, _startPosY);
            base.DrawTransport(g);
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
        private IDetails GetDetails(int formPipe, int countPipe)
        {
            switch (formPipe)
            {
                case 1:
                    return new PipesDefault(countPipe);
                case 2:
                    return new PipeRectangle(countPipe);
                case 3:
                    return new PipeTriangle(countPipe);
            }
            return null;
        }
    }
}