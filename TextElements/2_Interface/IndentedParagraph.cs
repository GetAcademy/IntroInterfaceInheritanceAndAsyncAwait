namespace TextElements._2_Interface
{
    internal class IndentedParagraph :ITextElement
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
