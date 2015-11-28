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

        public void Draw()
        {
            _painter.Draw(this);
        }

        public void Generation(IWorldGenerator generator)
        {
            _world = generator.Generate(Width, Height);
        }

        public void Save(string path)
        {
            XElement tiles = new XElement(MainStrings.TilesTagName);

            foreach(var tile in _world)
            {
                XElement tileElement = new XElement(MainStrings.TileTagName,
                    new XAttribute(MainStrings.NameAttributeName, tile.Value.ToString()),
                    new XAttribute(MainStrings.PositionXAttributeName, tile.Value.Properties.Position.X),
                    new XAttribute(MainStrings.PositionYAttributeName, tile.Value.Properties.Position.Y));

                tiles.Add(tileElement);
            }

            XDocument saveFile = new XDocument(new XElement(MainStrings.MainTagName, 
                new XElement(MainStrings.PropertiesTagName,
                    new XAttribute(MainStrings.NameAttributeName, _name),
                    new XAttribute(MainStrings.WidthAttributeName, _width),
                    new XAttribute(MainStrings.HeightAttributeName, _height)), 
                tiles));

            saveFile.Save(path);
        }

        public void Load(string path)
        {
            _world.Clear();

            XDocument loadFile = XDocument.Load(path);

            XElement mainElement = loadFile.Element(MainStrings.MainTagName);
            XElement properties = mainElement.Element(MainStrings.PropertiesTagName);

            _name = properties.Attribute(MainStrings.NameAttributeName).Value;
            _width = Convert.ToInt32(properties.Attribute(MainStrings.WidthAttributeName).Value);
            _height = Convert.ToInt32(properties.Attribute(MainStrings.HeightAttributeName).Value);

            XElement tiles = mainElement.Element(MainStrings.TilesTagName);

            foreach(var tile in tiles.Elements(MainStrings.TileTagName))
            {
                Coordinate tileCoordinate = new Coordinate(Convert.ToDouble(tile.Attribute(MainStrings.PositionXAttributeName).Value),
                    Convert.ToDouble(tile.Attribute(MainStrings.PositionYAttributeName).Value));

                _world.Add(tileCoordinate, TilesManager.GetTile(tile.Attribute(MainStrings.NameAttributeName).Value,
                    tileCoordinate));
            }
        }
    }
}
