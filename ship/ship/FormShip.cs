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
        private DefaultShip ship;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormShip()
        {
            InitializeComponent();
            comboBoxPipes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        /// <summary>
        /// Метод отрисовки Корабля
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ship.DrawTransport(gr);
            pictureBoxShip.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (comboBoxPipes.SelectedIndex > -1)
            {
                ship = new DefaultShip(rnd.Next(1000, 3000), rnd.Next(10000, 50000), Convert.ToInt32(comboBoxPipes.SelectedItem.ToString()), Color.Red, Color.Blue, true, true);
                ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxShip.Width, pictureBoxShip.Height);
                Draw();        
            }
            else
            {
                MessageBox.Show("Выберете количество труб");
            }
           
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
