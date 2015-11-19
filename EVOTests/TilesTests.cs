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
    }
}
