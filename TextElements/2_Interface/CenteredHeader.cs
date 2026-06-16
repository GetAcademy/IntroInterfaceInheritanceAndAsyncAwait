namespace TextElements._2_Interface
{
    internal class CenteredHeader : ITextElement
    {
        private readonly string _text;
        private readonly char _paddingChar;

        public CenteredHeader(string text, char paddingChar)
        {
            _paddingChar = paddingChar;
            _text = text;
        }

        public void Show()
        {
            var textStartPosition = (Console.WindowWidth - _text.Length) / 2;
            var padCount = textStartPosition - 4;
            var padding = "  " + new string(_paddingChar, padCount) + "  ";
            Console.Write(padding);
            Console.Write(_text);
            Console.WriteLine(padding);
        }
    }
}
