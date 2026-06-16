using StarsAndTextElementsAsIntroToInterfaceAndInheritance._1_TextElements._1_Plain;

namespace StarsAndTextElementsAsIntroToInterfaceAndInheritance._1_TextElements
{
    internal class Demo1Simple
    {
        public static void Run()
        {
            var header = new CenteredHeader("TERJE", '-');
            var bulletPoint1 = new BulletPoint("A");
            var bulletPoint2 = new BulletPoint("A");
            var bulletPoint3 = new BulletPoint("A");
            var paragraph = new IndentedParagraph("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
            var invertedText = new InvertedText("Terje");

            header.Show();
            bulletPoint1.Show();
            bulletPoint2.Show();
            bulletPoint3.Show();
            paragraph.Show();
            invertedText.Show();
        }
    }
}
