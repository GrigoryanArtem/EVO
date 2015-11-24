using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using EVO.Tiles;
using EVO.Parameters;
using EVOLibrary;
using EVO.Map;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace EVO.Painters
{
    public class WorldPainter : IWorldPainter
    {
        public void Draw(World world)
        {
            Dictionary<Coordinate, Tile> map = world.Map;

            foreach (var tile in map)
                tile.Value.Draw();
        }
    }
}
