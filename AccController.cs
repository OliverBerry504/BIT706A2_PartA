using System;
using System.Collections.Generic;
using System.Text;

namespace BIT706_A3_OliverBerry
{
    class AccController
    {
        private List<Account> allAccounts = new List<Account>();
        private string errorMessage;

        public string ErrorMessage { get => errorMessage; set => errorMessage = value; }
        public List<Account> AllAccounts { get => allAccounts; set => allAccounts = value; }

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

        public bool Deposit(Account a, double amount)
        {
            if (a == null)
            {
                throw new Exception("Account object is null");
            }
            else
            {
                a.Deposit(amount);
                return true;
            }          
        }

        public bool Transfer(Account accTo, Account accFrom, double amount)
        {
            try
            {
                accFrom.Withdraw(amount);
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
                return false;
            }
            Deposit(accTo, amount);
            return true;
        }
    }
}
