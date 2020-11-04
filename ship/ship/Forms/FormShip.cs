using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ship
{
    public partial class FormShip : Form
    {
        private ITransport ship;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormShip()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Передача корабля на форму
        /// </summary>
        /// <param name="ship"></param>
        public void SetShip(ITransport ship)
        {
            this.ship = ship;
            Draw();
        }
        /// <summary>
        /// Метод отрисовки Корабля
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ship?.DrawTransport(gr);
            pictureBoxShip.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    ship.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    ship.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    ship.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    ship.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}