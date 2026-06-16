using TextElements._2_Interface;

namespace TextElements
{
    internal class Demo2Interface
    {
        public static void Run()
        {
            var header = new CenteredHeader("TERJE", '-');
            var bulletPoint1 = new BulletPoint("A");
            var bulletPoint2 = new BulletPoint("B");
            var bulletPoint3 = new BulletPoint("C");
            var paragraph = new IndentedParagraph("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
            var invertedText = new InvertedText("Terje");

            var textElements = new ITextElement[]
            {
                header, bulletPoint1, bulletPoint2, bulletPoint3, paragraph, invertedText
            };
            foreach (var textElement in textElements)
            {
                textElement.Show();
            }
        }
    }
}