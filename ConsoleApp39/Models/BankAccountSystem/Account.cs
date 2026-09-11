using ConsoleApp39.BankAccountSystem;

namespace ConsoleApp39.Models.BankAccountSystem
{
    internal class Account
    {
        private static int _idCounter;
        public int Id { get; set; }
        public int AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public double Balance { get; set; } = 0;
        public bool IsActive { get; set; } = true;
        public Account(int accountNumber, string ownerName)
        {
            Id = ++_idCounter;
            AccountNumber = accountNumber;
            OwnerName = ownerName;
        }
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException("Deposit amount must be greater than zero.");
            }
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException("Withdrawal amount must be greater than zero.");
            }
            if (amount > Balance)
            {
                throw new InsufficientBalanceException("Insufficient balance for the withdrawal.");
            }
            Balance -= amount;
        }
        public void Transfer(Account targetAccount, double amount)
        {
            if (targetAccount == null)
            {
                throw new AccountNotFoundException("Target account not found.");
            }
            if (amount <= 0)
            {
                throw new InvalidAmountException("Transfer amount must be greater than zero.");
            }
            if (amount > Balance)
            {
                throw new InsufficientBalanceException("Insufficient balance for the transfer.");
            }
            Balance -= amount;
            targetAccount.Balance += amount;
        }
        public string ShowInfo()
        {
            return $"Id: {Id}, Account Number: {AccountNumber}, Owner Name: {OwnerName}, Balance: {Balance}, Is Active: {IsActive}";
        }
    }
}
