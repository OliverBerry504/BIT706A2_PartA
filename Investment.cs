using System;
using System.Collections.Generic;
using System.Text;

namespace BIT706_A3_OliverBerry
{   
    [Serializable]
    public class Investment : Account
    {
        private readonly double rate = 4.0;
        private readonly double fee = 10.00;

        public double Rate => rate;
        public double Fee => fee;

        // -------- Constructors -------
        public Investment(Customer customer) : base(customer)
        {
            AccType = "Investment";
        }
        // ---------- Methods ----------
        // Display account info
        public override string Info()
        {
            return "Acc Info:\nCustomer ID: " + Customer.ID +
                   "\nInvestment ID: " + AccountId +
                   "\nInterest rate: " + Rate +
                   "%\nFee for failed transactions: $" + Fee +
                   "\nBalance: $" + Math.Round(Balance, 2) + "\n";
        }
        // Trensaction (Deposit)
        public override void Deposit(double amountIn)
        {
            base.Deposit(amountIn);
            LastTransaction = StoreLastDeposit(amountIn, AccType);
        }
        // Transaction (Withdrawal)
        public override void Withdraw(double amountOut)
        {
            if (amountOut > Balance)
            {
                double f = Customer.Discount(Fee);
                Balance -= f;
                LastTransaction = StoreLastWithdrawal(amountOut, AccType, "Failed", f);
                throw new FailedWithdrawalException("Failed Withdrawal" + "\n[Acc - " + AccType + "]");
            }
            else
            {
                base.Withdraw(amountOut);
                LastTransaction = StoreLastWithdrawal(amountOut, AccType, "Successful", 0);
            }
        }
        // Transaction (Transfer from this account)
        public override void TransferFrom(double amountOut)
        {
            if (amountOut > Balance)
            {
                double f = Customer.Discount(10.00);
                Balance -= f;
                LastTransaction = StoreLastWithdrawal(amountOut, AccType, "Failed", f);
                throw new FailedWithdrawalException("Failed Transfer" + "\n[Acc - " + AccType + "]");
            }
            else
            {
                base.Withdraw(amountOut);
                LastTransaction = StoreLastWithdrawal(amountOut, AccType, "Successful", 0);
            }
        }
        // Transaction (Interest)
        public void DepositInterest()
        {
            double interest = CalcInterest(Balance, Rate);
            Balance += interest;
            LastTransaction = StoreLastInterest(interest, AccType);
        }
    }
}

