using NLog;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        private readonly Logger logger;
        public FormPort()
        {
            InitializeComponent();
            portCollection = new PortCollection(pictureBoxPort.Width, pictureBoxPort.Height);
            _removeShip = new Stack<Ship>();
            logger = LogManager.GetCurrentClassLogger();
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
                try
                {
                    var ship = portCollection[listBoxPorts.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlaceShip.Text);
                    if (ship != null)
                    {
                        _removeShip.Push(ship);
                        logger.Info($"Изъят корабль {ship} с места { maskedTextBoxPlaceShip.Text} ");
                        Draw();
                    }
                }
                catch (PortNotFoundException ex)
                {
                    logger.Warn($"Корабль {maskedTextBoxPlaceShip.Text} не найден");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Fatal($"Корабль {maskedTextBoxPlaceShip.Text} не найден");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            logger.Info($"Добавили порт {textBoxNewLevelName.Text}");
            portCollection.AddPort(textBoxNewLevelName.Text);
            ReloadLevels();
        }
        private void buttonDeletePort_Click(object sender, EventArgs e)
        {
            if (listBoxPorts.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку { listBoxPorts.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили порт { listBoxPorts.SelectedItem.ToString()} ");
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
            logger.Info($"Перешли на порт { listBoxPorts.SelectedItem.ToString()}");
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
                try
                {
                    if ((portCollection[listBoxPorts.SelectedItem.ToString()]) + ship)
                    {
                        Draw();
                    }
                }
                catch (PortOverflowException ex)
                {
                    logger.Warn($"Порт {listBoxPorts.SelectedItem.ToString()} переполнен");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Fatal("Корабль не поставлен");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void загрузитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    portCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (PortOverflowException ex)
                {
                    logger.Warn($"Порт {listBoxPorts.SelectedItem.ToString()} переполнен");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FileNotFoundException ex)
                {
                    logger.Error($"Порт {listBoxPorts.SelectedItem.ToString()} не загружен, не найден файл");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException ex)
                {
                    logger.Error($"Порт {listBoxPorts.SelectedItem.ToString()} не загружен, не вервый формат файла");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Fatal("Не загружено");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void сохранитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    portCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Fatal("Не сохранено");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьПортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    portCollection.LoadPort(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                    logger.Info("Порт загружен из файла " + openFileDialog.FileName);
                }
                catch (PortOverflowException ex)
                {
                    logger.Warn($"Порт {listBoxPorts.SelectedItem.ToString()} переполнен");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(FileNotFoundException ex)
                {
                    logger.Error($"Порт {listBoxPorts.SelectedItem.ToString()} не загружен, не найден файл");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(FormatException ex)
                {
                    logger.Error($"Порт {listBoxPorts.SelectedItem.ToString()} не загружен, не вервый формат файла");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Fatal("Не загружено");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьПортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxPorts.SelectedIndex > -1)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        portCollection.SavePort(saveFileDialog.FileName, listBoxPorts.SelectedItem.ToString());
                        MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        logger.Info("Порт сохранен в файл " + saveFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        logger.Fatal("Не сохранено");
                        MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            if (listBoxPorts.SelectedIndex > -1)
            {
                portCollection[listBoxPorts.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }
}