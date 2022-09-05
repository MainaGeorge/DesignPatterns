namespace DesignPatterns.Command;

public class WithdrawCommand :BaseAccountCommand, ICommand
{
    public WithdrawCommand(IAccount account, int amount): base(account, amount) {}
    public void Execute()
    {
        if (Account.Balance <= 0)
            throw new InvalidOperationException($"{nameof(Amount)} must be greater than 0");
        if (Amount > Account.Balance)
            throw new InvalidOperationException("Insufficient funds");
        Account.Balance -= Amount;
    }
}