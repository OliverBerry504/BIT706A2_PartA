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

        private Account GetSelection()
        {
            if (lst_all_accs.SelectedIndex > -1)
            {
                Account a = (Account)lst_all_accs.SelectedItem;
                return a;
            }
            else return null;
        }

        private void Btn_deposit_Click(object sender, EventArgs e)
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
                    MessageBox.Show(error.Message);
                }

            }
            else lb_info.Text = "Invalid input amount!";
        }

        private void Btn_withdraw_Click(object sender, EventArgs e)
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
            else lb_info.Text = "Invalid input amount!";
        }

        private void Btn_info_Click(object sender, EventArgs e)
        {
            try
            {
                Account a = GetSelection();
                lb_info.Text = a.Info();
            }
            catch(Exception) 
            {
                lb_info.Text = "No account selected";
            }
        }

        private void Btn_add_interest_Click(object sender, EventArgs e)
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
            catch (Exception)
            {
                lb_info.Text = "No account selected";
            }
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
                TransferForm form = new TransferForm(Selected, acc);
                form.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("No selection");
            }
        }
    }
}
