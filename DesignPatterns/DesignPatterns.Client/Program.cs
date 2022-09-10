using DesignPatterns.Composite;

namespace DesignPatterns.Client
{
    internal static class Program
    {
        private static void Main()
        {
            var circle = new Circle();
            var circle2 = new Circle();
            var circle3 = new Circle();

            var group = new Group();
            group.AddDrawableObject(circle);
            group.AddDrawableObject(circle2);

            var group2 = new Group();
            group2.AddDrawableObject(circle3);
            group2.AddDrawableObject(circle3);
            group2.AddDrawableObject(group);
            group2.Draw();

            Console.WriteLine(group2.GetNumberOfDrawableObjectOfType<Circle>());
            Console.WriteLine(group2.GetDrawnMessagesOfConcreteShape("Circle"));
        }
    }
}