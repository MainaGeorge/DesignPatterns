using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class FormElements
    {
        private readonly IThemedHtmlElements _widgets;

        public FormElements(IThemedHtmlElements widgets)
        {
            _widgets = widgets;
        }

        public string DisplayElements()
        {
            var result = new StringBuilder();
            var button = _widgets.CreateButton();
            var textBox = _widgets.CreateTextBox();
            var radioButton = _widgets.CreateRadioButton();

            result.AppendLine(button.Render());
            result.AppendLine(textBox.Render());
            result.AppendLine(radioButton.Render());

            return result.ToString();
        }
    }



}