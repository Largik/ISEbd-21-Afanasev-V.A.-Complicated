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
        private Ship ship;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormShip()
        {
            InitializeComponent();
            comboBoxPipes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxFormCabin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxCabin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
        /// Обработка нажатия кнопки "Создать корабль"
        /// </summary>
        /// /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new DefaultShip(rnd.Next(1000, 3000), rnd.Next(10000, 50000), Color.Red, Color.Blue);
            ship.SetPosition(100, 100, pictureBoxShip.Width, pictureBoxShip.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать теплоход"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateMotorShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (comboBoxPipes.SelectedIndex > -1)
            {
                if (comboBoxFormCabin.SelectedIndex > -1)
                {
                    int fCabin;
                    string fCab = comboBoxFormCabin.SelectedItem.ToString();
                    if(fCab == "Квадратная")
                    {
                        fCabin = 2;
                    }
                    else
                    {
                        fCabin = 1;
                    }
                    if (comboBoxCabin.SelectedIndex > -1)
                    {
                        ship = new MotorShip(rnd.Next(100, 300), rnd.Next(1000, 2000), Convert.ToInt32(comboBoxPipes.SelectedItem.ToString()), fCabin, Convert.ToInt32(comboBoxCabin.SelectedItem.ToString()), Color.Purple,Color.Blue);
                        ship.SetPosition(200, 100, pictureBoxShip.Width,
                       pictureBoxShip.Height);
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Укажите количество кают");
                    }
                }
                else
                {
                    MessageBox.Show("Укажите форму кают");
                }
            }
            else
            {
                MessageBox.Show("Укажите количество труб");
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
