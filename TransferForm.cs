﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BIT706_A3_OliverBerry
{
    public partial class TransferForm : ParentForm
    {
        private readonly Account accFrom;
        private readonly Customer customer;

        public TransferForm()
        {
            InitializeComponent();
        }

        internal TransferForm(Customer c, Account acc) : this()
        {
            accFrom = acc;
            customer = c;
            DisplayAll();
        }

        private void DisplayAll()
        {
            lst_acc_to.Items.Clear();
            foreach (Account a in AccCtrl.GetCustomerAccounts(customer))
            {
                if (a != accFrom)
                {
                    lst_acc_to.Items.Add(a);
                }
            }
            try
            {
                lst_acc_to.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No accounts currently available");
            }
        }

        private void Btn_transfer_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tb_amount.Text, out double amount))
            {
                try
                {
                    Account a = GetSelection();
                    AccCtrl.Transfer(a, accFrom, amount);
                    MessageBox.Show("Transfer Successful");
                    this.Visible = false;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid input amount!");
            }
        }

        private void Btn_return_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private Account GetSelection()
        {
            if (lst_acc_to.SelectedIndex > -1)
            {
                Account a = (Account)lst_acc_to.SelectedItem;
                return a;
            }
            else return null;
        }

    }
}
