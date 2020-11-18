using System;
using System.Collections.Generic;
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