namespace DesignPatterns.Template
{
    public abstract class Shape
    {
        protected int BrushSize { get; set; } = 2;
        protected string Color { get; set; } = "black";

        protected Shape()
        {
        }

        protected Shape(int brushSize, string color)
        {
            BrushSize = brushSize;
            Color = color;
        }

        public string Draw()
        {
            return DrawShape();
        }
        protected abstract string DrawShape();
    }
}