using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using VisualLogic.Geometry;

namespace UnitTests.VisualLogic.Geometry
{
    [TestFixture]
    public class GexagonTests
    {
        [Test]
        public void ConstructorTest()
        {
            var gexagon = new Gexagon(new Point(200, 200), 40);
        }
    }
}
