using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;
using EVO.Tiles;
using System.Drawing;
using EVO.Painters;

namespace EVO.Map
{
    public class World
    {
        private string _name;
        private IWorldPainter _painter;

        private Dictionary<Coordinate, Tile> _world = new Dictionary<Coordinate, Tile>();
        private int _width;
        private int _height;

        public World(int width, int height)
        {
            _width = width;
            _height = height;
            _painter = new WorldPainter();
        }

        public World(int width, int height,string name)
        {
            _name = name;
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

        public Dictionary<Coordinate, Tile> Map
        {
            get
            {
                return _world;
            }
        }

        #endregion

        public Tile GetTile(Coordinate position)
        {
            return _world[position];
        }

        public Bitmap Draw(int width, int height)
        {
            return _painter.Draw(this, width, height);
        }

        public void StaticGeneration(ISimpleWorldGenerator generator)
        {
            _world = generator.Generate(Width, Height);
        }
    }
}
