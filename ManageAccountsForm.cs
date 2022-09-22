using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT706_A3_OliverBerry
{
    public partial class ManageAccountsForm : ParentForm
    {
        private Customer selected;

        internal Customer Selected { get => selected; set => selected = value; }

        public ManageAccountsForm()
        {
            InitializeComponent();
            DisplayAll();
        }

        // Display all customers
        private void DisplayAll()
        {
            lstAllAcc.Items.Clear(); // create lstallacc
            foreach (Customer c in CustCtrl.GetAllCustomers())
            {
                lstAllAcc.Items.Add(c);
            }
            try
            {
                lstAllAcc.SelectedIndex = 0;
            }
            catch (Exception)
            {
                lbAccDetails.Text = "No customer data"; // also this
            }
        }

        internal ManageAccountsForm(Customer c) : this()
        {
            Selected = c;
        }

        // Make deposit
        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxAmount.Text, out double amount))
            {
                try
                {
                    Account acc = GetSelection();
                    AccCtrl.Deposit(acc, amount);
                    lbInfo.Text = acc.LastTransaction;
                }

            }
            else lbInfo.Text = "Invlaid input amount!";
        }

        // Make withdrawal
        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxAmount.Text, out double amount))
            {
                Account acc = GetSelection();
                try
                {
                    acc.Withdraw(amount);
                    lbInfo.Text = acc.LastTransaction;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else lbInfo.Text = "Invlaid input amount!";
        }

        // Get account info
        private void BtnInfo_Click(object sender, EventArgs e)
        {
            String acc = GetSelection();
            if (acc == "Omni") 
            {
                lbInfo.Text = accOmni.Info(); 
            }
            else if (acc == "Investment")
            {
                lbInfo.Text = accInvestment.Info();
            }
            else if (acc == "Everyday")
            {
                lbInfo.Text = accEveryday.Info();
            }
            else lbInfo.Text = "No account selected";
        }

        // Add interest
        private void BtnAddInterest_Click(object sender, EventArgs e)
        {
            String acc = GetSelection();

            if (acc == "Omni")
            {
                accOmni.DepositInterest();
                lbInfo.Text = accOmni.LastTransaction;
            }
            else if (acc == "Investment")
            {
                accInvestment.DepositInterest();
                lbInfo.Text = accInvestment.LastTransaction;
            }
            else lbInfo.Text = "Interest does not apply!";
        }

        // Return selected account type
        private String GetSelection()
        {
            if (selectAcc.SelectedIndex > -1)
            {
                Account account = (Account)selectAcc.SelectedItem;
                string acc = account.AccType;
                return acc;
            }
            else return null;
        }
    }
}

// i need to set the manage accounts form's selection as a list box like in manage customers. 
// use same methods etc..
//