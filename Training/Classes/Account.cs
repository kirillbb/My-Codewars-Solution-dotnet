namespace Training.Classes
{
    public delegate void AccountHandler(string message);

    public class Account
    {
        int balance;
        AccountHandler handler;

        public Account(int sum) => this.balance = sum;

        public void Add(int sum) => this.balance += sum;

        public void Take(int sum)
        {
            if (balance >= sum)
            {
                balance -= sum;

                handler?.Invoke($"Со счета списано {sum} у.е.");
            }
            else
            {
                handler?.Invoke($"Недостаточно средств. Баланс: {this.balance} у.е.");
            }
        }

        public void RegisterHandler(AccountHandler handler)
        {
            this.handler = handler;
        }
    }
}