namespace MovingObjects
{
    internal class TeleportingPlus : IMovingObject
    {
        private int _col;
        private int _row;
        private int _speedCol;
        private int _speedRow;

        public TeleportingPlus(int col, int row, int speedCol, int speedRow)
        {
            _col = col;
            _row = row;
            _speedCol = speedCol;
            _speedRow = speedRow;
        }

        public void Show()
        {
            Console.CursorLeft = _col;
            Console.CursorTop = _row;
            Console.Write("+");
        }

        public void Move()
        {
            var w= Console.WindowWidth;
            var h = Console.WindowHeight;
            _col = (_col + _speedCol + w) % w;
            _row = (_row + _speedRow + h) % h;
        }
    }
}
