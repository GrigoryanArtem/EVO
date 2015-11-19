using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;
using EVO.Tiles;

namespace EVO.Map
{
    public class World
    {
        private string _name;

        private Dictionary<Coordinate, Tile> _world;
        private int _width;
        private int _height;

        public World(int width, int height)
        {
            _width = width;
            _height = height;
        }

        #region Auto implemented properties

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
        }

        #endregion

        public void AddTile(Coordinate position, Tile tile)
        {
            _world.Add(position, tile);
        }

        public Tile GetTile(Coordinate position)
        {
            return _world[position];
        }
    }
}
