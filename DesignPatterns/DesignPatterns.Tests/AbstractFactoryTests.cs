using DesignPatterns.AbstractFactory;

namespace DesignPatterns.Tests
{
    public class AbstractFactoryTests
    {
        [Fact]
        public void Abstract_CreatesFamilyOfRelatedObjects()
        {
            var darkThemedFormElements = new FormElements(new DarkThemedHtmlElements()).DisplayElements();
            var lightThemedFormElements = new FormElements(new LightThemedHtmlElements()).DisplayElements();


            Assert.Contains("displaying Button with the theme Dark", darkThemedFormElements);
            Assert.Contains("displaying TextBox with the theme Light", lightThemedFormElements);
            Assert.DoesNotContain("theme Light", darkThemedFormElements);
            Assert.DoesNotContain("theme Dark", lightThemedFormElements);
        }
    }
}
