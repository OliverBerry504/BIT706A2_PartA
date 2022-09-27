using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIT706_A3_OliverBerry
{   
    class CustController
    {
        private List<Customer> allCustomers = new List<Customer>();

        public List<Customer> AllCustomers { get => allCustomers; 
            set => allCustomers = value; }

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

        public bool CreateCustomer(string name)
        {
            if (Customer.ValidateCustomerName(name))
            {
                Customer c = new Customer(name, false);
                AllCustomers.Add(c);
                return true;
            }
            else
            {
                // customer name must contain at least
                // one alphabet character
                throw new Exception("Invalid customer name");
            }
        }

        public bool EditCustomer(string newName, Customer c)
        {
            if (Customer.ValidateCustomerName(newName))
            {
                c.Name = newName;
                return true;
            }
            else throw new Exception("Invalid customer name");
        }

        public bool DeleteCustomer(Customer c)
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

        public int GetCustomerID(Customer c)
        {
            return c.ID;
        }
    }
}
