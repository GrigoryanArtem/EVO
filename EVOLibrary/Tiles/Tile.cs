using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Painters;
using System.Drawing;

namespace EVO.Tiles
{
    public abstract class Tile
    {
        protected string _name;
        protected IIntrinsicTileProperties _properties;
        protected ITilePainter _painter;

        public ITileProperties Properties
        {
            get
            {
                return (ITileProperties)_properties;
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
    }
}
