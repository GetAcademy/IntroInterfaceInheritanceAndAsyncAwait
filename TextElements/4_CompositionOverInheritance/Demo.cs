namespace TextElements._4_CompositionOverInheritance
{
    internal class Demo
    {
        public static void Run()
        {
            var title = new TextElement("Velkommen", new HeaderFormatter());
            var bullet = new TextElement("Lær interface", new BulletPointFormatter());
            var note = new TextElement("Dette er viktig", new ParenthesesFormatter());

            title.Show();
            bullet.Show();
            note.Show();
        }
    }
}
