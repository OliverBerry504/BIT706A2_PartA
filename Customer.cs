using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIT706_A3_OliverBerry
{
    [Serializable]
    public class Customer
    {
        private int iD;
        private bool isStaff;
        private string name;

        public string Name { get => name; set => name = value; }
        public bool IsStaff { get => isStaff; set => isStaff = value; }

        public int ID { get => iD; set => iD = value; }

        public Customer()
        {
            //ID = CustIdData.NextId;
            ID = 1;
        }
        
        public Customer(string newName, bool newIsStaff) : this()
        {
            name = newName;
            IsStaff = newIsStaff;
        }

        // checks if name given is valid
        public static bool ValidateCustomerName(string name)
        {       
            if (name == null)
            {
                return false;
            }
            if (!name.Any(x => char.IsLetter(x)))
            {
                return false;
            }
            else return true;
        }

        public double Discount(double fee)
        {
            if (isStaff)
            {
                fee /= 2;
            }
            return fee;
        }

        public override string ToString()
        {
            return "ID: " + ID + "; " + "Name: " + Name;
        }
    }
}
