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
    public class MountainsTile : Tile
    {
        public MountainsTile(Tile tile)
            : this(new Coordinate(tile.Properties.Position))
        { }

        public MountainsTile(Tile tile, Coordinate newCoordinate)
            : this(newCoordinate)
        { }

        public MountainsTile(Coordinate position)
        {
            _painter = new MountainsTilePainter();
            _name = MainStrings.MountainsTileName;
            _properties = new TileProperties(10, 50, position, 5);
            _effects = new TilePropertiesForEffects();
        }

        public override Tile Copy()
        {
            return new MountainsTile(this);
        }

        public override Tile Copy(Coordinate newCoordinate)
        {
            return new MountainsTile(this, newCoordinate);
        }

        public override string ToString()
        {
            return MainStrings.MountainsTileTitle;
        }
    }
}
