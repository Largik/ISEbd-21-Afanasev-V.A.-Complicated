using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ship
{
    public abstract class Ship : ITransport
    {
        /// <summary>
        /// Левая координата отрисовки корабля
        /// </summary>
        protected float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки корабля
        /// </summary>
        protected float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        protected int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        protected int _pictureHeight;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { protected set; get; }
        /// <summary>
        /// Вес корабля
        /// </summary>
        public float Weight { protected set; get; }
        /// <summary>
        /// Основной цвет 
        /// </summary>
        public Color MainColor { protected set; get; }
        /// <summary>
        /// Установка позиции корабля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public abstract void SetPosition(int x, int y, int width, int height);
        public abstract void DrawTransport(Graphics g);
        public abstract void MoveTransport(Direction direction);
    }
}