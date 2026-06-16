namespace Stars._3_WithInheritance
{
    internal abstract class Star
    {
        protected int _col;
        protected int _row;

        protected Star(int col, int row)
        {
            _row = row;
            _col = col;
        }

        public virtual void Show()
        {
            Console.SetCursorPosition(_col, _row);
        }

        public abstract void Update();
    }
}
