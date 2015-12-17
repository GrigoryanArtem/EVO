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
using EVO.Painters;

namespace EVOGUI
{
    public partial class MainForm : Form
    {
        private const int START_COORDINATE = 0;

        private World _world;
        private IWorldPainter _worldPainter;
        private Tile _currentTile;

        public MainForm(World world)
        {
            InitializeComponent();
            _mainDrawingBox.InitializeContexts();
            _world = world;
            _worldPainter = new WorldPainter();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            CustomizeDrawingBox();
            Draw();
            _lWorldName.Text = _world.Name;
        }

        private void mainDrawingBoxMouseClick(object sender, MouseEventArgs e)
        {
            _currentTile = SelectTile(new Coordinate(e.X, e.Y));
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
            _world.Draw(_worldPainter);
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

        private void StdPainterClick(object sender, EventArgs e)
        {
            _worldPainter = new WorldPainter();
            Draw();
        }

        private void TemperaturePainterClick(object sender, EventArgs e)
        {
            _worldPainter = new TemperatureWorldPainter();
            Draw();
        }

        private void HumidityPainterClick(object sender, EventArgs e)
        {
            _worldPainter = new HumidityWorldPainter();
            Draw();
        }

        private void PassabilityPainterClick(object sender, EventArgs e)
        {
            _worldPainter = new PassabilityWorldPainter();
            Draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _timer.Enabled = !_timer.Enabled;
        }

        private void timerTick(object sender, EventArgs e)
        {
            _world.Normalize();
            Draw();
        }

        private void UpdateTileInfo()
        {
            _lPosition.Text = _currentTile.Properties.Position.ToString();
            _lTemperature.Text = _currentTile.Properties.Temperature.ToString();
            _lPassability.Text = _currentTile.Properties.Passability.ToString();
            _lHumidity.Text = _currentTile.Properties.Humidity.ToString();
        }
    }
}
