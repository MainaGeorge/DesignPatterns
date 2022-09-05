namespace DesignPatterns.Command
{
    public interface ICommand
    {
        void Execute();
    }

    public interface IAccount
    {
        public int Balance { get; set; }
    }
}
