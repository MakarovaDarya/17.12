using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    public class account
    {
        Random rand = new Random();
        static ulong nomer = 0000_0001_0002_0003;
        public TypeAccount Type { get; set; }
        public ulong Nomer { get; private set; }
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

        internal account(TypeAccount type, decimal balance)
        {
            Type = type;
            Balance = balance;
            Nomer = nomer + (ulong)rand.Next(1, 9);
            nomer = Nomer;
        }

        internal account(TypeAccount type) : this(type, 0) { }
        internal account(decimal balance) : this(TypeAccount.Actual, balance) { }
        internal account() : this(TypeAccount.Actual, 0) { }
        public bool Withdraw(decimal money)
        {
            if (money > Balance)
            {
                return false;
            }
            else
            {
                Balance = Balance - money;
                return true;
            }
        }
        public void Put(decimal money)
        {
            if (money <= 0)
            {
                Console.WriteLine("Минимальная сумма 10 рублей");
                return;
            }
            Balance += money;
        }
        public bool Transfer(account Acc, decimal money)
        {
            Balance += money;
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
        public static bool operator ==(account num1, account num2)
        {
            if (num1.ToString().Equals(num2.ToString()))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(account num1, account num2)
        {
            if (num1.ToString().Equals(num2.ToString()))
            {
                return false;
            }
            return true;
        }
        public override bool Equals(object obj)
        {
            if (obj is account accoun)
            {
                return accoun == this;
            }
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine(ToString());
        }
    }
}
