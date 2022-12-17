using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    public enum TypeTransaction
    {
        Withdraw, Put, Transfer
    }
    public class BankTransaction
    {
        public readonly DateTime dateTime;
        public readonly decimal balance;
        public readonly TypeTransaction type;
        private List<BankTransaction> bankTransactions = new List<BankTransaction>();

        public BankTransaction this[int index]
        {
            get { return bankTransactions[index]; }
            set { bankTransactions[index] = value; }
        }
        public BankTransaction(decimal balance,TypeTransaction type)
        {
            this.balance = balance; 
            this.type = type;
            dateTime = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{dateTime.ToShortDateString()} {dateTime.ToLongTimeString()} {type} {balance}";
        }
    }
}
