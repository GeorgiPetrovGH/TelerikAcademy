using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer client, decimal balance, decimal interest) : base(client, balance, interest)
        {
        }

        public void Withdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("You cannot withdraw more than the balance of the account.");
            }
            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance >= 1000.0M)
            {
                return months * ((this.InterestRate / 100.0M) * this.Balance);
            }
            else return 0.0M;
        }

    }
}
