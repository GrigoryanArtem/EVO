using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;
using EVOLibrary;

namespace EVO.Tiles
{
    public class DesertTile : Tile
    {
        public DesertTile(Coordinate position)
        {
            _name = MainStrings.DesertTileName;
            _properties = new TileProperties(0, 50, position, 40);
        }
    }
}
