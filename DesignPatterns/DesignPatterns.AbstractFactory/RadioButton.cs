namespace DesignPatterns.AbstractFactory
{
    public class RadioButton : IDisplay
    {
        private Theme _theme;

        public RadioButton(Theme theme)
        {
            _theme = theme;
        }

        public override string ToString()
        {
            return "RadioButton";
        }
        public string Render()
        {
            return $"displaying {this} with the theme {_theme}";
        }
    }


}