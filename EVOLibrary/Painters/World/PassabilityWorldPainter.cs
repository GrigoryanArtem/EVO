using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Tiles;
using EVO.Parameters;
using EVOLibrary;
using EVO.Map;

namespace EVO.Painters
{
    public class PassabilityWorldPainter : IWorldPainter
    {
        public void Draw(World world)
        {
            CustomWorldPainter painter = new CustomWorldPainter(new PassabilityTilePainter());
            painter.Draw(world);
        }
    }
}
