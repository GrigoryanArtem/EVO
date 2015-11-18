using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVO.Tiles
{
    public abstract class Tile
    {
        protected IIntrinsicTileProperties _properties;

        public ITileProperties Properties
        {
            get
            {
                return (ITileProperties)_properties;
            }
        }
    }
}
