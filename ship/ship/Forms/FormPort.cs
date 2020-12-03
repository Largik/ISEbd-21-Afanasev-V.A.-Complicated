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
        private void загрузитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (portCollection.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void сохранитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (portCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьПортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (portCollection.LoadPort(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьПортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxPorts.SelectedIndex > -1)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (portCollection.SavePort(saveFileDialog.FileName, listBoxPorts.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}