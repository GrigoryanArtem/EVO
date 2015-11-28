using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;
using EVO.Tiles;
using System.Drawing;
using EVO.Painters;
using System.Xml;

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
            XmlTextWriter textWritter = new XmlTextWriter(path, Encoding.UTF8);
            textWritter.WriteStartDocument();
            textWritter.WriteStartElement("world");
            textWritter.WriteEndElement();
            textWritter.Close();

            XmlDocument saveFile = new XmlDocument();
            saveFile.Load(path);

            XmlNode properties = saveFile.CreateElement("properties");
            saveFile.DocumentElement.AppendChild(properties);

            XmlAttribute name = saveFile.CreateAttribute("name");
            name.Value = _name;
            properties.Attributes.Append(name);

            XmlAttribute width = saveFile.CreateAttribute("width");
            width.Value = _width.ToString();
            properties.Attributes.Append(width);

            XmlAttribute height = saveFile.CreateAttribute("height");
            height.Value = _height.ToString();
            properties.Attributes.Append(height);

            XmlNode tiles = saveFile.CreateElement("tiles");
            saveFile.DocumentElement.AppendChild(tiles);

            foreach (var tile in _world)
            {
                XmlNode tileXml = saveFile.CreateElement("tile");
                tiles.AppendChild(tileXml);

                XmlAttribute positionX = saveFile.CreateAttribute("positionX");
                positionX.Value = tile.Key.X.ToString();
                tileXml.Attributes.Append(positionX);

                XmlAttribute positionY= saveFile.CreateAttribute("positionY");
                positionY.Value = tile.Key.Y.ToString();
                tileXml.Attributes.Append(positionY);

                XmlAttribute tileName = saveFile.CreateAttribute("name");
                tileName.Value = tile.Value.ToString();
                tileXml.Attributes.Append(tileName);
            }

            saveFile.Save(path);
        }

        public void Load(string path)
        {
            //TODO
        }
    }
}
