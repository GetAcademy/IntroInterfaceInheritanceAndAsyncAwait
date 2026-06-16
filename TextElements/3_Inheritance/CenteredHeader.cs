namespace TextElements._3_Inheritance
{
    internal class CenteredHeader : TextElement
    {
        public CenteredHeader(string text, char paddingChar)
            : base(CreateCenteredText(text, paddingChar))
        {
        }

        private static string CreateCenteredText(string text, char paddingChar)
        {
            var textStartPosition = (Console.WindowWidth - text.Length) / 2;
            var padCount = textStartPosition - 4;
            var padding = "  " + new string(paddingChar, padCount) + "  ";
            return padding + text + padding;
        }
    }
}
