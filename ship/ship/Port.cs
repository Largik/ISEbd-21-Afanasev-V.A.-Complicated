using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ship
{
    /// <summary>
    /// Параметризованный класс для хранения набора объектов от интерфейса ITransport
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Port<T, A> where T : class, ITransport where A: class, IDetails
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private readonly T[] _places;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int _pictureHeight;
        /// <summary>
        /// Размер парковочного места (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 210;
        /// <summary>
        /// Размер парковочного места (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 120;
        /// <summary>
        /// Свободные места
        /// </summary>
        private readonly int _column;
        /// <summary>
        /// Координата X для следующего
        /// </summary>
        public int XShip { get; private set; } = 5;
        /// <summary>
        /// Координата Y для следующего
        /// </summary>
        public int YShip { get; private set; } = 50;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Размер порта - ширина</param>
        /// <param name="picHeight">Размер порта - высота</param>
        public Port(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _column = height;
            _places = new T[width * height];
            _pictureWidth = picWidth;
            _pictureHeight = picHeight;
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: на парковку добавляется корабль
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="ship">Добавляемый корабль</param>
        /// <returns></returns>
        public static bool operator +(Port<T, A> Port, T ship)
        {
            for (int index = 0; index < Port._places.Length; index++)
            {
                if (Port._places[index] == null)
                {
                    Port._places[index] = ship;
                    ship.SetPosition(index / Port._column * Port._placeSizeWidth + 5, 50 + index % Port._column * Port._placeSizeHeight,
                    Port._pictureWidth, Port._pictureHeight);
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с парковки забираем корабль
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
        /// <returns></returns>
        public static T operator -(Port<T, A> Port, int index)
        {
            if (index >= 0 && index < Port._places.Length)
            {
                T ship = Port._places[index];
                Port._places[index] = null;
                return ship;
            }
            else
            {
                return null;
            }
        }
        public static bool operator >(Port<T, A> Port, int count)
        {
            int placeCount = 0;
            for (int i = 0; i < Port._places.Length; i++)
            {
                if (Port._places[i] != null)
                {
                    placeCount++;
                }
            }
            if (placeCount > count)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Port<T, A> Port, int count)
        {
            int placeCount = 0;
            for (int i = 0; i < Port._places.Length; i++)
            {
                if (Port._places[i] != null)
                {
                    placeCount++;
                }
            }
            if (placeCount < count)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < _pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < _pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия разметки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (_pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}