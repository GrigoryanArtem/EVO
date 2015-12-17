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
    public class JungleTile : Tile
    {
        public JungleTile(Tile tile)
            : this(new Coordinate(tile.Properties.Position))
        { }

        public JungleTile(Tile tile, Coordinate newCoordinate)
            : this(newCoordinate)
        { }

        public JungleTile(Coordinate position)
        {
            _painter = new JungleTilePainter();
            _name = MainStrings.JungleTileName;
            _properties = new TileProperties(85, 20, position, 27);
            _effects = new TilePropertiesForEffects();
        }

        public override Tile Copy()
        {
            return new JungleTile(this);
        }

        public override Tile Copy(Coordinate newCoordinate)
        {
            return new JungleTile(this, newCoordinate);
        }

        public override string ToString()
        {
            return MainStrings.JungleTileTitle;
        }
    }
}
