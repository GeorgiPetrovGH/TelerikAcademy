using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer client, decimal balance, decimal interest) : base(client, balance, interest)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Client is Company)
            {
                if (months <= 12)
                {
                    return months * (this.Balance * 0.5M * (this.InterestRate / 100.0M));
                }
                else
                {
                    return (12 * (this.Balance * 0.5M * (this.InterestRate / 100.0M))) + ((months - 12) * ((this.InterestRate / 100M) * this.Balance));
                }
            }
            else
            {
                if (months <= 6)
                {
                    return 0.0M;
                }
                else
                {
                    return (months - 6) * ((this.InterestRate / 100.0M) * this.Balance);
                }
            }
        }
    }
}
