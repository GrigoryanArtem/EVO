using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using EVO.Tiles;
using EVOLibrary;
using Tao.OpenGl;

namespace EVO.Painters
{
    public class JungleTilePainter : ITilePainter
    {
        const double TILE_SIZE = 1.0;
        public void Draw(Tile tile)
        {
            Gl.glColor3d(0.28, 0.4, 0.24);
            Gl.glBegin(Gl.GL_QUADS);

            Gl.glVertex2d(tile.Properties.Position.X, tile.Properties.Position.Y);
            Gl.glVertex2d(tile.Properties.Position.X + TILE_SIZE, tile.Properties.Position.Y);
            Gl.glVertex2d(tile.Properties.Position.X + TILE_SIZE, tile.Properties.Position.Y + TILE_SIZE);
            Gl.glVertex2d(tile.Properties.Position.X, tile.Properties.Position.Y + TILE_SIZE);

            Gl.glEnd();
        }
    }
}
