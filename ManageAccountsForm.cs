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
        }

        internal ManageAccountsForm(Customer c) : this()
        {
            Selected = c;
            DisplayAll();
        }

        // Display all customers
        private void DisplayAll()
        {
            lst_all_accs.Items.Clear();
            foreach (Account a in AccCtrl.GetCustomerAccounts(Selected))
            {
                lst_all_accs.Items.Add(a);
            }
            try
            {
            lst_all_accs.SelectedIndex = 0;
            }
            catch (Exception)
            {
                lb_info.Text = "No account data";
            }
        }

        // Make deposit
        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tb_amount.Text, out double amount))
            {
                try
                {
                    Account acc = GetSelection();
                    AccCtrl.Deposit(acc, amount);
                    lb_info.Text = acc.LastTransaction;
                }
                catch (Exception error)
                {
                    // dosomething
                }

            }
            else lb_info.Text = "Invlaid input amount!";
        }

        // Make withdrawal
        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tb_amount.Text, out double amount))
            {
                Account acc = GetSelection();
                try
                {
                    acc.Withdraw(amount);
                    lb_info.Text = acc.LastTransaction;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else lb_info.Text = "Invlaid input amount!";
        }

        // Get account info
        private void BtnInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Account a = GetSelection();
                lb_info.Text = a.Info();
            }
            catch(Exception error) 
            {
                lb_info.Text = "No account selected"; // change maybe
            }
        }

        // Add interest
        private void BtnAddInterest_Click(object sender, EventArgs e)
        {
            try
            {   
                Account a = GetSelection();
                if (a.AccType == "Investment")
                {
                    Investment acc = (Investment)a;
                    acc.DepositInterest();
                    lb_info.Text = a.LastTransaction;
                }
                else if (a.AccType == "Omni")
                {
                    Omni acc = (Omni)a;
                    acc.DepositInterest();
                    lb_info.Text = a.LastTransaction;
                }
                else
                {
                    lb_info.Text = "Interest does not apply!";
                }
            }
            catch (Exception error)
            {
                // do something
            }
        }

        // Return selected account type
        private Account GetSelection()
        {
            if (lst_all_accs.SelectedIndex > -1)
            {
                Account a = (Account)lst_all_accs.SelectedItem;
                return a;
            }
            else return null;
        }

        private void Btn_return_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ManageCustomersForm form = new ManageCustomersForm();
            form.Show();
        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SelectAccountForm form = new SelectAccountForm(Selected);
            form.Show();
        }

        private void Btn_transfer_Click(object sender, EventArgs e)
        {
            try
            {
                Account acc = GetSelection();
                TransferForm form = new TransferForm(acc);
                form.Show();
            }
            catch (Exception)
            {
                // do something
            }
        }
    }
}

// i need to set the manage accounts form's selection as a list box like in manage customers. 
// use same methods etc..
//