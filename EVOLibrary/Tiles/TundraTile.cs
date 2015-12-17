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
    public class TundraTile : Tile
    {
        public TundraTile(Tile tile)
            : this(new Coordinate(tile.Properties.Position))
        { }

        public TundraTile(Tile tile, Coordinate newCoordinate)
            : this(newCoordinate)
        { }

        public TundraTile(Coordinate position)
        {
            _painter = new TundraTilePainter();
            _name = MainStrings.TundraTileName;
            _properties = new TileProperties(0, 30, position, -20);
            _effects = new TilePropertiesForEffects();
        }

        public override Tile Copy()
        {
            return new TundraTile(this);
        }

        public override Tile Copy(Coordinate newCoordinate)
        {
            return new TundraTile(this, newCoordinate);
        }

        public override string ToString()
        {
            return MainStrings.TundraTileTitle;
        }
    }
}
