namespace TextElements._2_Interface
{
    internal class BulletPoint : ITextElement
    {
        private readonly string _text;

        public BulletPoint(string text)
        {
            _text = text;
        }

        public void Show()
        {
            Console.Write(" * ");
            Console.WriteLine(_text);
        }
    }
}
