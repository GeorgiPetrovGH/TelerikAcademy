/*
Problem 2. Bank accounts

A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
All accounts have customer, balance and interest rate (monthly based).
    Deposit accounts are allowed to deposit and with draw money.
    Loan and mortgage accounts can only deposit money.

All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
Deposit accounts have no interest if their balance is positive and less than 1000.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
Your task is to write a program to model the bank system by classes and interfaces.
You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class MainProgram
    {
        static void Main()
        {
            var IndividualAccount = new MortgageAccount(new Individual("Individual"), 50000.0M, 25);
            var CompanyAccount = new MortgageAccount(new Company("Company"), 30500.0M, 50);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Mortgage Account");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Initial bank balance: {0}", IndividualAccount.Balance);
            IndividualAccount.Deposit(1000.0M);
            Console.WriteLine("Balance after adding 1000: {0}", IndividualAccount.Balance);
            Console.WriteLine("Interest for 6 months: {0}", IndividualAccount.CalculateInterest(6));
            Console.WriteLine();

            Console.WriteLine("Initial bank balance: {0}", CompanyAccount.Balance);
            CompanyAccount.Deposit(1000.0M);
            Console.WriteLine("Balance after adding 1000: {0}", CompanyAccount.Balance);
            Console.WriteLine("Interest for 6 months: {0}", CompanyAccount.CalculateInterest(6));
            Console.WriteLine();

            var IndividualAccount01 = new LoanAccount(new Company("Individual"), 129.0m, 2);
            var CompanyAccount01 = new LoanAccount(new Company("Company"), 175000.0m, 22);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Loan Account");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Initial bank balance: {0}", IndividualAccount01.Balance);
            IndividualAccount01.Deposit(100.0M);
            Console.WriteLine("Balance after adding 100: {0}", IndividualAccount01.Balance);
            Console.WriteLine("Interest for 6 months: {0}", IndividualAccount01.CalculateInterest(6));
            Console.WriteLine();

            Console.WriteLine("Initial bank balance: {0}", CompanyAccount01.Balance);
            CompanyAccount01.Deposit(100.0M);
            Console.WriteLine("Balance after adding 100: {0}", CompanyAccount01.Balance);
            Console.WriteLine("Interest for 6 months: {0}", CompanyAccount01.CalculateInterest(6));
            Console.WriteLine();


            var IndividualAccount02 = new DepositAccount(new Individual("Individual"), 7500.0m, 12);   
            var CompanyAccount02 = new DepositAccount(new Company("Company"), 12450.0m, 13);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Deposit Account");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Initial bank balance: {0}", IndividualAccount02.Balance);
            IndividualAccount02.Deposit(1000.0M);
            Console.WriteLine("Balance after adding 1000: {0}", IndividualAccount02.Balance);
            IndividualAccount02.Withdraw(2000);
            Console.WriteLine("Balance after taking 2000: {0}", IndividualAccount02.Balance);
            Console.WriteLine("Interest for 6 months: {0}", IndividualAccount02.CalculateInterest(6));
            Console.WriteLine();

            Console.WriteLine("Initial bank balance: {0}", CompanyAccount02.Balance);
            CompanyAccount02.Deposit(1000.0M);
            Console.WriteLine("Balance after adding 1000: {0}", CompanyAccount02.Balance);
            CompanyAccount02.Withdraw(2000);
            Console.WriteLine("Balance after taking 2000: {0}", CompanyAccount02.Balance);
            Console.WriteLine("Interest for 6 months: {0}", CompanyAccount02.CalculateInterest(6));
            Console.WriteLine();

        }
    }
}
