using DesignPatterns.Composite;

namespace DesignPatterns.Tests
{
    public class CompositeTests
    {
        [Fact]
        public void Composite_Calls_AllObjects()
        {
            var circle = new Circle();
            var circle2 = new Circle();
            var circle3 = new Circle();
            var square = new Square();
            var square2 = new Square();


            var group = new Group();
            group.AddDrawableObject(circle);
            group.AddDrawableObject(circle2);
            group.AddDrawableObject(square2);

            var group2 = new Group();
            group2.AddDrawableObject(circle3);
            group2.AddDrawableObject(circle3);
            group2.AddDrawableObject(group);
            group2.AddDrawableObject(square);
            group2.Draw();

            var circlesInGroup2 = group2.GetNumberOfDrawableObjectOfType<Circle>();
            var circlesInGroup1 = group.GetNumberOfDrawableObjectOfType<Circle>();
            var squaresInGroup2 = group2.GetNumberOfDrawableObjectOfType<Square>();

            Assert.Equal(3, group.DrawableObjects.Count);
            Assert.Equal(2, circlesInGroup1);
            Assert.Equal(3, circlesInGroup2);
            Assert.Equal(2, squaresInGroup2);


            Assert.Equal(group.GetDrawnMessagesOfConcreteShape("Circle"), circlesInGroup1);
            Assert.Equal(group2.GetDrawnMessagesOfConcreteShape("Circle"), circlesInGroup2);
            Assert.Equal(group2.GetDrawnMessagesOfConcreteShape("Square"), squaresInGroup2);
        }
    }
}
