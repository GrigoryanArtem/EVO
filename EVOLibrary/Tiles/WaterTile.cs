using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;
using EVOLibrary;

namespace EVO.Tiles
{
    public class WaterTile : Tile
    {
        public WaterTile(Coordinate position)
        {
            _name = MainStrings.WaterTileName;
            _properties = new TileProperties(100, 100, position, 17);
        }
    }
}
