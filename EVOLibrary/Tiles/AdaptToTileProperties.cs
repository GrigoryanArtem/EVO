using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;

namespace EVO.Tiles
{
    public class AdaptToTileProperties : ITileProperties
    {
        IIntrinsicTileProperties _properties;

        public AdaptToTileProperties(IIntrinsicTileProperties properties)
        {
            _properties = properties;
        }

        public int Humidity
        {
            get
            {
                return _properties.Humidity;
            }
        }

        public int Passability
        {
            get
            {
                return _properties.Passability;
            }
        }

        public Coordinate Position
        {
            get
            {
                return _properties.Position;
            }
        }

        public double Temperature
        {
            get
            {
                return _properties.Temperature;
            }
        }
    }
}
