namespace MovingObjects
{
    internal class TeleportingPlus
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
            _col = (_col + _speedCol) % Console.WindowWidth;
            _row = (_row + _speedRow) % Console.WindowHeight;
        }
    }
}
