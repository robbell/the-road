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
    }
}