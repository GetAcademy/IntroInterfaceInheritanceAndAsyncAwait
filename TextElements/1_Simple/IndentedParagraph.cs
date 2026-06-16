namespace StarsAndTextElementsAsIntroToInterfaceAndInheritance._1_TextElements._1_Plain
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
