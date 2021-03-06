﻿using System;
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

        public PlainTile(Tile tile, Coordinate newCoordinate)
            : this(newCoordinate){ }

        public PlainTile(Coordinate position)
        {
            _painter = new PlainTilePainter();
            _name = MainStrings.PlainTileName;
            _properties = new TileProperties(40, 80, position, 28);
            _effects = new TilePropertiesForEffects();
        }

        public override Tile Copy()
        {
            return new PlainTile(this);
        }

        public override Tile Copy(Coordinate newCoordinate)
        {
            return new PlainTile(this, newCoordinate);
        }

        public override string ToString()
        {
            return MainStrings.PlainTileTitle;
        }
    }
}
