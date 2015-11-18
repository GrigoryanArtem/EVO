using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;
using EVOLibrary;

namespace EVO.Tiles
{
    public class TileProperties : ITileProperties, IIntrinsicTileProperties
    {
        #region constants

        private const int MIN_TEMPERATURE = -273;
        private const int MIN_PASSABIILITY = 0;
        private const int MAX_PASSABIILITY = 100;
        private const int MIN_HUMIDITY = 0;
        private const int MAX_HUMIDITY = 100;

        #endregion

        private int _humidity;
        private int _passability;
        private Coordinate _position;
        private int _temperature;

        
        public TileProperties()
        {
            Humidity = 0;
            Passability = 0;
            Position = new NullCoordinate();
            Temperature = 0;
        }

        public TileProperties(int humidity, int passability, Coordinate position, int temperature)
        {
            Humidity = humidity;
            Passability = passability;
            Position = position;
            Temperature = temperature;
        }

        #region auto implemented properties

        public int Humidity {
            set
            {
                if (value < MIN_HUMIDITY || value > MAX_HUMIDITY)
                    throw new Exception(ExceptionsStrings.HumidityException);

                _humidity = value;
            }

            get
            {
                return _humidity;
            }
        }

        public int Passability {
            set
            {
                if (value < MIN_PASSABIILITY || value > MAX_PASSABIILITY)
                    throw new Exception(ExceptionsStrings.PassabilityException);

                _passability = value;
            }

            get
            {
                return _passability;
            }
        }

        public Coordinate Position {
            set
            {
                _position = value;
            }
            get
            {
                return _position;
            }
        }

        public int Temperature {
            set
            {
                if (value < MIN_TEMPERATURE)
                    throw new Exception(ExceptionsStrings.TemperatureException);

                _temperature = value;
            }
            get
            {
                return _temperature;
            }
        }

        #endregion
    }
}
