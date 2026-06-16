namespace TextElements._1_Simple
{
    internal class BulletPoint 
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
