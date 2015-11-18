using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;

namespace EVO.Tiles
{
    class TileProperties : ITileProperties, IIntrinsicProperties
    {
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
                if (value < 0 || value > 100)
                    throw new Exception();

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
                if (value < 0 || value > 100)
                    throw new Exception();

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
                if (value < 273)
                    throw new Exception();

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
