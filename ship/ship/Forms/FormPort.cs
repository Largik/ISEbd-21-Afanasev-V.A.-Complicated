using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ship
{
    public partial class FormPort : Form
    {
        /// <summary>
        /// Объект от класса-коллекции парковок
        /// </summary>
        private readonly PortCollection portCollection;
        private readonly Stack<Ship> _removeShip;
        public FormPort()
        {
            InitializeComponent();
            portCollection = new PortCollection(pictureBoxPort.Width, pictureBoxPort.Height);
            _removeShip = new Stack<Ship>();
        }
        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxPorts.SelectedIndex;
            listBoxPorts.Items.Clear();
            for (int i = 0; i < portCollection.Keys.Count; i++)
            {
                listBoxPorts.Items.Add(portCollection.Keys[i]);
            }
            if (listBoxPorts.Items.Count > 0 && (index == -1 || index >= listBoxPorts.Items.Count))
            {
                listBoxPorts.SelectedIndex = 0;
            }
            else if (listBoxPorts.Items.Count > 0 && index > -1 && index < listBoxPorts.Items.Count)
            {
                listBoxPorts.SelectedIndex = index;
            }
        }
        /// <summary>
        /// Метод отрисовки порта
        /// </summary>
        private void Draw()
        {
            if (listBoxPorts.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxPort.Width, pictureBoxPort.Height);
                Graphics gr = Graphics.FromImage(bmp);
                portCollection[listBoxPorts.SelectedItem.ToString()].Draw(gr);
                pictureBoxPort.Image = bmp;
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать теплоход"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void buttonCreateMotorShip_Click(object sender, EventArgs e)
        //{
        //    if (listBoxPorts.SelectedIndex > -1)
        //    {
        //        ColorDialog dialog = new ColorDialog();
        //        if (dialog.ShowDialog() == DialogResult.OK)
        //        {
        //            ColorDialog dialogDop = new ColorDialog();
        //            if (dialogDop.ShowDialog() == DialogResult.OK)
        //            {
        //                Random rnd = new Random();
        //                if (comboBoxPipes.SelectedIndex > -1)
        //                {
        //                    if (comboBoxFormPipes.SelectedIndex > -1)
        //                    {
        //                        int fPipes = 1;
        //                        string fCab = comboBoxFormPipes.SelectedItem.ToString();
        //                        if (fCab == "Квадратная")
        //                        {
        //                            fPipes = 2;
        //                        }
        //                        else if (fCab == "Треугольная")
        //                        {
        //                            fPipes = 3;
        //                        }
        //                        var ship = new MotorShip(100, 1000, Convert.ToInt32(comboBoxPipes.SelectedItem.ToString()), fPipes, dialog.Color, dialogDop.Color);
        //                        if (portCollection[listBoxPorts.SelectedItem.ToString()] + ship)
        //                        {
        //                            Draw();
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Порт переполнен");
        //                        }
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Укажите форму кают");
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Укажите количество труб");
        //                }

        //            }
        //        }
        //    }
        //}
        /// <summary>
        /// Обработка нажатия кнопки "забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeShipFromPort_Click_1(object sender, EventArgs e)
        {
            if (listBoxPorts.SelectedIndex > -1 && maskedTextBoxPlaceShip.Text != "")
            {
                var ship = portCollection[listBoxPorts.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlaceShip.Text);
                if (ship != null)
                {
                    _removeShip.Push(ship);
                }
                Draw();
            }
        }
        private void buttonAddPort_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            portCollection.AddPort(textBoxNewLevelName.Text);
            ReloadLevels();
        }
        private void buttonDeletePort_Click(object sender, EventArgs e)
        {
            if (listBoxPorts.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку { listBoxPorts.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    portCollection.DelPort(textBoxNewLevelName.Text);
                    ReloadLevels();
                    if (listBoxPorts.Items.Count <= 0)
                    {
                        pictureBoxPort.Image = null;
                    }
                }
            }
        }
        private void listBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        private void buttonTakeFromRemoved_Click(object sender, EventArgs e)
        {
            if (_removeShip.Count > 0)
            {
                if (_removeShip.Count > 0)
                {
                    FormShip form = new FormShip();
                    form.SetShip((Ship)_removeShip.Pop());
                    form.ShowDialog();
                }
            }
        }
        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            var formCarConfig = new FormShipConfig();
            formCarConfig.AddEvent(AddShip);
            formCarConfig.Show();
        }
        private void AddShip(Ship ship)
        {
            if (ship != null && listBoxPorts.SelectedIndex > -1)
            {
                if ((portCollection[listBoxPorts.SelectedItem.ToString()]) + ship)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Корабль не удалось поставить");
                }
            }
        }
    }
}