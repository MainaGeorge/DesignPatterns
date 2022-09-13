using DesignPatterns.Flyweight;

namespace DesignPatterns.Tests
{
    public class FlyweightTests
    {
        [Fact]
        public void Flyweight_KeepsObjectsCreated_AtDesiredCount()
        {
            var pointsMap = new List<PointOnMap>()
            {
                new(24, 35, PointIconFactory.CreatePointIcon(PointType.CAFE)),
                new(74, 85, PointIconFactory.CreatePointIcon(PointType.CAFE)),
                new(84, 95, PointIconFactory.CreatePointIcon(PointType.CAFE)),
                new(34, 45, PointIconFactory.CreatePointIcon(PointType.HOSPITAL)),
                new(54, 65, PointIconFactory.CreatePointIcon(PointType.UNIVERSITY)),
                new(64, 75, PointIconFactory.CreatePointIcon(PointType.UNIVERSITY)),
                new(44, 55, PointIconFactory.CreatePointIcon(PointType.SCHOOL)),
                new(94, 15, PointIconFactory.CreatePointIcon(PointType.SCHOOL))
            };

            pointsMap.ForEach(p => Console.WriteLine(p.Draw()));

            Assert.Equal(4, PointIconFactory.NumberOfIconsCreated);
            Assert.Equal(1, PointIconFactory.GetIconsCreatedByType(PointType.CAFE));
            Assert.Equal(1, PointIconFactory.GetIconsCreatedByType(PointType.HOSPITAL));
            Assert.Equal(1, PointIconFactory.GetIconsCreatedByType(PointType.UNIVERSITY));
            Assert.Equal(1, PointIconFactory.GetIconsCreatedByType(PointType.SCHOOL));
        }
    }
}
