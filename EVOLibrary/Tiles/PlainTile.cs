using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;

namespace EVO.Tiles
{
    public class PlainTile : Tile
    {
        public PlainTile(Coordinate position)
        {
            _properties = new TileProperties(40, 80, position, 28);
        }
    }
}
