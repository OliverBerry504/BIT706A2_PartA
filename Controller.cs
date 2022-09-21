using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIT706_A3_OliverBerry
{
    class Controller
    {
        private readonly List<Customer> AllCustomers = new List<Customer>();
        private string errorMessage;

        public string ErrorMessage { get => errorMessage; set => errorMessage = value; }

        public List<Customer> GetAllCustomers()
        {
            return AllCustomers;
        }

        // return customer object based on id number
        public Customer FindCustomerByID(int id)
        {
                foreach (Customer c in AllCustomers)
                {
                    if (c.ID == id)
                    {
                        return c;
                    }
                }
                throw new Exception("Customer does not exist");
        }

        // create new customer
        public bool CreateCustomer(string name)
        {
            try
            {
                if (!name.Any(x => char.IsLetter(x)))
                {   // customer name must contain at least
                    // one alphabet character
                    throw new Exception("Invalid customer name");
                }
                else
                {
                    Customer c = new Customer(name, false);
                    AllCustomers.Add(c);
                    return true;
                }
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
                return false;
            }
        }

        // edit existing customer
        public bool EditCustomer(string newName, Customer c)
        {
            try
            {
                if (c is null)
                {
                    throw new Exception("Invalid customer for edit");
                }
                else
                {
                    c.ValidateCustomerName(newName);
                    c.Name = newName;
                    return true;
                }
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
                return false;
            }
        }

        // delete existing customer
        public bool DeleteCustomer(Customer c)
        {
            try
            {
                if (c is null)
                {
                    throw new Exception("Customer object is null");
                }
                else
                {
                    AllCustomers.Remove(FindCustomerByID(c.ID));
                    return true;
                }
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
                return false;
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

            accTo.Deposit(amount);
            return true;
        }

        public bool CreateAccount(Customer c, string accType)
        {
            if (accType == "Everyday")
            {
                Everyday acc = new Everyday(c);
                return true;
            }
            else if (accType == "Investment")
            {
                Investment acc = new Investment(c, 4);
                return true;
            }
            else if (accType == "Omni")
            {
                Omni acc = new Omni(c, 5000);
                return true;
            }
            else return false;
        }
    }
}
