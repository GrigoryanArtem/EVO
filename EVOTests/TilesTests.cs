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
            Tile tile = new WaterTile(new Coordinate(0, 0));

            Assert.AreEqual(100, tile.Properties.Humidity);
            Assert.AreEqual(100, tile.Properties.Passability);
            Assert.AreEqual(17, tile.Properties.Temperature);
            Assert.AreEqual(new Coordinate(0, 0), tile.Properties.Position);
        }
    }
}
