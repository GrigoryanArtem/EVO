using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVO.Tiles;
using Tao.OpenGl;

namespace EVO.Painters
{
    public class TemperatureTilePainter : ITilePainter
    {
        const double TILE_SIZE = 1.0;
        const double MAX_Temperature = 50;
        const double MIN_Temperature = -30;
        public void Draw(Tile tile)
        {
            SetColor(tile.Properties.Temperature);

            Gl.glBegin(Gl.GL_QUADS);

            Gl.glVertex2d(tile.Properties.Position.X, tile.Properties.Position.Y);
            Gl.glVertex2d(tile.Properties.Position.X + TILE_SIZE, tile.Properties.Position.Y);
            Gl.glVertex2d(tile.Properties.Position.X + TILE_SIZE, tile.Properties.Position.Y + TILE_SIZE);
            Gl.glVertex2d(tile.Properties.Position.X, tile.Properties.Position.Y + TILE_SIZE);

            Gl.glEnd();
        }

        void SetColor(double temperature)
        {
            if (temperature >= 0)
                PositiveTemperatureColor(temperature);
            else
                NegativeTemperatureColor(temperature);
        }

        void PositiveTemperatureColor(double temperature)
        {
            double value = temperature / MAX_Temperature;

            if (value > 1)
                value = 1;

            Gl.glColor3d(1, 1 - value, 1 - value);
        }

        void NegativeTemperatureColor(double temperature)
        {
            double value = temperature / MIN_Temperature;

            if (value > 1)
                value = 1;

            Gl.glColor3d(1 - value, 1 - value, 1);
        }
    }
}
