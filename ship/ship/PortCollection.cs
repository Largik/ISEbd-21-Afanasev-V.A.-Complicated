﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ship
{
    class PortCollection
    {
        readonly Dictionary<string, Port<Ship, IDetails>> portStages;
        public List<string> Keys => portStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public PortCollection(int pictureWidth, int pictureHeight)
        {
            portStages = new Dictionary<string, Port<Ship, IDetails>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        public void AddPort(string name)
        {
            if (portStages.ContainsKey(name))
            {
                return;
            }
            portStages.Add(name, new Port<Ship, IDetails>(pictureWidth, pictureHeight));
        }
        public void DelPort(string name)
        {
            if (portStages.ContainsKey(name))
            {
                portStages.Remove(name);
            }
        }
       public Port<Ship, IDetails> this[string ind]
        {
            get
            {
                if (portStages.ContainsKey(ind))
                {
                    return portStages[ind];
                }
                return null;
            }
       }
        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter streamWriter = new StreamWriter(filename, false, System.Text.Encoding.Default))
            {
                streamWriter.WriteLine("PortCollection");
                foreach (var level in portStages)
                {
                    streamWriter.WriteLine("Port" + separator + level.Key);

                    foreach (ITransport ship in level.Value)
                    {
                        if (ship != null)
                        {
                            if (ship.GetType().Name == "DefaultShip")
                            {
                                streamWriter.Write("DefaultShip" + separator);
                            }
                            if (ship.GetType().Name == "MotorShip")
                            {
                                streamWriter.Write("MotorShip" + separator);
                            }
                            streamWriter.WriteLine(ship);
                        }
                    }
                }
            }
        }
        public void SavePort(string filename,string key)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            if (portStages.ContainsKey(key))
            {
                using (StreamWriter streamWriter = new StreamWriter(filename, false, System.Text.Encoding.Default))
                {
                
                    streamWriter.WriteLine("Port" + separator + key);

                    foreach (ITransport ship in portStages[key])
                    {
                        if (ship != null)
                        {
                            if (ship.GetType().Name == "DefaultShip")
                            {
                                streamWriter.Write("DefaultShip" + separator);
                            }
                            if (ship.GetType().Name == "MotorShip")
                            {
                                streamWriter.Write("MotorShip" + separator);
                            }
                            streamWriter.WriteLine(ship);
                        }
                    }
                }
            }
        }
        public void LoadPort(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader streamReader = new StreamReader(filename, System.Text.Encoding.Default))
            {
                string line = streamReader.ReadLine();
                if (!line.Contains("Port" + separator))
                {
                    throw new FormatException();
                }
                string key = line.Split(separator)[1];
                if (portStages.ContainsKey(key))
                {
                    portStages[key].Clear();
                }
                else
                {
                    portStages.Add(key, new Port<Ship, IDetails>(pictureWidth, pictureHeight));
                }
                Ship ship = null;
                for (int i = 0; (line = streamReader.ReadLine()) != null; i++)
                {
                    if (line.Contains(separator))
                    {
                        if (line.Contains("MotorShip"))
                        {
                            ship = new MotorShip(line.Split(separator)[1]);
                        }
                        else if (line.Contains("DefaultShip"))
                        {
                            ship = new DefaultShip(line.Split(separator)[1]);
                        }
                        if (!(portStages[key] + ship))
                        {
                            throw new PortOverflowException();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader streamReader = new StreamReader(filename, System.Text.Encoding.Default))
            {
                if (streamReader.ReadLine().Contains("PortCollection"))
                {
                    portStages.Clear();
                }
                else
                {
                    throw new FormatException();
                }
                Ship ship = null;
                string key = string.Empty;
                string line;
                for (int i = 0; (line = streamReader.ReadLine()) != null; i++)
                {
                    if (line.Contains("Port"))
                    {
                        key = line.Split(separator)[1];
                        portStages.Add(key, new Port<Ship, IDetails>(pictureWidth, pictureHeight));
                    }
                    else if (line.Contains(separator))
                    {
                        if (line.Contains("DefaultShip"))
                        {
                            ship = new DefaultShip(line.Split(separator)[1]);
                        }
                        else if (line.Contains("MotorShip"))
                        {
                            ship = new MotorShip(line.Split(separator)[1]);
                        }

                        if (!(portStages[key] + ship))
                        {
                            throw new PortOverflowException();
                        }
                    }
                }
            }
        }
       public Ship this[string PortIndex, int placeIndex]
       {
            get
            {
                if (Keys.Contains(PortIndex))
                {
                    return portStages[PortIndex][placeIndex];
                }
                return null;
            }
       }
    }
}