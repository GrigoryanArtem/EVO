using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using EVO.Tiles;
using EVOLibrary;

namespace EVO.Painters
{
    public class DesertTilePainter : ITilePainter
    {
        private const int IMAGE_SIZE = 256;

        public Bitmap Draw()
        {
            Bitmap image = new Bitmap(IMAGE_SIZE, IMAGE_SIZE);

            image = Textures.DesertTileTexture;

            return image;
        }
    }
}
