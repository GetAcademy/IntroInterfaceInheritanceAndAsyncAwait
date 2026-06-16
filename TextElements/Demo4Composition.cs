using TextElements._4_CompositionOverInheritance;

namespace TextElements
{
    internal class Demo4Composition
    {
        public static void Run()
        {
            var title = new TextElement("Velkommen", new HeaderFormatter('='));
            var bullet = new TextElement("Lær interface", new BulletPointFormatter());
            var note = new TextElement("Dette er viktig", new ParenthesesFormatter());

            title.Show();
            bullet.Show();
            note.Show();
        }
    }
}
