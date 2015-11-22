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
    public class ForestTile : Tile
    {
        public ForestTile(Coordinate position)
        {
            _painter = new ForestTilePainter();
            _name = MainStrings.ForestTileName;
            _properties = new TileProperties(75, 25, position, 20);
        }
    }
}
