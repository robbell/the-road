using NUnit.Framework;

namespace TheRoad.Tests
{
    public class AreaTest
    {
        [Test]
        public void AdjacentAreasReferenceEachOther()
        {
            var area1 = new Area();
            var area2 = new Area();

            area1.North = area2;

            Assert.That(area1.North, Is.EqualTo(area2));
            Assert.That(area2.South, Is.EqualTo(area1));
        }

        [Test]
        public void AreasCanBeTraversedInAllDirections()
        {
            var topLeft = new Area();
            var topRight = new Area();
            var bottomRight = new Area();
            var bottomLeft = new Area();

            topLeft.East = topRight;
            topRight.South = bottomRight;
            bottomRight.West = bottomLeft;
            bottomLeft.North = topLeft;

            Assert.That(topLeft.South, Is.EqualTo(bottomLeft));
            Assert.That(bottomLeft.East, Is.EqualTo(bottomRight));
            Assert.That(bottomRight.North, Is.EqualTo(topRight));
            Assert.That(topRight.West, Is.EqualTo(topLeft));
        }
    }
}