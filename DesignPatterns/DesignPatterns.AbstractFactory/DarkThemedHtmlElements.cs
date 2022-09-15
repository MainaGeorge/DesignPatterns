namespace DesignPatterns.AbstractFactory
{
    public class DarkThemedHtmlElements : IThemedHtmlElements
    {
        public Button CreateButton()
        {
            return new Button(Theme.Dark);
        }

        public RadioButton CreateRadioButton()
        {
            return new RadioButton(Theme.Dark);
        }

        public TextBox CreateTextBox()
        {
            return new TextBox(Theme.Dark);
        }
    }



}