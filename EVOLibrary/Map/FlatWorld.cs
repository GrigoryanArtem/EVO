using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Parameters;
using EVO.Tiles;

namespace EVO.Map
{
    public class FlatWorld : ISimpleWorldGenerator
    {
        public Dictionary<Coordinate, Tile> Generate(int width, int height)
        {
            Dictionary<Coordinate, Tile> world = new Dictionary<Coordinate, Tile>();

            for (int x = 0;x < width; x++)
            {
                for(int y = 0;y < height; y++)
                {
                    Coordinate tileCoordinate = new Coordinate((double)x, (double)y);
                    world.Add(tileCoordinate, new PlainTile(tileCoordinate));
                }
            }

            return world;
        }
    }
}
