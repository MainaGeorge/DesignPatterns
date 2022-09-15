namespace DesignPatterns.AbstractFactory
{
    public interface IThemedHtmlElements
    {
        TextBox CreateTextBox();
        RadioButton CreateRadioButton();
        Button CreateButton();
    }



}