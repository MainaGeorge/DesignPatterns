namespace DesignPatterns.Command;

public class BankAccount : IAccount
{
    public int Balance { get; set; }
    public string Name { get; set; }

    public BankAccount(string name)
    {
        Name = name;
    }
}