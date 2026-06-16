namespace Stars._3_WithInheritance
{
    internal class BlinkingStar : Star
    {
        private int _phase;

        public BlinkingStar(int col, int row) : base(col, row)
        {
        }

        public override void Show()
        {
            base.Show();
            var c = _phase == 0 ? '*' : ' ';
            Console.Write(c);
        }

        public override void Update()
        {
            _phase = _phase == 0 ? 1 : 0;
        }
    }
}
