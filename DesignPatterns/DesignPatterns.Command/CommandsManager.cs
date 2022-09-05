namespace DesignPatterns.Command
{
    public class CommandsManager : ICommand
    {
        private readonly Stack<ICommand> _commands = new();
        public void AddCommand(ICommand command)
        {
            _commands.Push(command);
        }

        public void Execute()
        {
            foreach (var command in _commands)
                command.Execute();
        }
    }
}
