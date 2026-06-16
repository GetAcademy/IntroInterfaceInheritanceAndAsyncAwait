namespace TextElements._3_Inheritance
{
    internal class TextElement
    {
        private readonly string _text;

        public TextElement(string text)
        {
            _text = text;
        }

        public virtual void Show()
        {
            Console.WriteLine(_text);
        }
    }
}
