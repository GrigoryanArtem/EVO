using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;
using EVOLibrary;
using EVO.Painters;

namespace EVO.Tiles
{
    class TilePropertiesForEffects : IIntrinsicTileProperties, ITileProperties
    {
        private int _humidity;
        private int _passability;
        private Coordinate _position;
        private double _temperature;

        #region constructors
        public TilePropertiesForEffects()
        {
            Humidity = 0;
            Passability = 0;
            Position = new NullCoordinate();
            Temperature = 0;
        }

        public TilePropertiesForEffects(int humidity, int passability, Coordinate position, double temperature)
        {
            Humidity = humidity;
            Passability = passability;
            Position = position;
            Temperature = temperature;
        }

        public TilePropertiesForEffects(ITileProperties tileProperties)
        {
            Humidity = tileProperties.Humidity;
            Passability = tileProperties.Passability;
            Position = new Coordinate(tileProperties.Position);
            Temperature = tileProperties.Temperature;
        }

        public TilePropertiesForEffects(IIntrinsicTileProperties tileProperties)
        {
            Humidity = tileProperties.Humidity;
            Passability = tileProperties.Passability;
            Position = new Coordinate(tileProperties.Position);
            Temperature = tileProperties.Temperature;
        }

        #endregion

        #region auto implemented properties

        public int Humidity
        {
            set
            {
                _humidity = value;
            }

            get
            {
                return _humidity;
            }
        }

        public int Passability
        {
            set
            {
                _passability = value;
            }

            get
            {
                return _passability;
            }
        }

        public Coordinate Position
        {
            set
            {
                _position = value;
            }
            get
            {
                return _position;
            }
        }

        public double Temperature
        {
            set
            {
                _temperature = value;
            }
            get
            {
                return _temperature;
            }
        }

        #endregion

        public IIntrinsicTileProperties Add(IIntrinsicTileProperties properties)
        {
            return new TilePropertiesForEffects(Humidity + properties.Humidity, Passability + properties.Passability,
                Position, Temperature + properties.Temperature);
        }
    }
}
