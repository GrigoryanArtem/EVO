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
        public ForestTile(Tile tile) 
            : this(new Coordinate(tile.Properties.Position)){ }

        public ForestTile(Tile tile, Coordinate newCoordinate)
            : this(newCoordinate){ }

        public ForestTile(Coordinate position)
        {
            _painter = new ForestTilePainter();
            _name = MainStrings.ForestTileName;
            _properties = new TileProperties(75, 25, position, 20);
            _effects = new TilePropertiesForEffects();
        }

        public override Tile Copy()
        {
            return new ForestTile(this);
        }

        public override Tile Copy(Coordinate newCoordinate)
        {
            return new ForestTile(this, newCoordinate);
        }

        public override string ToString()
        {
            return MainStrings.ForestTileTitle;
        }
    }
}
