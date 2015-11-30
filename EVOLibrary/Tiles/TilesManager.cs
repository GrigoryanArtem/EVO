using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;

namespace EVO.Tiles
{
    public static class TilesManager
    {
        private static Tile[] _tilesList = {
            new DesertTile(new NullCoordinate()),
            new PlainTile(new NullCoordinate()),
            new ForestTile(new NullCoordinate()),
            new WaterTile(new NullCoordinate())
        };

        public static bool Check(string TileName)
        {
            foreach (var tile in _tilesList)
                if (tile.ToString() == TileName)
                    return true;

            return false;
        }

        public static Tile GetTile(string TileName, Coordinate position)
        {
            foreach (var tile in _tilesList)
                if (tile.ToString() == TileName)
                    return tile.Copy(position);

            throw new Exception(EVOLibrary.ExceptionsStrings.WrongTileType);
        }

        public static Tile[] GetTileList()
        {
            return _tilesList;
        }
    }
}
