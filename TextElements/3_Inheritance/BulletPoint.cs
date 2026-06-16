namespace TextElements._3_Inheritance
{
    internal class BulletPoint : TextElement
    {
        private readonly string _text;

        public BulletPoint(string text)
        {
            _text = text;
        }

        public override void Show()
        {
            Console.Write(" * ");
            Console.WriteLine(_text);
        }
    }
}
