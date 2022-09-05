namespace DesignPatterns.Command;

public class DepositCommand : BaseAccountCommand, ICommand
{
    public DepositCommand(IAccount account, int amount) : base(account, amount) { }
    public void Execute()
    {
        if (Amount <= 0)
            throw new InvalidOperationException($"{nameof(Amount)} must be greater than 0");
        Account.Balance += Amount;
    }
}