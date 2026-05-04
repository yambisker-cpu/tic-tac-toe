namespace TicTacToe
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}