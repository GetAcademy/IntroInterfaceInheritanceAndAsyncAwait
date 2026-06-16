namespace TextElements._1_Simple
{
    internal class InvertedText 
    {
        private readonly string _text;

        public InvertedText(string text)
        {
            _text = text;
        }

        public void Show()
        {
            SwapForegroundAndBackgroundColors();
            Console.WriteLine(_text);
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
