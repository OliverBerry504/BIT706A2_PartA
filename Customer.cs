using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIT706_A2_OliverBerry_PartA
{
    class Customer
    {
        private string name;
        private static int nextID = 1;
        private int iD;

        public string Name { get => name; set => name = value; }
        public int ID { get => iD; set => iD = value; }

        public Customer()
        {
            ID = nextID;
            nextID++;
        }

        public Customer(string newName) : this()
        {
            Name = newName;
        }

        // checks if name given is valid
        public void ValidateCustomerName(string name)
        {
                if (!name.Any(x => char.IsLetter(x)))
                {
                    throw new Exception("Invalid customer name");
                }
        }

        public override string ToString()
        {
            return "ID: " + ID + "; " + "Name: " + Name;
        }
    }
}
