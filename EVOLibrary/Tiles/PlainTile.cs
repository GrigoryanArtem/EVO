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
    public class PlainTile : Tile
    {
        public PlainTile(Tile tile) 
            : this(new Coordinate(tile.Properties.Position)){ }

        public PlainTile(Coordinate position)
        {
            _painter = new PlainTilePainter();
            _name = MainStrings.PlainTileName;
            _properties = new TileProperties(40, 80, position, 28);
        }

        public override Tile Copy()
        {
            return new PlainTile(this);
        }
    }
}
