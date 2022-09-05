using DesignPatterns.Command;

namespace DesignPatterns.Tests
{
    public class CommandTests
    {
        private readonly BankAccount _bankAccount;
        private readonly DepositCommand _depositCommand;
        private readonly WithdrawCommand _withdrawCommand;
        private readonly CommandsManager _commandsManager;

        public CommandTests()
        {
            _bankAccount = new BankAccount("Google");
            _depositCommand = new DepositCommand(_bankAccount, 100);
            _withdrawCommand = new WithdrawCommand(_bankAccount, 50);
            _commandsManager = new CommandsManager();
        }

        [Fact]
        public void BankAccount_StartsWith_ZeroBalance()
        {
            Assert.Equal(0, _bankAccount.Balance);
        }

        [Fact]
        public void DepositCommand_IncreasesBalance_ByGivenAmount()
        {
            _depositCommand.Execute();
            Assert.Equal(_bankAccount.Balance, _depositCommand.Amount);
        }

        [Fact]
        public void WithdrawCommand_DecreasesBalance_ByGivenAmount()
        {
            _depositCommand.Execute();
            var newBalance = _bankAccount.Balance;

            _withdrawCommand.Execute();
            Assert.Equal(_bankAccount.Balance, newBalance - _withdrawCommand.Amount);
        }

        [Fact]
        public void ManagerCan_ExecuteAllCommands_AtOnce()
        {
            var initialBalance = _bankAccount.Balance;
            var expectedFinalBalance = initialBalance + _depositCommand.Amount - _withdrawCommand.Amount;

            _commandsManager.AddCommand(_withdrawCommand);
            _commandsManager.AddCommand(_depositCommand);
            _commandsManager.Execute();

            Assert.Equal(_bankAccount.Balance, expectedFinalBalance);
        }
    }
}
