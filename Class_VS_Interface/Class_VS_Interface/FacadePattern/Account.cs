using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_VS_Interface.FacadePattern
{
    public class Account
    {
        public int accountNumber;
        public string holdersName;
        public double balance;

        public Account(int accountNumber, string holdersName, double balance)
        {
            this.accountNumber = accountNumber;
            this.holdersName = holdersName;
            this.balance = balance;
        }
    }

    public class Bank
    {
        List<Account> accounts = new();

        public Bank()
        {
            accounts.Add(new Account(101, "Mukesh Ambani", 100_000_000));
            accounts.Add(new Account(102, "Gautam Adani", 200_000_000));
            accounts.Add(new Account(103, "Anil Ambani", 100_000));
        }

        public Account GetAccount(string name)
        {
            string searchName = name.Trim();
            Account found = accounts
                                .Find(acc => acc.holdersName.Trim().Equals(searchName, StringComparison.OrdinalIgnoreCase));
            return found;
        }
    }

    public class Rating
    {
        public string name;
        public int rating;

        public Rating(string name, int rating)
        {
            this.name = name;
            this.rating = rating;
        }
    }

    public class CreditRating
    {
        List<Rating> ratings = new();

        public CreditRating()
        {
            ratings.Add(new Rating("Mukesh Ambani", 900));
            ratings.Add(new Rating("Gautam Adani", 750));
            ratings.Add(new Rating("Anil Ambani", 250));
        }

        public bool EligibleForLoan(string name)
        {
            string searchName = name.Trim();
            Rating person = ratings.Find(rating => rating.name.Trim().Equals(searchName, StringComparison.OrdinalIgnoreCase));
            if (null != person)
                return person.rating >= 650;
            return false;
        }
    }

    public class LoanHistory
    {
        public string name;
        public int loanAmount;
        public string paid;

        public LoanHistory(string name, int loanAmount, string paid)
        {
            this.name = name;
            this.loanAmount = loanAmount;
            this.paid = paid;
        }
    }

    public class CreditHistory
    {
        List<LoanHistory> history = new();

        public CreditHistory()
        {
            history.Add(new LoanHistory("Mukesh Ambani", 100000, "paid"));
            history.Add(new LoanHistory("Mukesh Ambani", 500000, "ongoing"));
            history.Add(new LoanHistory("Gautam Ambani", 10000000, "ongoing"));
            history.Add(new LoanHistory("Gautam Ambani", 15000000, "ongoing"));
            history.Add(new LoanHistory("Gautam Ambani", 2000000, "paid"));
            history.Add(new LoanHistory("Anil Ambani", 5000000, "paid"));
            history.Add(new LoanHistory("Anil Ambani", 10000000, "defaulted"));
        }

        public bool HasDefaulted(string name)
        {
            string searchName = name.Trim();
            LoanHistory result = history.Find(his =>
            {
                return his.name.Trim().Equals(searchName, StringComparison.OrdinalIgnoreCase)
                       && his.paid.Trim().Equals("defaulted", StringComparison.OrdinalIgnoreCase);
            });
            return null != result;
        }
    }
}
