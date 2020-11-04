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
    public partial class FormPort : Form
    {
        /// <summary>
        /// Объект от класса-порта
        /// </summary>
        private readonly Port<DefaultShip, DopDetails> _port;
        public FormPort()
        {
            InitializeComponent();
            _port = new Port<DefaultShip, DopDetails>(pictureBoxPort.Width, pictureBoxPort.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки порта
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxPort.Width, pictureBoxPort.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _port.Draw(gr);
            pictureBoxPort.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать корабль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var boat = new DefaultShip(100, 1000, dialog.Color);
                boat.SetPosition(_port.XShip, _port.YShip, pictureBoxPort.Width, pictureBoxPort.Height);
                if (_port + boat)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Порт переполнен");
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать теплоход"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateMotorShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    Random rnd = new Random();
                    if (comboBoxPipes.SelectedIndex > -1)
                    {
                        if (comboBoxFormCabin.SelectedIndex > -1)
                        {
                            int fCabin;
                            string text = comboBoxFormCabin.Text;
                            if (text == "Квадратная")
                            {
                                fCabin = 2;
                            }
                            else
                            {
                                fCabin = 1;
                            }

                            if (comboBoxCabin.SelectedIndex > -1)
                            {
                                var mBoat = new MotorShip(rnd.Next(100, 300), rnd.Next(1000, 2000), Convert.ToInt32(comboBoxPipes.SelectedItem.ToString()), fCabin, Convert.ToInt32(comboBoxCabin.SelectedItem.ToString()), dialog.Color, dialogDop.Color);
                                if (_port + mBoat)
                                {
                                    Draw();
                                }
                                else
                                {
                                    MessageBox.Show("Порт переполнен");
                                }
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
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(maskedTextBoxPlaceShip.Text))
            {
                int index = Convert.ToInt32(maskedTextBoxPlaceShip.Text);
                var ship = _port - index;

                if (ship != null)
                {
                    FormShip form = new FormShip();
                    form.SetShip(ship);
                    form.ShowDialog();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Место в порту с данным индексом пустое");
                }
            }
        }
    }
}