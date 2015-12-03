using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Tiles;
using Tao.OpenGl;

namespace EVO.Painters
{
    public class PassabilityTilePainter : ITilePainter
    {
        const double TILE_SIZE = 1.0;
        const int MAX_Humidity = 100;
        public void Draw(Tile tile)
        {
            SetColor(tile.Properties.Humidity);

            Gl.glBegin(Gl.GL_QUADS);

            Gl.glVertex2d(tile.Properties.Position.X, tile.Properties.Position.Y);
            Gl.glVertex2d(tile.Properties.Position.X + TILE_SIZE, tile.Properties.Position.Y);
            Gl.glVertex2d(tile.Properties.Position.X + TILE_SIZE, tile.Properties.Position.Y + TILE_SIZE);
            Gl.glVertex2d(tile.Properties.Position.X, tile.Properties.Position.Y + TILE_SIZE);

            Gl.glEnd();
        }

        void SetColor(int humidity)
        {
            double value = (double)humidity / (double)MAX_Humidity;

            if (value > 1)
                value = 1;

            Gl.glColor3d(0.4, value, 0.7);
        }
    }
}
