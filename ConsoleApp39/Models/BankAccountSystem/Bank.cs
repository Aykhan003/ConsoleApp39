namespace ConsoleApp39.Models.BankAccountSystem
{
    internal class Bank
    {
        private Account[] accounts = new Account[100];
        public void AddAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    return;
                }
            }
            throw new CapacityException("Bank capacity reached. Cannot add more accounts.");
        }
        public void GetAccount(int accountNumber)
        {
            foreach (var account in accounts)
            {
                if (account != null && account.AccountNumber == accountNumber)
                {
                    Console.WriteLine(account.ShowInfo());
                    return;
                }
            }
            throw new AccountNotFoundException($"Account with number {accountNumber} not found.");
        }
        public Account this[int index]
        {
            get
            {
                return accounts[index];
            }
            set
            {
                accounts[index] = value;
            }
        }
    }
}
