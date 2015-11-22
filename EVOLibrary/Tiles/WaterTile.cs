using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;
using EVOLibrary;
using EVO.Painters;

namespace EVO.Tiles
{
    public class WaterTile : Tile
    {
        public WaterTile(Coordinate position)
        {
            _painter = new WaterTilePainter();
            _name = MainStrings.WaterTileName;
            _properties = new TileProperties(100, 100, position, 17);
        }
    }
}
