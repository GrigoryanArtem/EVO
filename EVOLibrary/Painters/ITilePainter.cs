using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using EVO.Tiles;

namespace EVO.Painters
{
    public interface ITilePainter
    {
        Bitmap Draw();
    }
}
