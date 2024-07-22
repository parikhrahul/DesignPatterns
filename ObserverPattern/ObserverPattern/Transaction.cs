using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public enum TransType
    {
        DR, CR
    }
    public class Transaction
    {
        private static long sequence = 100;
        public long txnNumber;
        public DateTime date;
        public double amount;
        public string remarks;
        public TransType type;

        public Transaction(double amount, string remarks, TransType type)
        {
            this.txnNumber = txnNumber;
            this.date = date;
            this.amount = amount;
            this.remarks = remarks;
            this.type = type;
        }
        public override string ToString() =>
        $"{txnNumber}: {date.Date:yyyy-MM-dd} {remarks} {amount} {type}";
    }
}
