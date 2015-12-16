using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Painters;
using System.Drawing;
using EVO.Parameters;

namespace EVO.Tiles
{
    public abstract class Tile
    {
        private const double NORMOLIZE_CONST = 2d;
        private const double SELF_NORMOLIZE_CONST = 10d;

        protected string _name;
        protected IIntrinsicTileProperties _properties;
        protected IIntrinsicTileProperties _effects;
        protected ITilePainter _painter;


        public ITileProperties Effects
        {
            get
            {
                return new AdaptToTileProperties(_effects);
            }
        }

        public ITileProperties Properties
        {
            get
            {
                return new AdaptToTileProperties(_properties.Add(_effects));
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public void Draw()
        {
            _painter.Draw(this);
        }

        public void Draw(ITilePainter painter)
        {
            painter.Draw(this);
        }

        public void Normalize(List<Tile> tiles)
        {
            SelfNormalize();

            double temperatureAverage = Properties.Temperature;
            int humidityAverage = Properties.Humidity;
            int numberOfTiles = tiles.Count + 1;

            foreach (var tile in tiles)
            {
                temperatureAverage += tile.Properties.Temperature;
                humidityAverage += tile.Properties.Humidity;
            }   

            temperatureAverage /= numberOfTiles;
            humidityAverage /= numberOfTiles;

            _effects.Temperature += (temperatureAverage - Properties.Temperature) / NORMOLIZE_CONST;
            _effects.Humidity += (int)(((double)humidityAverage - (double)Properties.Humidity) / NORMOLIZE_CONST);
        }

        private void SelfNormalize()
        {
            double temperatureDifference = (_properties.Temperature - Properties.Temperature) / SELF_NORMOLIZE_CONST;
            _effects.Temperature += temperatureDifference;

            int humidityDifference = (int)(((double)_properties.Humidity - (double)Properties.Humidity) / SELF_NORMOLIZE_CONST);
            _effects.Temperature += humidityDifference;
        }

        abstract public Tile Copy();

        abstract public Tile Copy(Coordinate newCoordinate);
    }
}
