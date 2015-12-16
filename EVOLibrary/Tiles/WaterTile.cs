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
        public WaterTile(Tile tile) 
            : this(new Coordinate(tile.Properties.Position)){ }

        public WaterTile(Tile tile, Coordinate newCoordinate)
            : this(newCoordinate){ }

        public WaterTile(Coordinate position)
        {
            _painter = new WaterTilePainter();
            _name = MainStrings.WaterTileName;
            _properties = new TileProperties(100, 100, position, 17);
            _effects = new TilePropertiesForEffects();
        }

        public override Tile Copy()
        {
            return new WaterTile(this);
        }

        public override Tile Copy(Coordinate newCoordinate)
        {
            return new WaterTile(this, newCoordinate);
        }

        public override string ToString()
        {
            return MainStrings.WaterTileTitle;
        }
    }
}
