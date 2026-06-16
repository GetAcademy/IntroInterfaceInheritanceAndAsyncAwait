namespace TextElements._3_Inheritance
{
    internal class InvertedText : TextElement
    {
        public InvertedText(string text) : base(text)
        {
        }

        public override void Show()
        {
            SwapForegroundAndBackgroundColors();
            base.Show();
            SwapForegroundAndBackgroundColors();
        }

        private void SwapForegroundAndBackgroundColors()
        {
            var foreColor = Console.ForegroundColor;
            Console.ForegroundColor = Console.BackgroundColor;
            Console.BackgroundColor = foreColor;
            // (Console.ForegroundColor, Console.BackgroundColor) = (Console.BackgroundColor, Console.ForegroundColor);
        }
    }
}
