using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms_TShirt
{
    class TShirt
    {
        #region Public Properties

        public string Name { get; set; }
        public Color Color { get; }
        public Size Size { get; }
        public Fabric Fabric { get; }

        #endregion

        #region Constructors

        public TShirt(string name, Color color, Size size, Fabric fabric)
        {
            Name = name;
            Color = color;
            Size = size;
            Fabric = fabric;
        }

        #endregion
    }
}
