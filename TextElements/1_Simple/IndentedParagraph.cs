namespace TextElements._1_Simple
{
    internal class IndentedParagraph 
    {
        private readonly string _text;

        public IndentedParagraph(string text)
        {
            _text = text;
        }

        public void Show()
        {
            Console.Write("    ");
            Console.WriteLine(_text);
        }
    }
}
