using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EVOLibrary;

namespace EVO.Map
{
    public class WorldsDataBase
    {
        private Dictionary<string, string> _worlds = new Dictionary<string, string>();
        string _path;

        protected WorldsDataBase() { }

        sealed private class WorldsDataBaseCreated
        {
            static private readonly WorldsDataBase instance = new WorldsDataBase();

            static public WorldsDataBase Instance
            {
                get
                {
                    return instance;
                }
            }
        }
        static public WorldsDataBase Instance
        {
            get
            {
                return WorldsDataBaseCreated.Instance;
            }
        }

        public string Path
        {
            get
            {
                return _path;
            }
            set
            {
                _path = value;
            }
        }

        public List<string> WorldsNames()
        {
            List<string> names = new List<string>();

            foreach (var world in _worlds)
                names.Add(world.Key); 

            return names;
        }

        #region Work with information

        public void Load()
        {
            _worlds.Clear();

            XDocument loadFile = XDocument.Load(_path);
            XElement mainElement = loadFile.Element(Tags.WorldsTag);

            foreach (var world in mainElement.Elements(Tags.WorldTag))
                _worlds.Add(world.Attribute(Tags.NameTag).Value,
                    world.Attribute(Tags.PathTag).Value);
        }

        public string Select(string worldName)
        {
            if (_worlds.ContainsKey(worldName))
                return _worlds[worldName];

            return String.Empty;
        }

        public void Add(World world, string path)
        {
            string realPath = world.Name;

            realPath = realPath.ToLower();
            realPath = realPath.Replace(' ', '_');
            realPath += MainStrings.XmlFormat;
            realPath = path + realPath;

            world.Save(realPath);

            _worlds.Add(world.Name, realPath);

            XDocument loadFile = XDocument.Load(_path);
            XElement mainElement = loadFile.Element(Tags.WorldsTag);


            XElement newWorld = new XElement(Tags.WorldTag,
                new XAttribute(Tags.NameTag, world.Name),
                new XAttribute(Tags.PathTag, realPath));

            mainElement.Add(newWorld);

            loadFile.Save(_path);
        }

        #endregion
    }
}
