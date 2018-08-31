using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS214_FinalPart2._2_Odden
{
    class AccountHierarchyTest
    {
        public static void Main(string[] args)
        {
            // account object
            Account ac = new Account(1000M);
            // savings account object
            SavingsAccount sa = new SavingsAccount(ac.Balance, 0.06M);
            // checking account object
            CheckingAccount ca = new CheckingAccount(ac.Balance, 3M);

            // print initial account object balances    
            Console.WriteLine("{0}: {1:C}\n{2}: {3:C}\n",
               "Initial Savings Account balance", sa.Balance,
               "Initial Checking Account balance", ca.Balance);

            // Add interest to the SavingsAccount object by first invoking its CalculateInterest method
            // then pass the returned interest amount to the object’s Credit method.
            sa.Credit(sa.CalculateInterest());
            // print current interest rate, then new Savings Account balance
            Console.WriteLine("{0}: {1:0.00%}\n{2}: {3:C}\n",
                "Current interest rate for Savings Accounts", sa.InterestRate,
                "Savings Account balance after applying interest", sa.Balance);

            // testing savings account
            Console.WriteLine("Let's make a deposit of $100");
            sa.Credit(100M);
            Console.WriteLine("{0}: {1:C}\n",
                "Savings Account balance after credit", sa.Balance);
            Console.WriteLine("Now, let's make a withdrawal of $160");
            sa.Debit(160M);
            Console.WriteLine("{0}: {1:C}\n\n",
                "Savings Account balance after debit", sa.Balance);

            // testing checking account
            Console.WriteLine("{0}\n{1}: {2:C}", "How about our checking account?",
                                "Current transaction fee for deposits and withdrawals", ca.TransactionFee);
            Console.WriteLine("Let's make a withdrawal of $100");
            Console.WriteLine("{0}: {1:C}\n",
                "Checking Account balance after debit", ca.Debit(100M));
            Console.WriteLine("Now, let's make a deposit of $100");
            Console.WriteLine("{0}: {1:C}\n",
                "Checking Account balance after applying credit", ca.Credit(100M));
        }
    }
}
