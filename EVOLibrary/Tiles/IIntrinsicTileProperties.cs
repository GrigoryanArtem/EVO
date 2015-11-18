using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;

namespace EVO.Tiles
{
    public interface IIntrinsicTileProperties
    {
        int Humidity { set; get; }

        int Passability { set; get; }

        Coordinate Position { set; get; }

        int Temperature { set; get; }
    }
}
