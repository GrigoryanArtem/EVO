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
    public partial class LauncherForm : Form
    {
        private WorldsDataBase worldsDB;
        public LauncherForm()
        {
            InitializeComponent();

            worldsDB = WorldsDataBase.Instance;
            worldsDB.Path = @"Data\worlds\worlds.xml";
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bStartClick(object sender, EventArgs e)
        {
            World world = new World();
            world.Load(worldsDB.Select(_cbSelectWorld.Text));

            MainForm mainForm = new MainForm(world);
            mainForm.Show();
        }

        private void bSettingsClick(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.ShowDialog();
        }

        private void LauncherFormLoad(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            UpdateWorldList();
        }

        public void UpdateWorldList()
        {
            worldsDB.Load();

            _cbSelectWorld.Items.Clear();

            foreach (var worldName in worldsDB.WorldsNames())
                _cbSelectWorld.Items.Add(worldName);

            _cbSelectWorld.SelectedIndex = 0;
        }
    }
}
