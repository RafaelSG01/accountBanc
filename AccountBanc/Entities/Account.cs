using AccountBanc.Entities.Exceptions;

namespace AccountBanc.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if(balance <= 0.0)
            {
                throw new DomainExeption("Não há saldo na conta!!");
            }

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainExeption("O valor excede o limite");
            }
            if(Balance < amount)
            {
                throw new DomainExeption("Saldo insuficiente!");
            }
            Balance -= amount;
        }
    }
}
