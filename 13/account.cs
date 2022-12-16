using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _13
{
    public class account
    {
        Random rand = new Random();
        static ulong nomer = 0000_0001_0002_0003;
        private List<BankTransaction> transactions = new List<BankTransaction>();
        public BankTransaction this[int index]
        {
            get
            {
                if (index < 0 || index >= transactions.Count)
                {
                    throw new ArgumentOutOfRangeException($"Элемента с индексом {index} нет");
                }
                return transactions[index];

            }
            set
            {
                if (index<0 || index >= transactions.Count)
                {
                    throw new ArgumentOutOfRangeException($"Элемента с индексом {index} нет");
                }
                transactions[index] = value;
            }
        }
        public ulong Nomer { get; }
        public TypeAccount Type { get; }
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Отрицательное значение");
                }
                else
                {
                    balance = value;
                }
            }
        }

        internal account(TypeAccount type,decimal balance)
        {
            Type = type;
            Balance = balance;
            Nomer = nomer + (ulong)rand.Next(1, 9);
            nomer = Nomer;
        }

        internal account(TypeAccount type): this(type, 0) { }
        internal account(decimal balance): this(TypeAccount.Actual, balance) { }
        internal account(): this(TypeAccount.Actual, 0) { }
        public bool Withdraw(decimal money)
        {
            if (money > Balance)
            {
                return false;
            }
            else
            {
                Balance = Balance - money;
                transactions.Add(new BankTransaction(money, TypeTransaction.Withdraw));
                return true;
            }
        }
        public void Put(decimal money)
        {
            if (money <= 0)
            {
                Console.WriteLine("Минимальная сумма 10 рублей");
                transactions.Add(new BankTransaction(money, TypeTransaction.Put));
                return;
            }
            Balance += money;
        }
        public bool Transfer(account Acc,decimal money)
        {
            Balance += money;
            transactions.Add(new BankTransaction(money, TypeTransaction.Transfer));
            return true;
        }
        public void Print()
        {
            Console.WriteLine($"Сoстояние счёта: {Type}\t{Nomer}\t{balance}");
        }
        public override string ToString()
        {
            return $"{Type}\t{Nomer}\t{balance}";
        }
    }
}
