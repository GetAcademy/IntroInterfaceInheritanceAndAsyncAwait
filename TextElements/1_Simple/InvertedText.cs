namespace StarsAndTextElementsAsIntroToInterfaceAndInheritance._1_TextElements._1_Plain
{
    internal class InvertedText 
    {
        private string _text;

        public InvertedText(string text)
        {
            _text = text;
        }

        public void Show()
        {
            var foreColor = Console.ForegroundColor;
            var backColor = Console.BackgroundColor;
            Console.ForegroundColor = backColor;
            Console.BackgroundColor = foreColor;
            Console.WriteLine(_text);
            Console.ForegroundColor = foreColor;
            Console.BackgroundColor = backColor;
        }
    }
}
