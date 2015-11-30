using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.Platform.Windows;
using EVO.Map;
using EVO.Tiles;
using EVO.Parameters;

namespace EVOGUI
{
    public partial class MainForm : Form
    {
        private const int START_COORDINATE = 0;

        private World _world;

        public MainForm(World world)
        {
            InitializeComponent();
            _mainDrawingBox.InitializeContexts();
            _world = world;
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            CustomizeDrawingBox();
            Draw();
        }

        private void mainDrawingBoxMouseClick(object sender, MouseEventArgs e)
        {
            _lTileName.Text = SelectTile(new Coordinate(e.X, e.Y)).Name;
        }

        #region Painters Function

        private void CustomizeDrawingBox()
        {
            Gl.glClearColor(255, 255, 255, 1);

            Gl.glViewport(START_COORDINATE, START_COORDINATE, _mainDrawingBox.Width, _mainDrawingBox.Height);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            Glu.gluOrtho2D(START_COORDINATE, _world.Width, START_COORDINATE, _world.Height);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);

            Gl.glLoadIdentity();
        }

        private void mainBoxSizeChanged(object sender, EventArgs e)
        {
            CustomizeDrawingBox();
            Draw();
        }

        private void Draw()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            _world.Draw();
            _mainDrawingBox.Invalidate();
        }

        #endregion

        #region function to select tile

        private Coordinate ToRealCoordinate(Coordinate mouseCoordinate)
        {
            mouseCoordinate.Y = _mainDrawingBox.Height - mouseCoordinate.Y;

            double temp = mouseCoordinate.Y * 100 / _mainDrawingBox.Height;
            mouseCoordinate.Y = (int)(temp * _world.Height / 100);

            temp = mouseCoordinate.X * 100 / _mainDrawingBox.Width;
            mouseCoordinate.X = (int)(temp * _world.Width / 100);

            return mouseCoordinate;
        }

        private Tile SelectTile(Coordinate mouseCoordinate)
        {
            return _world.GetTile(ToRealCoordinate(mouseCoordinate));
        }

        #endregion
    }
}
