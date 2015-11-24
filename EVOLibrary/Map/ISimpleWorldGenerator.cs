using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;
using EVO.Tiles;

namespace EVO.Map
{
    public interface ISimpleWorldGenerator
    {
        Dictionary<Coordinate, Tile> Generate(int width, int height);
    }
}
