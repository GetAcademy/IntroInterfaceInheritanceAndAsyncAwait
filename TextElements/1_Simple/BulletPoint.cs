namespace StarsAndTextElementsAsIntroToInterfaceAndInheritance._1_TextElements._1_Plain
{
    internal class BulletPoint 
    {
        private string _text;

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
