namespace Stars._1_Plain
{
    internal class MovingStar
    {
        private int _col;
        private int _row;

        public MovingStar(int col, int row)
        {
            _row = row;
            _col = col;
        }

        public void Show()
        {
            Console.SetCursorPosition(_col, _row);
            Console.Write('*');
        }

        public void Update()
        {
            _col = (_col + 1) % Console.WindowWidth;
        }
    }
}
