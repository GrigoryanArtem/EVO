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
        private int _numberOfSmoothing = 0;
        public RandomWorldGenerator(List<KeyValuePair<Tile, int>> tileList, int numberOfSmoothing)
        {
            if (numberOfSmoothing < 0)
                throw new Exception(EVOLibrary.ExceptionsStrings.SmoothingException);

            _numberOfSmoothing = numberOfSmoothing;
            _tileList = tileList;
            SetRealPriority();
        }

        public Dictionary<Coordinate, Tile> Generate(int width, int height)
        {
            Dictionary<Coordinate, int> map = new Dictionary<Coordinate, int>();
            Random rand = new Random();
            Coordinate tilePosition;

            for (int i = 0; i < width; i++)
            {
                for (int k = 0; k < height; k++)
                {
                    tilePosition = new Coordinate((double)i, (double)k);
                    map.Add(tilePosition, GetTileIdByPriority(rand.Next(100)));
                }
            }

            for (int i = 0; i < _numberOfSmoothing; i++)
                map = Smoothing(map);

            return FillTiles(map);
        }

        #region Auxiliary methods
        private int GetTileIdByPriority(int priority)
        {
            const int FAIL_ID = -1;
            int id = FAIL_ID;

            for (int i = 0; i < _tileList.Count; i++)
            {
                if (_tileList[i].Value >= priority)
                {
                    id = i;
                    break;
                }
            }

            if (id == FAIL_ID)
                id = _tileList.Count - 1;

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

            foreach (var tile in _tileList)
            {
                if (tile.Value < 0)
                    throw new Exception(EVOLibrary.ExceptionsStrings.TilePriorityException);

                fullValue += tile.Value;
            }

            // Real value = Old value * 100 / Old values sum
            for (int i = 0; i < _tileList.Count; i++)
                _tileList[i] = new KeyValuePair<Tile, int>(_tileList[i].Key, _tileList[i].Value * 100 / fullValue);

            _tileList.Sort(Compare);

            for (int i = 1; i < _tileList.Count; i++)
                _tileList[i] = new KeyValuePair<Tile, int>(_tileList[i].Key, _tileList[i].Value + _tileList[i - 1].Value);
        }

        private Dictionary<Coordinate, int> Smoothing(Dictionary<Coordinate, int> map)
        {
            Dictionary<Coordinate, int> newMap = new Dictionary<Coordinate, int>();
            Random rand = new Random();

            foreach (var tile in map) {
                int newTileKey = tile.Value;

                newTileKey = SmoothId(map, tile.Key);

                newMap.Add(tile.Key, newTileKey);
            }

            return newMap;
        }

        static private int Compare(KeyValuePair<Tile, int> a, KeyValuePair<Tile, int> b)
        {
            return a.Value.CompareTo(b.Value);
        }

        static private int Compare(KeyValuePair<int, int> a, KeyValuePair<int, int> b)
        {
            return a.Value.CompareTo(b.Value);
        }

        private int SmoothId(Dictionary<Coordinate, int> map, Coordinate idCoordinate)
        {
            Coordinate[] neighbors = { new Coordinate(-1, 0), new Coordinate(1, 0),
                new Coordinate(0,  1), new Coordinate(0, -1), new Coordinate(0, 0),
                new Coordinate(1, 1), new Coordinate(-1,  1), new Coordinate(1, -1),
                new Coordinate(-1, -1)};

            Dictionary<int, int> frequency = new Dictionary<int, int>();
            int NumberOfNeighbors = 0;

            foreach (var coord in neighbors)
            {
                if (!map.ContainsKey(idCoordinate + coord))
                    continue;

                int value = map[idCoordinate + coord];

                if (frequency.ContainsKey(value))
                    frequency[value]++;
                else
                    frequency[value] = 1;

                NumberOfNeighbors++;
            }

            List<KeyValuePair<int, int>> priorityList = new List<KeyValuePair<int, int>>();

            foreach (var temp in frequency)
                priorityList.Add(new KeyValuePair<int, int>(temp.Key, temp.Value * 100 / NumberOfNeighbors));


            priorityList.Sort(Compare);

            for (int i = 1; i < priorityList.Count; i++)
                priorityList[i] = new KeyValuePair<int, int>(priorityList[i].Key, 
                    priorityList[i].Value + priorityList[i - 1].Value);

            return GetSmoothTileIdByPriority(priorityList);
        }

        private int GetSmoothTileIdByPriority(List<KeyValuePair<int, int>> priorityList)
        {
            const int FAIL_ID = -1;
            int id = FAIL_ID;
            Random rand = new Random();
            int priority = rand.Next(100);

            for (int i = 0; i < priorityList.Count; i++)
            {
                if (priorityList[i].Value >= priority)
                {
                    id = priorityList[i].Key;
                    break;
                }
            }

            if (id == FAIL_ID)
                id = priorityList[priorityList.Count - 1].Key;

            return id;
        }

        #endregion
    }
}
