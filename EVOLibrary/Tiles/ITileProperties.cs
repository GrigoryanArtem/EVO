using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;

namespace EVO.Tiles
{
    public interface ITileProperties
    {
        int Humidity { get; }

        int Passability { get; }

        Coordinate Position { get; }

        double Temperature { get; }
    }
}
