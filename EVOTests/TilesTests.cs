using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EVO.Tiles;
using EVO.Parameters;

namespace EVOTests
{
    [TestClass]
    public class TilesTests
    {
        [TestMethod]
        public void TestingCreation()
        {
            Coordinate position = new Coordinate(0, 0);
            Tile tile = new WaterTile(position);

            Assert.AreEqual(100, tile.Properties.Humidity);
            Assert.AreEqual(100, tile.Properties.Passability);
            Assert.AreEqual(17, tile.Properties.Temperature);
            Assert.AreEqual(position, tile.Properties.Position);

            tile = new DesertTile(position);
            tile = new ForestTile(position);
            tile = new PlainTile(position);
        }

        [TestMethod]
        public void CopyTest()
        {
            Coordinate a = new Coordinate(10, 10);
            Coordinate b = new Coordinate(a);

            a.X = 0;

            Assert.AreNotEqual(a.X,b.X);

            IIntrinsicTileProperties i = new TileProperties(1, 2, new Coordinate(3, 4), 5);
            IIntrinsicTileProperties k = new TileProperties(i);

            Assert.AreEqual(i.Humidity, k.Humidity);
            Assert.AreEqual(i.Position, k.Position);

            k.Humidity = 10;
            k.Position = new Coordinate(1, 2);

            Assert.AreNotEqual(i.Humidity, k.Humidity);
            Assert.AreNotEqual(i.Position, k.Position);
        }

        [TestMethod]
        public void TileCopyTest()
        {
            Tile a = new DesertTile(new Coordinate(0, 0));
            Tile b = a.Copy();

            Assert.AreNotEqual(a, b);
        }
    }
}
