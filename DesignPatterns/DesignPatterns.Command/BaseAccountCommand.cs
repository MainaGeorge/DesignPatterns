namespace DesignPatterns.Command;

public abstract class BaseAccountCommand
{
    public int Amount { get; set; }
    protected readonly IAccount Account;

    protected BaseAccountCommand(IAccount account, int amount)
    {
        Amount = amount;
        Account = account;
    }
}