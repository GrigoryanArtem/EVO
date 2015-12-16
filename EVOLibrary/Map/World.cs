using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;
using EVO.Tiles;
using System.Drawing;
using EVO.Painters;
using System.Xml.Linq;
using EVOLibrary;

namespace EVO.Map
{
    public class World
    {
        private string _name;
        private IWorldPainter _painter;

        private Dictionary<Coordinate, Tile> _world = new Dictionary<Coordinate, Tile>();
        private int _width;
        private int _height;

        #region Constructors

        public World()
        {
            _width = 0;
            _height = 0;
            _painter = new WorldPainter();
        }

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
            _painter = new WorldPainter();
        }

        #endregion

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

        #region drawing functions
        public void Draw()
        {
            _painter.Draw(this);
        }

        public void Draw(IWorldPainter painter)
        {
            painter.Draw(this);
        }

        #endregion

        #region data exchange
        public void Save(string path)
        {
            XElement tiles = new XElement(Tags.TilesTag);

            foreach(var tile in _world)
            {
                XElement tileElement = new XElement(Tags.TileTag,
                    new XAttribute(Tags.NameTag, tile.Value.ToString()),
                    new XAttribute(Tags.XPositionTag, tile.Value.Properties.Position.X),
                    new XAttribute(Tags.YPositionTag, tile.Value.Properties.Position.Y));

                tiles.Add(tileElement);
            }

            XDocument saveFile = new XDocument(new XElement(Tags.WorldTag, 
                new XElement(Tags.PropertiesTag,
                    new XAttribute(Tags.NameTag, _name),
                    new XAttribute(Tags.WidthTag, _width),
                    new XAttribute(Tags.HeightTag, _height)), 
                tiles));

            saveFile.Save(path);
        }

        public void Load(string path)
        {
            _world.Clear();

            XDocument loadFile = XDocument.Load(path);

            XElement mainElement = loadFile.Element(Tags.WorldTag);
            XElement properties = mainElement.Element(Tags.PropertiesTag);

            _name = properties.Attribute(Tags.NameTag).Value;
            _width = Convert.ToInt32(properties.Attribute(Tags.WidthTag).Value);
            _height = Convert.ToInt32(properties.Attribute(Tags.HeightTag).Value);

            XElement tiles = mainElement.Element(Tags.TilesTag);

            foreach(var tile in tiles.Elements(Tags.TileTag))
            {
                Coordinate tileCoordinate = new Coordinate(Convert.ToDouble(tile.Attribute(Tags.XPositionTag).Value),
                    Convert.ToDouble(tile.Attribute(Tags.YPositionTag).Value));

                _world.Add(tileCoordinate, TilesManager.GetTile(tile.Attribute(Tags.NameTag).Value,
                    tileCoordinate));
            }
        }

        #endregion

        public override string ToString()
        {
            return _name;
        }

        public Tile GetTile(Coordinate position)
        {
            return _world[position];
        }

        public void Generation(IWorldGenerator generator)
        {
            _world = generator.Generate(Width, Height);
        }

        public void Normalize()
        {
            Coordinate[] neighbors = { new Coordinate(-1, 0), new Coordinate(1, 0),
                new Coordinate(0,  1), new Coordinate(0, -1), new Coordinate(0, 0),
                new Coordinate(1, 1), new Coordinate(-1,  1), new Coordinate(1, -1),
                new Coordinate(-1, -1)};

            foreach (var tile in _world)
            {
                List<Tile> temp = new List<Tile>();

                foreach (var coord in neighbors)
                    if (_world.ContainsKey(tile.Key + coord))
                        temp.Add(_world[tile.Key + coord]);

                tile.Value.Normalize(temp);
            }
        }
    }
}
