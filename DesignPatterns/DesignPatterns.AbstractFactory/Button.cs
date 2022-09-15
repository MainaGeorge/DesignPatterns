namespace DesignPatterns.AbstractFactory
{
    public class Button : IDisplay
    {
        private Theme _theme;

        public Button(Theme theme)
        {
            _theme = theme;
        }

        public override string ToString()
        {
            return "Button";
        }
        public string Render()
        {
            return $"displaying {this} with the theme {_theme}";
        }
    }


}