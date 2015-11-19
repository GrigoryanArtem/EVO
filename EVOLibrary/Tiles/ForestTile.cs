using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;

namespace EVO.Tiles
{
    public class ForestTile : Tile
    {
        public ForestTile(Coordinate position)
        {
            _properties = new TileProperties(75, 25, position, 20);
        }
    }
}
