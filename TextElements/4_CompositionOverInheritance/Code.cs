namespace TextElements._4_CompositionOverInheritance
{
    public interface ITextFormatter
    {
        string Format(string text);
    }

    public class HeaderFormatter : ITextFormatter
    {
        private char _paddingChar;

        public HeaderFormatter(char paddingChar)
        {
            _paddingChar = paddingChar;
        }
        public string Format(string text)
        {
            var padding = new string(_paddingChar, 9);
            return padding + " " + text.ToUpper() + " " + padding;
        }
    }

    public class BulletPointFormatter : ITextFormatter
    {
        public string Format(string text)
        {
            return $"- {text}";
        }
    }

    public class ParenthesesFormatter : ITextFormatter
    {
        public string Format(string text)
        {
            return $"({text})";
        }
    }

    public class TextElement
    {
        private readonly string _text;
        private readonly ITextFormatter _formatter;

        public TextElement(string text, ITextFormatter formatter)
        {
            _text = text;
            _formatter = formatter;
        }

        public void Show()
        {
            Console.WriteLine(_formatter.Format(_text));
        }
    }


}
