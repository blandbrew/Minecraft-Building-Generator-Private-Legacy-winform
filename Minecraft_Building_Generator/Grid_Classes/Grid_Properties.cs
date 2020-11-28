using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator.Grid_Classes
{
    public abstract class Grid_Properties
    {
        public Coordinate startCoordinate;
        public Coordinate endCoordinate;
        public Coordinate centerblock;

        public int padding;
        public int offset;
        public int margin;
        public bool isValid;

    }
}
