namespace DesignPatterns.AbstractFactory
{
    public class TextBox : IDisplay
    {
        private Theme _theme;

        public TextBox(Theme theme)
        {
            _theme = theme;
        }

        public override string ToString()
        {
            return "TextBox";
        }
        public string Render()
        {
            return $"displaying {this} with the theme {_theme}";
        }
    }


}