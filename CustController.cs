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

        /// <summary>
        /// Finds customer by their ID number
        /// </summary>
        /// <param name="id">The ID number of the customer being found</param>
        /// <returns>Customer who the target ID belongs to</returns>
        /// <exception cref="Exception">Thrown if no customer with the target ID exists</exception>
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

        /// <summary>
        /// Creates a new customer object
        /// </summary>
        /// <param name="name">The name of the customer being created</param>
        /// <returns>Boolean value corresponding to whether or not the customer was created</returns>
        /// <exception cref="Exception">Thrown if name is invalid (i.e., does not contain at least one alphabet character)</exception>
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
                throw new Exception("Invalid customer name");
            }
        }

        /// <summary>
        /// Edits an existing customer object
        /// </summary>
        /// <param name="newName">The updated name of the customer</param>
        /// <param name="c">THe customer whose name is being updated</param>
        /// <returns>>Boolean value corresponding to whether or not the customer was edited</returns>
        /// <exception cref="Exception">Thrown if the new name is invalid</exception>
        public bool EditCustomer(string newName, Customer c)
        {
            if (Customer.ValidateCustomerName(newName))
            {
                c.Name = newName;
                return true;
            }
            else throw new Exception("Invalid customer name");
        }

        /// <summary>
        /// Removes a customer object
        /// </summary>
        /// <param name="c">THe customer object being removed</param>
        /// <returns>Boolean value corresponding to whether or not the customer was deleted</returns>
        /// <exception cref="Exception">Thrown if the target customer object is null</exception>
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
