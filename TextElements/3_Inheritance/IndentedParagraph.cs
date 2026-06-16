namespace TextElements._3_Inheritance
{
    internal class IndentedParagraph :TextElement
    {
        private readonly string _text;

        public IndentedParagraph(string text)
        {
            _text = text;
        }

        public override void Show()
        {
            Console.Write("    ");
            Console.WriteLine(_text);
        }
    }
}
