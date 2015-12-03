using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Map;
using EVO.Parameters;
using EVO.Tiles;

namespace EVO.Painters
{
    public class TemperatureWorldPainter : IWorldPainter
    {
        public void Draw(World world)
        {
            CustomWorldPainter painter = new CustomWorldPainter(new TemperatureTilePainter());
            painter.Draw(world);
        }
    }
}
