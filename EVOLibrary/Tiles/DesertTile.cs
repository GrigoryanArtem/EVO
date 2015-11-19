using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;

namespace EVO.Tiles
{
    public class DesertTile : Tile
    {
        public DesertTile(Coordinate position)
        {
            _properties = new TileProperties(0, 50, position, 40);
        }
    }
}
