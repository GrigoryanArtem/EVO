using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using EVO.Tiles;
using EVO.Parameters;
using EVO.Map;

namespace EVO.Painters
{
    public interface IWorldPainter
    {
        void Draw(World world);
    }
}
