namespace TextElements._1_Simple
{
    internal class IndentedParagraph 
    {
        private string _text;

        public IndentedParagraph(string text)
        {
            _text = text;
        }

        public void Show()
        {
            Console.CursorLeft = 4;
            Console.WriteLine(_text);
        }
    }
}
