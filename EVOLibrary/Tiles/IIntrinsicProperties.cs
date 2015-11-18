using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;

namespace EVO.Tiles
{
    interface IIntrinsicProperties
    {
        int Humidity { set; get; }

        int Passability { set; get; }

        Coordinate Position { set; get; }

        int Temperature { set; get; }
    }
}
