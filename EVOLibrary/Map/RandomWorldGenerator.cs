using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;
using EVO.Tiles;

namespace EVO.Map
{
    public class RandomWorldGenerator : IWorldGenerator
    {
        private List<KeyValuePair<Tile, int>> _tileList;
        public RandomWorldGenerator(List<KeyValuePair<Tile, int>> tileList)
        {
            _tileList = tileList;
            SetRealPriority();
        }

        public Dictionary<Coordinate, Tile> Generate(int width, int height)
        {
            Dictionary<Coordinate, int> map = new Dictionary<Coordinate, int>();
            Random rand = new Random();
            Coordinate tilePosition;

            for(int i = 0;i < width; i++)
            {
                for(int k = 0;k < height; k++)
                {
                    tilePosition = new Coordinate((double)i, (double)k);
                    map.Add(tilePosition, GetTileId(rand.Next(100)));
                }
            }

            return FillTiles(map);
        }

        private int GetTileId(int priority)
        {
            int id = -1;

            for(int i = 0; i < _tileList.Count; i++)
            {
                if (_tileList[i].Value >= priority)
                {
                    id = i;
                    break;
                }
            }

            if(id == -1)
                throw new Exception(EVOLibrary.ExceptionsStrings.TilePriorityException);

            return id;
        }

        private Dictionary<Coordinate, Tile> FillTiles(Dictionary<Coordinate, int> map)
        {
            Dictionary<Coordinate, Tile> realMap = new Dictionary<Coordinate, Tile>();

            foreach (var tile in map)
                realMap.Add(tile.Key, GetTileByID(tile.Value, tile.Key));

            return realMap;
        }
        
        private Tile GetTileByID(int id, Coordinate coordinate)
        {
            return _tileList[id].Key.Copy(coordinate);
        }

        private void SetRealPriority()
        {
            int fullValue = 0;

            foreach(var tile in _tileList)
            {
                if (tile.Value < 0)
                    throw new Exception(EVOLibrary.ExceptionsStrings.TilePriorityException);

                fullValue += tile.Value;
            }

            // Real value = Old value * 100 / Old values sum
            for (int i = 0; i < _tileList.Count;i++)
                _tileList[i] = new KeyValuePair<Tile, int>(_tileList[i].Key, _tileList[i].Value * 100 / fullValue);

            _tileList.Sort(Compare);

            for (int i = 1; i < _tileList.Count; i++)
                _tileList[i] = new KeyValuePair<Tile, int>(_tileList[i].Key, _tileList[i].Value + _tileList[i - 1].Value);
        }

        static private int Compare(KeyValuePair<Tile, int> a, KeyValuePair<Tile, int> b)
        {
            return a.Value.CompareTo(b.Value);
        }
    }
}
