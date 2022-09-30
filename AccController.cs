using System;
using System.Collections.Generic;
using System.Text;

namespace BIT706_A3_OliverBerry
{
    public class AccController
    {
        private List<Account> allAccounts = new List<Account>();

        public List<Account> AllAccounts { get => allAccounts; set => allAccounts = value; }

        /// <summary>
        /// returns the accounts of the selected customer
        /// </summary>
        /// <param name="c">The customer whose accounts are being retreived</param>
        /// <returns>A list of accounts that belong to the target customer</returns>
        public List<Account> GetCustomerAccounts(Customer c)
        {
            List<Account> accs = new List<Account>();

            foreach (Account a in AllAccounts)
            {
                if (a.Customer.ID == c.ID)
                {
                    accs.Add(a);
                }
            }
            return accs;
        }

        /// <summary>
        /// Creates a new 'Everyday' account
        /// </summary>
        /// <param name="c">The customer who the account will belong to</param>
        /// <returns>A boolean value corresponding to whather or not the account was created</returns>
        /// <exception cref="Exception">Thrown if target customer object is null</exception>
        public bool CreateAccEveryday(Customer c)
        {
            if (c == null)
            {
                throw new Exception("Customer object is null");
            }
            else
            {
                Everyday acc = new Everyday(c);
                AllAccounts.Add(acc);
                return true;
            }
        }

        /// <summary>
        /// Creates a new 'Investment' account
        /// </summary>
        /// <param name="c">The customer who the account will belong to</param>
        /// <returns>A boolean value corresponding to whather or not the account was created</returns>
        /// <exception cref="Exception">Thrown if target customer object is null</exception>
        public bool CreateAccInvestment(Customer c)
        {
            if (c == null)
            {
                throw new Exception("Customer object is null");
            }
            else
            {
                Investment acc = new Investment(c);
                AllAccounts.Add(acc);
                return true;
            }
        }

        /// <summary>
        /// Creates a new 'Omni' account
        /// </summary>
        /// <param name="c">The customer who the account will belong to</param>
        /// <returns>A boolean value corresponding to whather or not the account was created</returns>
        /// <exception cref="Exception">Thrown if target customer object is null</exception>
        public bool CreateAccOmni(Customer c)
        {
            if (c == null)
            {
                throw new Exception("Customer object is null");
            }
            else
            {
                Omni acc = new Omni(c);
                AllAccounts.Add(acc);
                return true;
            }
        }
        /// <summary>
        /// Make a deposit of a determined amount into an existing account
        /// </summary>
        /// <param name="a">The account being deposited to</param>
        /// <param name="amount">The amount to be deposited</param>
        /// <returns>A boolean vlaue corresponding to whether or not the deposit was made</returns>
        /// <exception cref="Exception">Thrown if no account has been selected</exception>
        public bool Deposit(Account a, double amount)
        {
            if (a == null)
            {
                throw new Exception("Please select an account");
            }
            else
            {
                a.Deposit(amount);
                return true;
            }
        }

        /// <summary>
        /// Make a withdrawal of a determined amount from an existing account
        /// </summary>
        /// <param name="a">the account being withdrawn from</param>
        /// <param name="amount">The amount to be withdrawn</param>
        /// <returns>A boolean vlaue corresponding to whether or not the deposit was made</returns>
        /// <exception cref="Exception">Thrown if no account has been selected</exception>        
        public bool Withdraw(Account a, double amount)
        {
            if (a == null)
            {
                throw new Exception("Please select an account");
            }
            else
            {
                a.Withdraw(amount);
                return true;
            }
        }

        /// <summary>
        /// Make a transfer between two exisitng accounts
        /// </summary>
        /// <param name="accTo">The account that the amount is being deposited to</param>
        /// <param name="accFrom">The account that the amount is being withdrawn from</param>
        /// <param name="amount">The amount being exchanged</param>
        /// <returns>A Boolean value corresponding to whether or not the transfer was made</returns>
        /// <exception cref="Exception">Thrown if the transfer results in a failed withdrawal</exception>
        public bool Transfer(Account accTo, Account accFrom, double amount)
        { 
            try
            {
                accFrom.TransferFrom(amount);
                Deposit(accTo, amount);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Invalid transaction!");
            }
        }
    }
}
