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
    public class SwamplandTile : Tile
    {
        public SwamplandTile(Tile tile)
            : this(new Coordinate(tile.Properties.Position))
        { }

        public SwamplandTile(Tile tile, Coordinate newCoordinate)
            : this(newCoordinate)
        { }

        public SwamplandTile(Coordinate position)
        {
            _painter = new SwamplandTilePainter();
            _name = MainStrings.SwamplandTileName;
            _properties = new TileProperties(100, 5, position, 18);
            _effects = new TilePropertiesForEffects();
        }

        public override Tile Copy()
        {
            return new SwamplandTile(this);
        }

        public override Tile Copy(Coordinate newCoordinate)
        {
            return new SwamplandTile(this, newCoordinate);
        }

        public override string ToString()
        {
            return MainStrings.SwamplandTileTitle;
        }
    }
}
