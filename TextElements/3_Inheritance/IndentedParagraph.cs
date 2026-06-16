namespace TextElements._3_Inheritance
{
    internal class IndentedParagraph :TextElement
    {
        public IndentedParagraph(string text) : base(text)
        {
        }

        public override void Show()
        {
            Console.Write("    ");
            base.Show();
        }
    }
}
