using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EVO.Map;
using EVO.Tiles;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace EVOGUI
{
    public partial class SettingsForm : Form
    {
        private const int START_COORDINATE = 0;

        private World _world;
        private List<KeyValuePair<Tile, int>> tileList = new List<KeyValuePair<Tile, int>>();
        private LauncherForm _parentForm;

        public SettingsForm(LauncherForm parentForm)
        {
            InitializeComponent();
            _preGenPictureBox.InitializeContexts();
            _world = new World();
            _parentForm = parentForm;
        }

        private void GenerateClick(object sender, EventArgs e)
        {
            try {
                _world = new World(Convert.ToInt32(_tbWidth.Text), Convert.ToInt32(_tbHeight.Text), _tbName.Text);

                _world.Generation(new RandomWorldGenerator(tileList, Convert.ToInt32(_cbSmoothing.Text)));

                CustomizeDrawingBox();
                Draw();

                _bSave.Enabled = true;
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomizeDrawingBox()
        {
            Gl.glClearColor(255, 255, 255, 1);

            Gl.glViewport(START_COORDINATE, START_COORDINATE, _preGenPictureBox.Width, _preGenPictureBox.Height);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            Glu.gluOrtho2D(START_COORDINATE, _world.Width, START_COORDINATE, _world.Height);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);

            Gl.glLoadIdentity();
        }

        private void Draw()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            _world.Draw();
            _preGenPictureBox.Invalidate();
        }

        private void SettingsFormLoad(object sender, EventArgs e)
        {
            FillAllList();
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            try {
                tileList.Add(new KeyValuePair<Tile, int>(TilesManager.GetTile(_lbAllTiles.SelectedItem.ToString(),
                    new EVO.Parameters.NullCoordinate()), Convert.ToInt32(_tbPriority.Text)));
                _lbTilesInWorld.Items.Add(String.Format("{0} ({1})",_lbAllTiles.SelectedItem.ToString(), _tbPriority.Text));
                _lbAllTiles.Items.Remove(_lbAllTiles.SelectedItem);
                _tbPriority.Clear();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bClearClick(object sender, EventArgs e)
        {
            tileList.Clear();
            _lbAllTiles.Items.Clear();
            _lbTilesInWorld.Items.Clear();
            FillAllList();
        }

        private void FillAllList()
        {
            foreach (var tile in TilesManager.GetTileList())
                _lbAllTiles.Items.Add(tile.ToString());
        }

        private void SaveClick(object sender, EventArgs e)
        {
            WorldsDataBase worldsDB = WorldsDataBase.Instance;
            worldsDB.Add(_world, @"Data\worlds\");

            _parentForm.UpdateWorldList();
        }
        private bool CheckChar(char symbol)
        {
            return !char.IsDigit(symbol) && !char.IsControl(symbol);
        }

        private void tbKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckChar(e.KeyChar);
        }
    }
}
