namespace TicTacToe
{
    public class MoveCommand : ICommand
    {
        private Cell _cell;
        private string _mark;

        public MoveCommand(Cell cell, string mark)
        {
            _cell = cell;
            _mark = mark;
        }

        public void Execute()
        {
            _cell.SetMark(_mark);
        }

        public void Undo()
        {
            _cell.Clear();
        }
    }
}