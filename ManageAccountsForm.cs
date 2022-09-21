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
        Everyday accEveryday;
        Investment accInvestment;
        Omni accOmni;

        public ManageAccountsForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Create customer
            Customer customer = new Customer("Oliver", true);
            // Set combobox selections (accounts)

            // Create accounts for above customer
            accEveryday = new Everyday(customer);
            accInvestment = new Investment(customer, 6);
            accOmni = new Omni(customer, 5000);

            // Set the selection types
            selectAcc.Items.Add(accEveryday);
            selectAcc.Items.Add(accInvestment);
            selectAcc.Items.Add(accOmni);
        }

        // Make deposit
        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxAmount.Text, out double amount))
            {
                String acc = GetSelection();
                if (acc == "Omni")
                {
                    accOmni.Deposit(amount);
                    lbInfo.Text = accOmni.LastTransaction;
                }
                else if (acc == "Investment")
                {
                    accInvestment.Deposit(amount);
                    lbInfo.Text = accInvestment.LastTransaction;
                }
                else if (acc == "Everyday")
                {
                    accEveryday.Deposit(amount);
                    lbInfo.Text = accEveryday.LastTransaction;
                }
                else lbInfo.Text = "No account selected";

            }
            else lbInfo.Text = "Invalid input amount!";    
        }

        // Make withdrawal
        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxAmount.Text, out double amount))
            {
                String acc = GetSelection();
                try
                {
                    if (acc == "Omni")
                    {
                        accOmni.Withdraw(amount);
                        lbInfo.Text = accOmni.LastTransaction;
                    }
                    else if (acc == "Investment")
                    {
                        accInvestment.Withdraw(amount);
                        lbInfo.Text = accInvestment.LastTransaction;
                    }
                    else if (acc == "Everyday")
                    {
                        accEveryday.Withdraw(amount);
                        lbInfo.Text = accEveryday.LastTransaction;
                    }
                    else lbInfo.Text = "No account selected";
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else lbInfo.Text = "Invalid input amount!";
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
