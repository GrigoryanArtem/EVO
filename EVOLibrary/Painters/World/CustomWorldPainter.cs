using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Map;
using EVO.Tiles;
using EVO.Parameters;

namespace EVO.Painters
{
    public class CustomWorldPainter : IWorldPainter
    {
        ITilePainter _painter;

        public CustomWorldPainter(ITilePainter painter)
        {
            _painter = painter;
        }

        public void Draw(World world)
        {
            Dictionary<Coordinate, Tile> map = world.Map;

            foreach (var tile in map)
                tile.Value.Draw(_painter);
        }
    }
}
