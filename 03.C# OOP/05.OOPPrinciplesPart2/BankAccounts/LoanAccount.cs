using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer client, decimal balance, decimal interest) : base(client, balance, interest)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Client is Individual)
            {
                months = Math.Max(0, months - 3);
            }
            else
            {
                months = Math.Max(0, months - 2);
            }
            return months * ((this.InterestRate / 100.0M) * this.Balance);
        }
    }
}
