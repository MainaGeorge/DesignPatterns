namespace DesignPatterns.AbstractFactory
{
    public class LightThemedHtmlElements : IThemedHtmlElements
    {
        public Button CreateButton()
        {
            return new Button(Theme.Light);
        }

        public RadioButton CreateRadioButton()
        {
            return new RadioButton(Theme.Light);
        }

        public TextBox CreateTextBox()
        {
            return new TextBox(Theme.Light);
        }
    }



}