using System;
using System.Collections.Generic;
using System.Text;

namespace BIT706_A3_OliverBerry
{
    [Serializable]
    public class Omni : Account
    {
        private readonly double rate = 4.0;
        private readonly double fee = 10.00;
        private readonly double overdraft = 5000.00;

        public double Rate => rate;
        public double Fee => fee;
        public double Overdraft => overdraft;

        // -------- Constructors -------
        public Omni(Customer customer) : base(customer)
        {
            AccType = "Omni";
        }
        // ---------- Methods ----------
        // Display account info
        public override string Info()
        {
            return "Acc Info:\nCustomer ID: " + Customer.ID +
                   "\nOmni ID: " + AccountId +
                   "\nInterest rate: " + Rate +
                   "%\nOverdraft limit: $" + Overdraft +
                   "\nFee for failed transactions: $" + Fee +
                   "\nBalance: $" + Math.Round(Balance, 2) + "\n";
        }
        // Trensaction (Deposit)
        public override void Deposit(double amountIn)
        {
            base.Deposit(amountIn);  // Make Deposit

            LastTransaction = StoreLastDeposit(amountIn, AccType);
        }
        // Transaction (Withdrawal)
        public override void Withdraw(double amountOut)
        {
            if (amountOut > (Balance + Overdraft))  // Transaction fails
            {
                double f = Customer.Discount(Fee); // Apply discount if appropriate 
                Balance -= f;
                LastTransaction = StoreLastWithdrawal(amountOut, AccType, "Failed", f);
                throw new FailedWithdrawalException("Failed Withdrawal" + "\n[Acc - " + AccType + "]");
            }
            else
            {
                base.Withdraw(amountOut); // Transaction successful
                LastTransaction = StoreLastWithdrawal(amountOut, AccType, "Successfull", 0);
            }
        }
        // Transaction (Transfer from this account)
        public override void TransferFrom(double amountOut)
        {
            if (amountOut > (Balance + Overdraft))  // Transaction fails
            {
                double f = Customer.Discount(10.00); // Apply discount if appropriate 
                Balance -= f;
                LastTransaction = StoreLastWithdrawal(amountOut, AccType, "Failed", f);
                throw new FailedWithdrawalException("Failed Transfer" + "\n[Acc - " + AccType + "]");
            }
            else
            {
                base.Withdraw(amountOut); // Transaction successful
                LastTransaction = StoreLastWithdrawal(amountOut, AccType, "Successfull", 0);
            }
        }
        // Transaction (Interest)
        public void DepositInterest()
        {
            if (Balance > 1000)  // Check if add interest
            {
                double interest = CalcInterest(Balance, Rate);
                Balance += interest;
                LastTransaction = StoreLastInterest(interest, AccType);
            }
        }
    }
}

