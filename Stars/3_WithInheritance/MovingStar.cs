namespace Stars._3_WithInheritance
{
    internal class MovingStar : Star
    {
        public MovingStar(int col, int row) : base(col, row) 
        {
        }

        public override void Show()
        {
            base.Show();
            Console.Write('*');
        }

        public override void Update()
        {
            _col = (_col + 1) % Console.WindowWidth;
        }
    }
}
