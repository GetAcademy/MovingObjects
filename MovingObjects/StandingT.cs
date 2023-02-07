namespace MovingObjects
{
    internal class StandingT : IMovingObject
    {
        private int _col;
        private int _row;

        public StandingT(int col, int row)
        {
            _col = col;
            _row = row;
        }

        public void Show()
        {
            Console.CursorLeft = _col;
            Console.CursorTop = _row;
            Console.Write("T");
        }

        public void Move()
        {
        }
    }
}
