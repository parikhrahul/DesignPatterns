using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_VS_Interface.FacadePattern
{
    public class LoanFacade
    {
        private Bank _bank;
        private CreditRating _creaditRating;
        private CreditHistory _creaditHistory;

        public LoanFacade()
        {
            _bank = new Bank();
            _creaditRating = new CreditRating();
            _creaditHistory = new CreditHistory();

        }

        public bool IsLoanApproved(string name, double loanAmount)
        {
            Account account = _bank.GetAccount(name);

            if (account == null)
            {

                Console.WriteLine("don't have account");
                return false;
            }

            if (!_creaditRating.EligibleForLoan(name))
            {
                Console.WriteLine($"{name} is not eligilbe for loan.");
                return false;
            }
            if (!_creaditHistory.HasDefaulted(name))
            {
                Console.WriteLine($"{name} has defaulted before.");
                return false;
            }

            if (account.balance < loanAmount /10)
            {
                Console.Error.WriteLine($"{name} does not have sufficient funds.");
                return false;
            }

            return true;
        }
    }
}
