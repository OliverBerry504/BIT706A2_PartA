using System;
using System.Collections.Generic;
using System.Text;

namespace BIT706_A3_OliverBerry
{
    [Serializable]
    public abstract class Account
    {   // In this application 'Everyday', 'Investment', and 'Omni' will be subject to the same ID system
        // (i.e, cannot have both Omni ID of 1 and Investment ID of 1)
        private int accountId = 1;
        private Customer customer;
        private string accType;
        private double balance;
        private string lastTransaction;

        // ---------- Getters and Setters ------------
        public int AccountId { get => accountId; set => accountId = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public double Balance { get => balance; set => balance = value; }
        public string LastTransaction { get => lastTransaction; set => lastTransaction = value; }
        public string AccType { get => accType; set => accType = value; }

        // ------------- Constructors ---------------
        public Account()
        {
            accountId = AccIdData.NextId; // comment this out when running Gherkin tests and un-comment the line below
            //accountId++;

            Balance = 0.00;
            LastTransaction = "No previous transcations!";
        }

        public Account(Customer newCustomer) : this()
        {
            Customer = newCustomer;
        }

        // --------------- Methods -----------------
        // Display account info
        public abstract string Info();

        // Transaction (Deposit)
        public virtual void Deposit(double amountIn)
        {
            Balance += amountIn;
        }
        // Transaction (Withdrawal)
        public virtual void Withdraw(double amountOut)
        {
            Balance -= amountOut;
        }

        // Transaction (Transfer)
        public virtual void TransferFrom(double amountOut)
        {
            Balance -= amountOut;
        }

        // Calculate interest w/ given rate
        public static double CalcInterest(double amountIn, double rate)
        {
            return ((amountIn + rate * (amountIn / 100)) - amountIn);
        }
        // Store most recent deposit details
        public string StoreLastDeposit(double amountIn, string accType)
        {
            return "Last Transaction:\nCustomer ID: " + customer.ID +
                   "\n" + accType + " ID: " + accountId +
                   "\nDeposit: $" + Math.Round(amountIn, 2) +
                   "\nBalance: $" + Math.Round(balance, 2) + "\n";
        }
        // Store most recent withdrawal detail
        public string StoreLastWithdrawal(double amountOut, string accType, string outCome, double fee)
        {
            return "Last Transaction:\nCustomer ID: " + customer.ID +
                   "\n" + accType + " ID: " + accountId +
                   "\nWithrawal: $" + Math.Round(amountOut, 2) +
                   "\n" + outCome + " transaction, Fee: $" + fee +
                   "\nBalance: $" + Math.Round(balance, 2) + "\n";
        }
        // Store most recent interest (deposit) details
        public string StoreLastInterest(double interestAmount, string accType)
        {
            return "Last Transaction:\nCustomer ID: " + customer.ID +
                   "\n" + accType + " ID: " + accountId +
                   "\nAdd interest: $" + Math.Round(interestAmount, 2) +
                   "\nBalance: $" + Math.Round(balance, 2) + "\n";
        }
        // To display correct string data in combobox
        public override string ToString()
        {
            return "ID: " + AccountId + "; " + AccType;
        }

    }
}

